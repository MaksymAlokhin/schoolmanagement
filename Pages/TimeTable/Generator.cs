using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Models;

namespace sms.Pages.TimeTable
{
    public class Generator
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<int> allGradesIds;
        List<int> allTeachersIds;
        List<Curriculum> curricula;
        public List<Lesson> lessons;
        public List<Tuple<int, int>> freeLastLessons; //Day, slot
        //public List<DaySlotCombo> freeLastLessons;
        public List<Tuple<int, int>> maxLessonsPerDay; //grade, quantity
        Random random;
        public Generator(sms.Data.ApplicationDbContext context,
                          ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            random = new Random();
            curricula = _context.Curricula.AsNoTracking().ToList();
            allGradesIds = _context.Grades.Select(g => g.Id).ToList();
            allTeachersIds = curricula
                .GroupBy(c => c.TeacherId)
                .Select(g => new
                {
                    Id = g.Key,
                    Qty = g.Sum(c => c.Quantity)
                })
                .OrderByDescending(c => c.Qty)
                .Select(c => c.Id)
                .ToList();

            lessons = new List<Lesson>();
            maxLessonsPerDay = _context.Curricula
                .GroupBy(c => c.GradeId)
                .Select(cl => new Tuple<int, int>
                (cl.Key, (int)(Math.Ceiling(cl.Sum(s => s.Quantity) / 5.0d))))
                .ToList();
        }
        public bool Generate()
        {
            foreach (int teacher in allTeachersIds)
            {
                //no more lessons to add
                var curr = curricula.Where(c => c.TeacherId == teacher && c.Quantity > 0).ToList();
                //if (curr.Count() == 0) return true;
                Shuffle(curr);
                for (int slot = 1; slot <= 8; slot++)
                {
                    for (int day = 1; day <= 5; day++)
                    {
                        foreach (var curriculum in curr)
                        {
                            if (NoConflicts(day, slot, curriculum.TeacherId, curriculum.GradeId))
                            {
                                _logger.LogInformation("Teacher {1}", teacher);
                                lessons.Add(
                                        new Lesson
                                        {
                                            Day = ((Day)day).ToString(),
                                            Slot = slot,
                                            Room = _context.Grades
                                            .Where(g => g.Id == curriculum.GradeId).Select(g => g.Room).Single().ToString(),
                                            GradeId = curriculum.GradeId,
                                            SubjectId = curriculum.SubjectId,
                                            TeacherId = teacher
                                        });
                                curriculum.Quantity--;

                                if (Generate()) return true;
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool NoConflicts(int day, int slot, int teacher, int grade)
        {
            //Teacher or grade are taken for this day/slot
            foreach (Lesson lesson in lessons)
            {
                if ((lesson.Day == ((Day)day).ToString()
                    && lesson.Slot == slot
                    && lesson.GradeId == grade)
                    ||
                    (lesson.Day == ((Day)day).ToString()
                    && lesson.Slot == slot
                    && lesson.TeacherId == teacher))
                    return false;
            }
            return true;
        }
        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public void RemoveGaps()
        {
            //!!!! remove below in production
            //lessons = _context.Lessons.ToList();
            List<Lesson> stranded = new List<Lesson>();
            List<Lesson> conflictingLessons = new List<Lesson>();
            foreach (int grade in allGradesIds)
            {
                for (int day = 1; day <= 5; day++)
                {
                    for (int slot = 2; slot <= 8; slot++) //start from 2 because only 2nd+ slot can have gaps before
                    {
                        //Find a gap
                        if (lessons.Any(l => l.Day == ((Day)day).ToString() && l.Slot == slot && l.GradeId == grade) &&
                         !lessons.Any(l => l.Day == ((Day)day).ToString() && l.Slot == slot - 1 && l.GradeId == grade))
                        {
                            _logger.LogInformation("Gap detected at day {1}, slot {2}, grade {3}", day, slot - 1, grade);
                            Lesson lonelyLesson = lessons.Single(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot && l.GradeId == grade);
                            //Find a conflicting lesson on this day
                            Lesson conflictingLesson = lessons
                                .Find(l => l.Day == ((Day)day).ToString() && l.Slot == slot - 1 && l.TeacherId == lonelyLesson.TeacherId);
                            if (conflictingLesson is null)
                            {
                                //If previous slot is empty, just move the lesson one slot earliler
                                //Impossible with generated timetable, but possible if there were previous swaps
                                //where there were 2 lessons on an island
                                if (!lessons.Any(l => l.Day == ((Day)day).ToString() && l.Slot == lonelyLesson.Slot - 1 && l.GradeId == lonelyLesson.GradeId))
                                {
                                    lonelyLesson.Slot--;
                                    _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);
                                    RemoveGaps();
                                }
                            }
                            else
                            {
                                conflictingLessons.Add(conflictingLesson);
                                //Find conflicting lessons on other days
                                //Find number of lessons on each day for the conflicting grade
                                var howManyLessonsPerDay = lessons
                                    .Where(l => l.GradeId == grade && l.Day != ((Day)day).ToString())
                                    .GroupBy(g => new { g.GradeId, g.Day })
                                    .Select(g => new
                                    {
                                        Day = (int)(Day)Enum.Parse(typeof(Day), g.Key.Day),
                                        Qty = g.Count()
                                    })
                                    .Where(g => g.Qty < 8)
                                    .OrderBy(g => g.Qty)
                                    .ToList();
                                //Find first free lesson on each day and determine conflicting lessons (lonely teacher has a lesson at this slot)
                                freeLastLessons = new List<Tuple<int, int>>();
                                foreach (var item in howManyLessonsPerDay)
                                {
                                    Lesson tempLesson = lessons
                                        .Find(l => l.Day == ((Day)item.Day).ToString()
                                        && l.Slot == item.Qty + 1
                                        && l.TeacherId == lonelyLesson.TeacherId);
                                    if (tempLesson is null)
                                    {
                                        freeLastLessons.Add(new Tuple<int, int>(item.Day, item.Qty + 1));
                                    }
                                    else conflictingLessons.Add(tempLesson);
                                }
                                foreach (Lesson conflictSpot in conflictingLessons)
                                {
                                    //Find free slots of the conflicting teacher for this day
                                    List<int> teacherFreeSlots = new List<int>();
                                    for (int slt = 1; slt <= 8; slt++)
                                    {
                                        if (!lessons.Any(l => l.Day == conflictSpot.Day && l.Slot == slt && l.TeacherId == lonelyLesson.TeacherId))
                                        {
                                            teacherFreeSlots.Add(slt);
                                        }
                                    }
                                    //Find potential lessons of other teachers to swap with
                                    List<Lesson> swappable = new List<Lesson>();
                                    foreach (int slt in teacherFreeSlots)
                                    {
                                        swappable.AddRange(lessons
                                            .FindAll(l => l.Day == conflictSpot.Day && l.Slot == slt && l.GradeId == conflictSpot.GradeId));
                                    }
                                    //Check if the lesson's teacher has a free lesson where the conflicting lesson is, so that we can swap
                                    foreach (Lesson lesson in swappable)
                                    {
                                        if (!lessons.Any(l => l.Day == conflictSpot.Day && l.Slot == conflictSpot.Slot && l.TeacherId == lesson.TeacherId))
                                        {
                                            int tempSlot = lesson.Slot;
                                            lesson.Slot = conflictSpot.Slot;
                                            conflictingLesson.Slot = tempSlot;
                                            if (!lessons.Any(l => l.Day == conflictSpot.Day && l.Slot == lonelyLesson.Slot - 1 && l.GradeId == lonelyLesson.GradeId))
                                            {
                                                lonelyLesson.Day = conflictSpot.Day;
                                                lonelyLesson.Slot = lesson.Slot;
                                            }
                                            _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);
                                            RemoveGaps();
                                            break; //we use only first free slot, rest is discarded
                                        }
                                        else
                                        {
                                            //If cannot swap in any day, put the lesson at the end of the day as the last lesson
                                            //(day is chosen as containing the least number of lessons)
                                            foreach (var daySlotCombo in freeLastLessons)
                                            {
                                                if (daySlotCombo is null) continue;
                                                else
                                                {
                                                    lonelyLesson.Day = ((Day)daySlotCombo.Item1).ToString();
                                                    lonelyLesson.Slot = daySlotCombo.Item2;
                                                    _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);
                                                    RemoveGaps();
                                                    break; //we use only first free slot, rest is discarded
                                                }
                                            }
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    enum Day
    {
        Пн = 1,
        Вт,
        Ср,
        Чт,
        Пт
    }
}

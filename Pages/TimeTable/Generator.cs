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
        List<Tuple<int, int>> maxLessonsPerDay; //grade, quantity
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
                .Select(c=> c.Id)
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
            List<Lesson> stranded = new List<Lesson>();
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
                            _logger.LogInformation("Gap detected at day {1}, slot {2}, grade {3}", day, slot-1, grade);
                            Lesson lonelyLesson = lessons.Single(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot && l.GradeId == grade);
                            //Find a conflicting lesson
                            Lesson conflictingLesson = lessons
                                .Find(l => l.Day == ((Day)day).ToString() && l.Slot == slot - 1 && l.TeacherId == lonelyLesson.TeacherId);
                            if (conflictingLesson is null) 
                                continue;
                            //Find free slots of the teacher for this day
                            List<int> teacherFreeSlots = new List<int>();
                            for (int slt = 1; slt <= 8; slt++)
                            {
                                if (!lessons.Any(l => l.Day == ((Day)day).ToString() && l.Slot == slt && l.TeacherId == lonelyLesson.TeacherId))
                                {
                                    teacherFreeSlots.Add(slt);
                                }
                            }
                            //Find potential lessons to swap with
                            List<Lesson> swappable = new List<Lesson>();
                            foreach (int slt in teacherFreeSlots)
                            {
                                swappable.AddRange(lessons
                                    .FindAll(l => l.Day == ((Day)day).ToString() && l.Slot == slt && l.GradeId == conflictingLesson.GradeId));
                            }
                            //Check if the lesson's teacher has a free lesson where the conflicting lesson is, so that we can swap
                            foreach(Lesson lesson in swappable)
                            {
                                if(!lessons.Any(l=>l.Day == ((Day)day).ToString() && l.Slot == conflictingLesson.Slot && l.TeacherId == lesson.TeacherId))
                                {
                                    int temp = lesson.Slot;
                                    lesson.Slot = conflictingLesson.Slot;
                                    conflictingLesson.Slot = temp;
                                    if(!lessons.Any(l => l.Day == ((Day)day).ToString() && l.Slot == lonelyLesson.Slot-1 && l.GradeId == lonelyLesson.GradeId))
                                    {
                                        lonelyLesson.Slot--;
                                    }
                                    _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot-1, grade); 
                                    RemoveGaps();
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

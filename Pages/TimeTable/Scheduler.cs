using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Data;
using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    public class Scheduler
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<Chromosome> firstlist;
        List<Chromosome> newlist;
        double firstlistfitness;
        double newlistfitness;
        int populationsize = 1000;
        int maxgenerations = 100;
        public static Chromosome finalson;
        Random random;
        List<int> allGradesIds;
        List<int> allTeachersIds;
        List<Curriculum> curricula;
        public List<Tuple<int, int>> freeLastLessons; //Day, slot
        public List<Lesson> lessons;

        public Scheduler(ApplicationDbContext context,
                          ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            random = new Random();
            curricula = _context.Curricula.AsNoTracking().ToList();
            lessons = new List<Lesson>();
            allTeachersIds = curricula
                .GroupBy(c => c.TeacherId)
                .Select(c => c.Key)
                .ToList();
            allGradesIds = curricula
                .GroupBy(c => c.GradeId)
                .Select(c => c.Key)
                .ToList();
            Generate();
            RemoveGaps();
            //do
            //{
            //    Curriculum curriculum = curricula.Where(c => c.Quantity > 0).ToList()[random.Next(curricula.Count())];
            //    string day = ((Day)random.Next(1, 6)).ToString();
            //    int slot = random.Next(1, 9);
            //    if (lessons.Any(l => l.Day == day
            //                     && l.Slot == slot
            //                     && l.GradeId == curriculum.GradeId))
            //        continue;
            //    curriculum.Quantity--;
            //    string room = _context.Grades.Where(g => g.Id == curriculum.GradeId).FirstOrDefault().Room ?? "";
            //    Lesson lesson = new Lesson()
            //    {
            //        Room = room,
            //        Day = day,
            //        Slot = slot,
            //        GradeId = curriculum.GradeId,
            //        SubjectId = curriculum.SubjectId,
            //        TeacherId = curriculum.TeacherId
            //    };
            //    lessons.Add(lesson);

            //} while (curricula.Sum(c => c.Quantity) > 0);


        }
        //Crossover of two DNAs
        //Схрещування двох ДНК
        public Chromosome Crossover(Chromosome partner)
        {
            Chromosome child = new Chromosome();
            List<Curriculum> curricula = _context.Curricula.AsNoTracking().ToList();
            foreach (Curriculum curriculum in curricula)
            {

                if (random.NextDouble() < 0.5)
                {
                    Lesson lesson = lessons.Where(l => l.GradeId == curriculum.GradeId
                        && l.SubjectId == curriculum.SubjectId
                        && l.TeacherId == curriculum.TeacherId).First();

                    child.lessons.Add(lesson);
                    lessons.Remove(lesson);
                }
                else
                {
                    Lesson lesson = partner.lessons.Where(l => l.GradeId == curriculum.GradeId
                        && l.SubjectId == curriculum.SubjectId
                        && l.TeacherId == curriculum.TeacherId).First();

                    child.lessons.Add(lesson);
                    partner.lessons.Remove(lesson);
                }
            }
            return child;
        }
        public void Mutate(double mutationRate)
        {
            for (int i = 0; i < _context.Curricula.Count(); i++)
            {
                if (random.NextDouble() < mutationRate)
                {

                }
            }
        }
        public bool Generate()
        {
            foreach (int teacher in allTeachersIds)
            {
                //Remaining unassigned lessons
                //Решта нерозподілених у розкладі уроків
                var curr = curricula.Where(c => c.TeacherId == teacher && c.Quantity > 0).ToList();

                //Randomize lesson allocation
                //Розподілення уроків випадковим чином
                Shuffle(curr);

                //Allocate lessons to free slots
                //Розподіл уроків у вільні слоти
                for (int slot = 1; slot <= 8; slot++)
                {
                    for (int day = 1; day <= 5; day++)
                    {
                        foreach (var curriculum in curr)
                        {
                            //If there are no conflicts, add a new lesson to this slot
                            //Якщо немає конфліктів, додати урок на це місце
                            if (NoConflicts(day, slot, curriculum.TeacherId, curriculum.GradeId))
                            {
                                _logger.LogInformation("Teacher {1}", teacher);
                                var grade = _context.Grades
                                                .Where(g => g.Id == curriculum.GradeId)
                                                .SingleOrDefault();
                                lessons.Add(
                                        new Lesson
                                        {
                                            Day = ((Day)day).ToString(),
                                            Slot = slot,
                                            Room = grade.Room == null ? "" :
                                                _context.Grades
                                                .Where(g => g.Id == curriculum.GradeId)
                                                .Select(g => g.Room)
                                                .SingleOrDefault()
                                                .ToString(),
                                            GradeId = curriculum.GradeId,
                                            SubjectId = curriculum.SubjectId,
                                            TeacherId = teacher
                                        });
                                curriculum.Quantity--;

                                //Recursion
                                //Рекурсія
                                if (Generate()) return true;
                            }
                        }
                    }
                }
            }
            return true;
        }
        //Determine if there are no conflicts in timetable
        //Визначення конфліктів у розкладі
        public bool NoConflicts(int day, int slot, int teacher, int grade)
        {
            //Teacher or grade are taken for this day/slot
            //Вчитель або клас зайнятий у цей день/слот
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

        //Randomize lesson allocation
        //Розподілення уроків випадковим чином
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

        //Remove gaps in timetable
        //Видалення "вікон" у розкладі учнів
        public bool RemoveGaps()
        {
            //!!!! remove below line in production, for testing only
            //lessons = _context.Lessons.ToList();

            //Lesson that has a gap before
            //Урок, що має вікно перед собою
            List<Lesson> stranded = new List<Lesson>();

            //Lessons that prevent a teacher to have a lesson on the gap
            //Уроки, що не дають вчителю провести урок на вікні
            List<Lesson> conflictingLessons = new List<Lesson>();

            //Find gaps
            //Знаходження вікон
            foreach (int grade in allGradesIds)
            {
                for (int day = 1; day <= 5; day++)
                {
                    //Start from 2 because only 2nd+ slot can have gaps before
                    //Починаємо з 2 уроку, тому що лише 2+ урок може мати вікно перед собою
                    for (int slot = 2; slot <= 8; slot++)
                    {
                        //Find a gap
                        //Знаходження вікна
                        if (lessons.Any(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot
                                && l.GradeId == grade)
                            &&
                         !lessons.Any(l => l.Day == ((Day)day).ToString()
                                 && l.Slot == slot - 1
                                 && l.GradeId == grade))
                        {
                            _logger.LogInformation("Gap detected at day {1}, slot {2}, grade {3}", day, slot - 1, grade);

                            //Lesson that has a gap before
                            //Урок, що має вікно перед собою
                            Lesson lonelyLesson = lessons.Single(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot
                                && l.GradeId == grade);

                            //Lesson that prevents a teacher to have a lesson on the gap
                            //Урок, що не дає вчителю провести урок на вікні
                            Lesson conflictingLesson = lessons
                                .Find(l => l.Day == ((Day)day).ToString()
                                        && l.Slot == slot - 1
                                        && l.TeacherId == lonelyLesson.TeacherId);

                            //Move lesson up
                            //Підняття уроку
                            if (conflictingLesson is null)
                            {
                                //If previous slot is empty, just move the lesson one slot earliler
                                //Impossible with generated timetable, but possible if there were previous swaps
                                //where there were 2 lessons on an island
                                //
                                //Якщо попередній слот вільний, просто підняти урок
                                //Неможливо після генерації уроків
                                //Але можливо, коли було вікно, а за ним два уроки
                                //Тоді алгоритм рухає перший урок,
                                //А другий може випадково змогти піднятись без конфлікту
                                if (!lessons.Any(l => l.Day == ((Day)day).ToString()
                                                    && l.Slot == lonelyLesson.Slot - 1
                                                    && l.GradeId == lonelyLesson.GradeId))
                                {
                                    lonelyLesson.Slot--;
                                    _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);

                                    //Recursion
                                    //Рекурсія
                                    if (RemoveGaps()) return true;
                                }
                            }
                            //Could not move lesson up because of conflict
                            //Не змогли підняти урок через конфлікт
                            else
                            {
                                //Find if we can put the lonely lesson as the last lesson on other day
                                //Знаходження можливості помістити урок з вікном останнім уроком у інший день

                                conflictingLessons.Add(conflictingLesson);

                                //Find number of lessons on each day for the conflicting grade
                                //Знаходження кількості уроків, що цей клас має у інші дні
                                var howManyLessonsPerDay = lessons
                                    .Where(l => l.GradeId == grade
                                            && l.Day != ((Day)day).ToString()) //not this day
                                    .GroupBy(g => new { g.GradeId, g.Day })
                                    .Select(g => new
                                    {
                                        Day = (int)(Day)Enum.Parse(typeof(Day), g.Key.Day), //(int)Enum.Parse(typeof(Day), g.Key.Day) - also possible
                                        Qty = g.Count()
                                    })
                                    .Where(g => g.Qty < 8) //don't take days with 8 lessons (8 is max per day)
                                    .OrderBy(g => g.Qty)
                                    .ToList();

                                //Find first free lesson on each day and determine conflicting lessons
                                //(lonely teacher has a lesson at this slot)
                                //
                                //Знаходження першого вільного останнього уроку та пошук конфілктних уроків
                                //(вчитель уроку з вікном має на цьому вільному останньому уроці інший урок)
                                freeLastLessons = new List<Tuple<int, int>>();
                                foreach (var item in howManyLessonsPerDay)
                                {
                                    Lesson tempLesson = lessons
                                        .Find(l => l.Day == ((Day)item.Day).ToString()
                                        && l.Slot == item.Qty + 1
                                        && l.TeacherId == lonelyLesson.TeacherId);
                                    if (tempLesson is null)
                                    {
                                        //Free last lesson spots
                                        //Вільні останні уроки
                                        freeLastLessons.Add(new Tuple<int, int>(item.Day, item.Qty + 1));
                                    }
                                    //Fill list of conflicting lessons
                                    //Заповнення списку конфліктних уроків
                                    else conflictingLessons.Add(tempLesson);
                                }
                                foreach (Lesson conflictSpot in conflictingLessons)
                                {
                                    //Find free slots of the conflicting teacher for this day
                                    //Знаходження вільних уроків у конфліктного вчителя у цей день
                                    List<int> teacherFreeSlots = new List<int>();
                                    for (int slt = 1; slt <= 8; slt++)
                                    {
                                        if (!lessons.Any(l => l.Day == conflictSpot.Day
                                                            && l.Slot == slt
                                                            && l.TeacherId == lonelyLesson.TeacherId))
                                        {
                                            teacherFreeSlots.Add(slt);
                                        }
                                    }

                                    //Find potential lessons of other teachers in the same grade to swap with
                                    //Знаходження потенційних уроків інших вчителів у цьому ж класі, з якими можна помітянись
                                    List<Lesson> swappable = new List<Lesson>();
                                    foreach (int slt in teacherFreeSlots)
                                    {
                                        swappable.AddRange(lessons
                                                            .FindAll(l => l.Day == conflictSpot.Day
                                                                    && l.Slot == slt
                                                                    && l.GradeId == conflictSpot.GradeId));
                                    }
                                    //Check if the lesson's teacher has a free lesson where
                                    //the conflicting lesson is, so that we can swap
                                    //
                                    //Перевірка, чи має інший вчитель вільний урок на місці
                                    //конфліктного уроку, для можливості обміну місцями
                                    foreach (Lesson lesson in swappable)
                                    {
                                        //If other teacher has no lesson, swap conflicting
                                        //lesson with other teacher's lesson
                                        //
                                        //Якщо в іншого вчителя немає уроку, то міняємо місцями
                                        //Конфліктний урок і урок іншого вчителя
                                        if (!lessons.Any(l => l.Day == conflictSpot.Day
                                                            && l.Slot == conflictSpot.Slot
                                                            && l.TeacherId == lesson.TeacherId))
                                        {
                                            //Do the swap
                                            //Міняємо місцями
                                            int tempSlot = lesson.Slot;
                                            lesson.Slot = conflictSpot.Slot;
                                            conflictingLesson.Slot = tempSlot;

                                            //Check and move lesson to the gap
                                            //Перевірка і підняття уроку з вікном
                                            if (!lessons.Any(l => l.Day == conflictSpot.Day
                                                                && l.Slot == lonelyLesson.Slot - 1
                                                                && l.GradeId == lonelyLesson.GradeId))
                                            {
                                                lonelyLesson.Day = conflictSpot.Day;
                                                lonelyLesson.Slot = lesson.Slot;
                                                _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);

                                                //Recursion
                                                //Рекурсія
                                                if (RemoveGaps()) return true;
                                            }
                                        }
                                    }
                                }
                                //If cannot swap in any day, put the lesson at the end of the day as the last lesson
                                //(day is chosen as containing the least number of lessons)
                                //Якщо не змогли обміняти місцями уроки у жодний з днів, то поміщаємо урок
                                //останнім у день, де у класу найменше уроків
                                foreach (var daySlotCombo in freeLastLessons)
                                {
                                    if (daySlotCombo is null) continue;
                                    else
                                    {
                                        lonelyLesson.Day = ((Day)daySlotCombo.Item1).ToString(); //day
                                        lonelyLesson.Slot = daySlotCombo.Item2; //slot
                                        _logger.LogInformation("Gap removed at day {1}, slot {2}, grade {3}", day, slot - 1, grade);

                                        //Recursion
                                        //Рекурсія
                                        if (RemoveGaps()) return true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}

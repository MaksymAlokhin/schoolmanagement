using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Models;
using sms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text;

namespace sms.Pages.TimeTable
{
    //Chromosome represents array of genes as complete timetable (looks like gene[0]gene[1]gene[2]...)
    //Хромосома представляє собою масив генів як повний розклад, має вигляд gene[0]gene[1]gene[2]...
    public class Chromosome : IComparable
    {
        public double fitness;
        int antiScore;

        public Gene[] genes;

        List<int> _allGradeIds;
        double _totalNumberOfLessons;
        public List<Curriculum> _cachedCurricula;
        public List<Grade> _cachedGrades;

        public Chromosome(List<int> allGradeIds, double totalNumberOfLessons,
            List<Curriculum> cachedCurricula, List<Grade> cachedGrades, Random random)
        {
            _allGradeIds = allGradeIds;
            _totalNumberOfLessons = totalNumberOfLessons;
            _cachedCurricula = cachedCurricula;
            _cachedGrades = cachedGrades;


            genes = new Gene[Table.nostgrp];

            for (int i = 0; i < Table.nostgrp; i++)
            {
                genes[i] = new Gene(i, _cachedCurricula, _cachedGrades, random);
            }
            fitness = GetFitness();
        }
        public Chromosome(double totalNumberOfLessons)
        {
            _totalNumberOfLessons = totalNumberOfLessons;
            genes = new Gene[Table.nostgrp];
        }
        public int CompareTo(object obj)
        {
            Chromosome Temp = (Chromosome)obj;
            if (fitness < Temp.fitness)
                return 1;
            if (fitness > Temp.fitness)
                return -1;
            else
                return 0;
        }
        public double GetFitness()
        {
            antiScore = 0;
            //Find teacher clashes
            //Знаходження співпадіння вчителів
            for (int i = 0; i < Table.totalSlots; i++)
            {
                HashSet<int> teacherlist = new HashSet<int>();

                for (int j = 0; j < Table.nostgrp; j++)
                {
                    Slot slot;
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }
                        
                    if (Table.TableSlots[genes[j].slotno[i]] != null)
                        slot = Table.TableSlots[genes[j].slotno[i]];
                    else slot = null;

                    if (slot != null)
                    {
                        if (teacherlist.Contains(slot.TeacherId))
                        {
                            antiScore++;
                        }
                        else teacherlist.Add(slot.TeacherId);
                    }
                }
            }

            double result = 1 - (antiScore / _totalNumberOfLessons);
            fitness = result;
            return result;
        }
    }
}


































//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using sms.Models;
//using sms.Data;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Text.Json;
//using System.Text;

//namespace sms.Pages.TimeTable
//{
//    public class Chromosome : IComparable
//    {
//        List<int> _allGradeIds;
//        double _totalNumberOfLessons;
//        public List<Curriculum> _cachedCurricula;
//        public List<Grade> _cachedGrades;

//        public List<Gene> genes;

//        public double fitness;
//        int antiScore;

//        Random random;

//        public Chromosome(List<int> allGradeIds, double totalNumberOfLessons, 
//            List<Curriculum> cachedCurricula, List<Grade> cachedGrades)
//        {
//            random = new Random();
//            _allGradeIds = allGradeIds;
//            _totalNumberOfLessons = totalNumberOfLessons;
//            _cachedCurricula = cachedCurricula;
//            _cachedGrades = cachedGrades;

//            genes = new List<Gene>();
//            foreach (int i in _allGradeIds)
//            {
//                genes.Add(new Gene(i , _cachedCurricula, _cachedGrades));
//            }
//            fitness = GetFitness();
//            //lessons.Clear();
//        }
//        public Chromosome(double totalNumberOfLessons) 
//        {
//            genes = new List<Gene>();
//            for(int i = 0; i < 40; i++)
//            {
//                genes.Add(new Gene());
//            }
//            _totalNumberOfLessons = totalNumberOfLessons;
//        }
//        public int CompareTo(object obj)
//        {
//            Chromosome Temp = (Chromosome)obj;
//            if (fitness < Temp.fitness)
//                return 1;
//            if (fitness > Temp.fitness)
//                return -1;
//            else
//                return 0;
//        }
//        public double GetFitness()
//        {
//            //lessons = new List<Lesson>();
//            //foreach (Gene gene in genes)
//            //{
//            //    lessons.AddRange(gene.geneLessons);
//            //}

//            antiScore = 0;
//            //Find teacher clashes
//            //Знаходження співпадіння вчителів
//            HashSet<int>[] teacherIdsArrayOfHashSet = new HashSet<int>[40];
//            for (int i = 0; i < teacherIdsArrayOfHashSet.Length; i++)
//                teacherIdsArrayOfHashSet[i] = new HashSet<int>();

//            HashSet<int>[] gradeIdsArrayOfHashSet = new HashSet<int>[40];
//            for (int i = 0; i < gradeIdsArrayOfHashSet.Length; i++)
//                gradeIdsArrayOfHashSet[i] = new HashSet<int>();

//            foreach (Gene gene in genes)
//            {
//                foreach (Lesson lesson in gene.geneLessons)
//                {
//                    int slot = (lesson.Day - 1) * 8 + lesson.Slot - 1;

//                    if (teacherIdsArrayOfHashSet[slot].Contains(lesson.TeacherId))
//                        antiScore++;
//                    else teacherIdsArrayOfHashSet[slot].Add(lesson.TeacherId);

//                    if (gradeIdsArrayOfHashSet[slot].Contains(lesson.GradeId))
//                        antiScore++;
//                    else gradeIdsArrayOfHashSet[slot].Add(lesson.GradeId);
//                }
//            }

//            double result = 1 - (antiScore / _totalNumberOfLessons);
//            fitness = result;
//            return result;

//            //antiScore += lessons.GroupBy(g => new { g.Day, g.Slot, g.TeacherId })
//            //    .Where(g => g.Count() > 1)
//            //    .Select(g => g.Count() - 1).Sum(g => g);
//            ////Find grade clashes
//            ////Знаходження співпадіння класів
//            //antiScore += lessons.GroupBy(g => new { g.Day, g.Slot, g.GradeId })
//            //    .Where(g => g.Count() > 1)
//            //    .Select(g => g.Count() - 1).Sum(g => g);

//            ////Find gaps in timetable
//            ////Знаходження "вікон" у розкладі класів
//            //foreach (int grade in allGradeIds)
//            //{
//            //    for (int day = 1; day <= 5; day++)
//            //    {
//            //        for (int slot = 8; slot > 1; slot--)
//            //        {
//            //            if (lessons.Any(l => l.Day == day
//            //                    && l.Slot == slot
//            //                    && l.GradeId == grade))
//            //            {
//            //                for (int i = slot - 1; i > 0; i--)
//            //                {
//            //                    if (!lessons.Any(l => l.Day == day
//            //                                          && l.Slot == slot
//            //                                          && l.GradeId == grade))
//            //                    {
//            //                        antiScore++;
//            //                    }
//            //                }
//            //                break;
//            //            }
//            //        }
//            //    }
//            //}

//            ////Find teacher gaps
//            ////Знаходження вікон у розкладі вчителів
//            //foreach (int teacher in _context.Teachers.Select(g => g.Id))
//            //{
//            //    for (int day = 1; day <= 5; day++)
//            //    {
//            //        //Find first lesson on a given day
//            //        //Знаходження першого уроку вчителя у певний день
//            //        int firstLesson = 0;
//            //        for (int slot = 1; slot <= 8; slot++)
//            //        {
//            //            if (lessons.Any(l => l.Day == day
//            //                    && l.Slot == slot
//            //                    && l.TeacherId == teacher))
//            //            {
//            //                firstLesson = slot;
//            //                break;
//            //            }
//            //        }
//            //        //Find last lesson on a given day
//            //        //Знаходження останнього уроку вчителя у певний день
//            //        int lastLesson = 0;
//            //        for (int slot = 8; slot > 1; slot--)
//            //        {
//            //            if (lessons.Any(l => l.Day == day
//            //                    && l.Slot == slot
//            //                    && l.TeacherId == teacher))
//            //            {
//            //                lastLesson = slot;
//            //                break;
//            //            }
//            //        }
//            //        for (int slot = firstLesson + 1; slot < lastLesson; slot++)
//            //        {
//            //            if (!lessons.Any(l => l.Day == day
//            //                                  && l.Slot == slot
//            //                                  && l.TeacherId == teacher))
//            //            {
//            //                antiScore++;
//            //            }
//            //        }
//            //    }
//            //}


//            //_logger.LogInformation($"Fitness: {result,7:N5}");
//            //return random.NextDouble();
//        }
//    }
//}



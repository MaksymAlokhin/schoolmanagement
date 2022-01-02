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
        public double teachersGapScore;

        public Gene[] genes;

        int _numberOfGrades;
        double _totalNumberOfLessons;
        public List<Curriculum> _cachedCurricula;
        public List<Grade> _cachedGrades;
        Random random;

        public Chromosome(double totalNumberOfLessons,
            List<Curriculum> cachedCurricula, List<Grade> cachedGrades, Random random, int numberOfGrades)
        {
            _totalNumberOfLessons = totalNumberOfLessons;
            _cachedCurricula = cachedCurricula;
            _cachedGrades = cachedGrades;
            this.random = random;
            _numberOfGrades = numberOfGrades;

            genes = new Gene[_numberOfGrades];

            for (int i = 0; i < _numberOfGrades; i++)
            {
                genes[i] = new Gene(i, _cachedCurricula, _cachedGrades, random);
            }
            GetFitness();
        }
        public Chromosome(double totalNumberOfLessons, Random random, int numberOfGrades)
        {
            _numberOfGrades = numberOfGrades;
            _totalNumberOfLessons = totalNumberOfLessons;
            genes = new Gene[_numberOfGrades];
            this.random = random;
        }
        public int CompareTo(object obj)
        {
            //Chromosome Temp = (Chromosome)obj;

            //if (fitness < Temp.fitness)
            //    return 1;
            //if (fitness > Temp.fitness)
            //    return -1;
            //else
            //{

            //    if (teachersGapScore < Temp.teachersGapScore)
            //        return 1;
            //    if (teachersGapScore > Temp.teachersGapScore)
            //        return -1;
            //    else
            //        return 0;
            //}


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
            int antiScore = 0;
            #region Calculate fitness
            //Find teacher clashes
            //Знаходження співпадіння вчителів
            for (int i = 0; i < Table.maxLessonsPerWeek; i++)
            {
                HashSet<int> teacherlist = new HashSet<int>();

                for (int j = 0; j < _numberOfGrades; j++)
                {
                    Slot slot;
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }

                    slot = Table.TableSlots[genes[j].slotno[i]];

                    if (teacherlist.Contains(slot.TeacherId))
                    {
                        antiScore++;
                    }
                    else teacherlist.Add(slot.TeacherId);
                }
            }


            #region Find teacher gaps
            //Build teacher timetable
            //Побудова розкладу вчителів
            Dictionary<int, bool[]> teachersTimetable = new Dictionary<int, bool[]>();//teacher, slot used or not
            for (int i = 0; i < Table.maxLessonsPerWeek; i++) // maxLessonsPerWeek = 40
            {
                for (int j = 0; j < _numberOfGrades; j++)
                {
                    Slot slot;
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }

                    slot = Table.TableSlots[genes[j].slotno[i]];

                    if (teachersTimetable.ContainsKey(slot.TeacherId))
                    {
                        teachersTimetable[slot.TeacherId][i] = true;
                    }
                    else
                    {
                        teachersTimetable.Add(slot.TeacherId, new bool[40]);
                        teachersTimetable[slot.TeacherId][i] = true;
                    }

                }
            }
            //Find teacher gaps
            //Знаходження вікон у розкладі вчителів
            int gaps = 0;
            foreach (KeyValuePair<int, bool[]> teacher in teachersTimetable)
            {
                for (int day = 0; day < Table.daysPerWeek; day++)
                {
                    int emptyCounter = 0;
                    bool hasPrevLesson = false;
                    for (int slot = 0; slot < Table.lessonsPerDay; slot++)
                    {
                        int index = day + slot * Table.daysPerWeek;
                        if (teacher.Value[index])
                        {
                            if (hasPrevLesson)
                            {
                                gaps += emptyCounter;
                                emptyCounter = 0;
                            }
                            else
                            {
                                hasPrevLesson = true;
                                emptyCounter = 0;
                            }
                        }
                        else
                        {
                            emptyCounter++;
                        }
                    }
                }
            }
            teachersGapScore = 1 - (gaps / _totalNumberOfLessons);
            #endregion

            double result = 1 - (antiScore / _totalNumberOfLessons);
            fitness = result;
            return result;
            #endregion
        }
        public void FindConflicts()
        {
            //Find conflicts
            //Знаходження конфліктів вчителів
            #region Find conflicts
            Dictionary<int, List<int>> conflictSpots = new Dictionary<int, List<int>>(); //grade, spots
            for (int i = 0; i < Table.maxLessonsPerWeek; i++) // maxLessonsPerWeek = 40
            {
                HashSet<int> teacherlist = new HashSet<int>();

                for (int j = 0; j < _numberOfGrades; j++)
                {
                    Slot slot;
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }

                    slot = Table.TableSlots[genes[j].slotno[i]];

                    if (teacherlist.Contains(slot.TeacherId))
                    {
                        if (conflictSpots.ContainsKey(j))
                        {
                            conflictSpots[j].Add(i);
                        }
                        else
                        {
                            conflictSpots.Add(j, new List<int> { i });
                        }
                    }
                    else teacherlist.Add(slot.TeacherId);
                }
            }
            if (random.NextDouble() < 0.8)
                SwapConflictWithRandomSlot(conflictSpots);
            else
                SwapConflictWithAnotherConflict(conflictSpots);
            #endregion
        }
        //SwapConflictWithRandomSlot
        //Обмін місцями конфліктів з випадковими слотами
        public void SwapConflictWithRandomSlot(Dictionary<int, List<int>> conflictSpots)
        {
            foreach (KeyValuePair<int, List<int>> pair in conflictSpots)
            {
                int rnd = 0;
                foreach (int value in pair.Value)
                {
                    rnd = random.Next(genes[pair.Key].slotno.Length);
                    int temp = genes[pair.Key].slotno[value];
                    genes[pair.Key].slotno[value] = genes[pair.Key].slotno[rnd];
                    genes[pair.Key].slotno[rnd] = temp;
                }
            }
        }
        //SwapConflictWithAnotherConflict
        //Обмін місцями конфліктів зі слотами, що містять інші конфлікти
        public void SwapConflictWithAnotherConflict(Dictionary<int, List<int>> conflictSpots)
        {
            foreach (KeyValuePair<int, List<int>> pair in conflictSpots)
            {
                int[] conflictValues = new int[pair.Value.Count()];
                int k = 0;
                foreach (int value in pair.Value)
                {
                    conflictValues[k++] = genes[pair.Key].slotno[value];
                }
                k = 0;
                random.Shuffle(conflictValues);
                foreach (int value in pair.Value)
                {
                    genes[pair.Key].slotno[value] = conflictValues[k++];
                }
            }
        }
    }
}

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
        //public double softFitness;
        public double gapScore;
        public int gaps;

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
            //GetFitness();
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
            Chromosome Temp = (Chromosome)obj;

            if (fitness < Temp.fitness)
                return 1;
            if (fitness > Temp.fitness)
                return -1;
            else
            {
                if (gaps > Temp.gaps)
                    return 1;
                if (gaps < Temp.gaps)
                    return -1;
                else
                    return 0;
            }


            //Chromosome Temp = (Chromosome)obj;

            //if (softFitness < Temp.softFitness)
            //    return 1;
            //if (softFitness > Temp.softFitness)
            //    return -1;
            //else
            //    return 0;



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


            //Chromosome Temp = (Chromosome)obj;

            //if (fitness < Temp.fitness)
            //    return 1;
            //if (fitness > Temp.fitness)
            //    return -1;
            //else
            //    return 0;
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
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }
                    //if (genes[j].slotno[i] != -1)
                    //{
                        Slot slot;

                        slot = Table.TableSlots[genes[j].slotno[i]];

                        if (teacherlist.Contains(slot.TeacherId))
                        {
                            antiScore++;
                        }
                        else teacherlist.Add(slot.TeacherId);
                    //}
                }
            }
            FindTeachersGaps();

            double result = 1 - (antiScore / _totalNumberOfLessons);
            //double softResult = 1 - ((antiScore + gaps) / (_totalNumberOfLessons * 2));
            fitness = result;
            //softFitness = softResult;
            return result;
            #endregion
        }
        public void RemoveTeachersConflicts()
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
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }
                    //if (genes[j].slotno[i] != -1)
                    //{
                        Slot slot;
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
                    //}
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
        public void FindTeachersGaps()
        {
            #region Find teacher gaps
            //Build teacher timetable
            //Побудова розкладу вчителів
            Dictionary<int, bool[]> teachersTimetable = new Dictionary<int, bool[]>();//teacher, slot used or not
            for (int i = 0; i < Table.maxLessonsPerWeek; i++) // maxLessonsPerWeek = 40
            {
                for (int j = 0; j < _numberOfGrades; j++)
                {
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }
                    //if (genes[j].slotno[i] != -1)
                    //{
                        Slot slot;
                        slot = Table.TableSlots[genes[j].slotno[i]];

                        if (teachersTimetable.ContainsKey(slot.TeacherId))
                        {
                            teachersTimetable[slot.TeacherId][i] = true;
                        }
                        else
                        {
                            teachersTimetable.Add(slot.TeacherId, new bool[Table.maxLessonsPerWeek]);
                            teachersTimetable[slot.TeacherId][i] = true;
                        }
                    //}
                }
            }
            //Find teacher gaps
            //Знаходження вікон у розкладі вчителів
            gaps = 0;
            foreach (KeyValuePair<int, bool[]> teacher in teachersTimetable)
            {
                for (int day = 0; day < Table.daysPerWeek; day++)
                {
                    int emptyCounter = 0;
                    bool hasPrevLesson = false;
                    for (int slot = 0; slot < Table.lessonsPerDay; slot++)
                    {
                        int index = day + (slot * Table.daysPerWeek);
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
            gapScore = 1 - (gaps / _totalNumberOfLessons);
            #endregion
        }
        public void RemoveTeachersGaps()
        {
            //Build teacher timetable
            //Побудова розкладу вчителів
            Dictionary<int, int[]> teachersTimetable = new Dictionary<int, int[]>();//teacherid, grade[]

            for (int i = 0; i < Table.maxLessonsPerWeek; i++) // maxLessonsPerWeek = 40
            {
                for (int j = 0; j < _numberOfGrades; j++)
                {
                    if (genes[j].slotno.Length <= i)
                    {
                        continue;
                    }
                    //if (genes[j].slotno[i] != -1)
                    //{
                        Slot slot;
                        slot = Table.TableSlots[genes[j].slotno[i]];
                        if (teachersTimetable.ContainsKey(slot.TeacherId))
                        {
                            teachersTimetable[slot.TeacherId][i] = j;
                        }
                        else
                        {
                            teachersTimetable.Add(slot.TeacherId, new int[Table.maxLessonsPerWeek]);
                            for (int k = 0; k < Table.maxLessonsPerWeek; k++)
                            {
                                teachersTimetable[slot.TeacherId][k] = -1;
                            }
                            teachersTimetable[slot.TeacherId][i] = j;
                        }
                    //}
                }
            }

            //Remove teacher gaps
            //Знищення вікон у розкладі вчителів
            #region random order
            int[] teacherKeys = teachersTimetable.Keys.ToArray();
            random.Shuffle(teacherKeys);
            foreach (int key in teacherKeys)
            {
                var teacher = teachersTimetable[key];
                for (int day = 0; day < Table.daysPerWeek; day++)
                {
                    int emptyCounter = 0;
                    bool hasPrevLesson = false;
                    for (int slot = 0; slot < Table.lessonsPerDay; slot++)
                    {
                        int index = day + (slot * Table.daysPerWeek);
                        if (teacher[index] != -1)
                        {
                            if (hasPrevLesson)
                            {
                                if (emptyCounter > 0)
                                {
                                    //Move lesson to the gap by swapping it
                                    //Переміщення уроку у "вікно" раніше змінюючи місцями з іншим уроком цього класу
                                    int temp = genes[teacher[index]].slotno[index - (emptyCounter * Table.daysPerWeek)];
                                    genes[teacher[index]].slotno[index - (emptyCounter * Table.daysPerWeek)] =
                                        genes[teacher[index]].slotno[index];
                                    genes[teacher[index]].slotno[index] = temp;
                                    teacher[index] = -1;
                                }
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
            #endregion
            #region straight order
            //foreach (KeyValuePair<int, int[]> teacher in teachersTimetable)
            //{
            //    for (int day = 0; day < Table.daysPerWeek; day++)
            //    {
            //        int emptyCounter = 0;
            //        bool hasPrevLesson = false;
            //        for (int slot = 0; slot < Table.lessonsPerDay; slot++)
            //        {
            //            int index = day + (slot * Table.daysPerWeek);
            //            if (teacher.Value[index] != -1)
            //            {
            //                if (hasPrevLesson)
            //                {
            //                    if (emptyCounter > 0)
            //                    {
            //                        //Move lesson to the gap by swapping it
            //                        //Переміщення уроку у "вікно" раніше змінюючи місцями з іншим уроком цього класу
            //                        int temp = genes[teacher.Value[index]].slotno[index - (emptyCounter * Table.daysPerWeek)];
            //                        genes[teacher.Value[index]].slotno[index - (emptyCounter * Table.daysPerWeek)] =
            //                            genes[teacher.Value[index]].slotno[index];
            //                        genes[teacher.Value[index]].slotno[index] = temp;
            //                        teacher.Value[index] = -1;
            //                    }
            //                }
            //                else
            //                {
            //                    hasPrevLesson = true;
            //                    emptyCounter = 0;
            //                }
            //            }
            //            else
            //            {
            //                emptyCounter++;
            //            }
            //        }
            //    }
            //}
            #endregion
        }
        //Remove gaps present in student's timetable
        //Знищення "вікон" у розкладі учнів
        public void RemoveStudentsGaps()
        {
            for (int j = 0; j < _numberOfGrades; j++)
            {
                //counter from end to take lessons and put in gaps
                int k = genes[j].slotno.Length - 1;
                for (int i = 0; i < Table.maxLessonsPerWeek; i++)
                {
                    if (genes[j].slotno.Length <= i)
                    {
                        break;
                    }
                    if (genes[j].slotno[i] == -1)
                    {
                        while (k >= Table.maxLessonsEachGradeHas[j])
                        {
                            if (genes[j].slotno[k] != -1)
                            {
                                genes[j].slotno[i] = genes[j].slotno[k];
                                genes[j].slotno[k] = -1;
                                k--;
                                break;
                            }
                            k--;
                        }
                    }
                }
            }
        }
        static public Chromosome CloneChromosome(Chromosome input)
        {
            Chromosome chromosome = new Chromosome(input._totalNumberOfLessons, input._cachedCurricula,
                input._cachedGrades, input.random, input._numberOfGrades);
            for (int i = 0; i < input._numberOfGrades; i++)
            {
                //for (int j = 0; j < Table.maxLessonsPerWeek; j++)
                //    chromosome.genes[i].slotno[j] = input.genes[i].slotno[j];

                for (int j = 0; j < Table.maxLessonsEachGradeHas[i]; j++)
                    chromosome.genes[i].slotno[j] = input.genes[i].slotno[j];
            }
            //chromosome.GetFitness();
            return chromosome;
        }
    }
}

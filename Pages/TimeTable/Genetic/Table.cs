using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
	//through this class slots are generated to match minimum hours criteria for each subject
	//also this class holds slots in order
	//За допомогою цього класу генеруються слоти щоб використати всі уроки з
	//навчального плану. Уроки розташовані підряд
	public class Table
    {
        public static Slot[] TableSlots;

		List<int> _allGradeIds;
		public List<Curriculum> _cachedCurricula;
        public List<Grade> _cachedGrades;
        public static List<int> totalGradeSlots;
        public static int totalSlots = 40;
        public static int nostgrp;

        public Table(List<int> allGradeIds, List<Curriculum> cachedCurricula, List<Grade> cachedGrades)
        {
			_allGradeIds = allGradeIds;
			_cachedCurricula = cachedCurricula;
            _cachedGrades = cachedGrades;
            nostgrp = _allGradeIds.Count();

            int k = 0;

			// creating as many slots as the no of blocks in overall timetable
			//Створення слотів розкладу
			TableSlots = new Slot[totalSlots * nostgrp];
            totalGradeSlots = new List<int>();
            // looping for every student group
            //Перебір усіх класів

            foreach (int i in _allGradeIds)
            {
                List<Curriculum> gradeCurricula = _cachedCurricula.Where(c => c.GradeId == i).ToList();
                Grade geneGrade = _cachedGrades.Where(g => g.Id == i).FirstOrDefault();
                // for every slot in a week for a student group make a lesson
                // Для кожного слоту на тижні для кожного класу створюємо клас
                foreach (Curriculum curriculum in gradeCurricula)
                {
                    for (int l = 0; l < curriculum.Quantity; l++)
                    {
                        TableSlots[k++] =
                            new Slot
                            {
                                GradeId = curriculum.GradeId,
                                SubjectId = curriculum.SubjectId,
                                TeacherId = curriculum.TeacherId
                            };
                    }
                }
                int gradeslots = gradeCurricula.Sum(c => c.Quantity);
                totalGradeSlots.Add(gradeslots);
                int emptySlots = totalSlots - gradeslots;
                for (int j = 0; j < emptySlots; j++)
                    TableSlots[k++] = null;
            }
        }
	}
    static class RandomExtensions
    {
        public static void Shuffle<T>(this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}

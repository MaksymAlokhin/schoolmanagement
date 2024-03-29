﻿using sms.Models;
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
        public static List<int> maxLessonsEachGradeHas;
        public static int maxLessonsPerWeek = 40;
        public static int daysPerWeek = 5;
        public static int lessonsPerDay = 8;
        public int _numberOfGrades;

        public Table(List<int> allGradeIds, List<Curriculum> cachedCurricula, 
            List<Grade> cachedGrades, int numberOfGrades)
        {
			_allGradeIds = allGradeIds;
			_cachedCurricula = cachedCurricula;
            _cachedGrades = cachedGrades;
            _numberOfGrades = numberOfGrades;

            int k = 0;

			// creating as many slots as the no of blocks in overall timetable
			//Створення слотів розкладу
			TableSlots = new Slot[maxLessonsPerWeek * _numberOfGrades]; //40 lessons * 22 grades = 880 lessons
            maxLessonsEachGradeHas = new List<int>();
            // looping for every student group
            //Перебір усіх класів

            foreach (int i in _allGradeIds)
            {
                List<Curriculum> currentGradeCurricula = _cachedCurricula.Where(c => c.GradeId == i).ToList();
                Grade geneGrade = _cachedGrades.Where(g => g.Id == i).FirstOrDefault();
                // for every slot in a week for a student group make a lesson
                // Для кожного слоту на тижні для кожного класу створюємо урок
                foreach (Curriculum curriculum in currentGradeCurricula)
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
                int maxLessonsCurrentGradeHas = currentGradeCurricula.Sum(c => c.Quantity);
                maxLessonsEachGradeHas.Add(maxLessonsCurrentGradeHas);
                int emptySlots = maxLessonsPerWeek - maxLessonsCurrentGradeHas;
                for (int j = 0; j < emptySlots; j++)
                    TableSlots[k++] = null;
            }
        }
	}

}

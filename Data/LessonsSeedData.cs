using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using static sms.Data.GradesSeedData;
using static sms.Data.SubjectsSeedData;
using static sms.Data.TeachersSeedData;

namespace sms.Data
{
    public class LessonsSeedData
    {
        public static List<Lesson> data = new List<Lesson>
        {
            #region vasylieva
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "105",
                Grade = a5,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "105",
                Grade = a1,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "105",
                Grade = a7,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "105",
                Grade = a11,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "105",
                Grade = a7,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "105",
                Grade = a9,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "105",
                Grade = a5,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "105",
                Grade = a11,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "105",
                Grade = a9,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "105",
                Grade = a11,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "105",
                Grade = a9,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "105",
                Grade = a9,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "105",
                Grade = a11,
                Subject = english,
                Teacher = vasylieva
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "105",
                Grade = a5,
                Subject = english,
                Teacher = vasylieva
            },
            #endregion
            #region kurach
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "106",
                Grade = a6,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "106",
                Grade = a8,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "106",
                Grade = b9,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "106",
                Grade = a10,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "106",
                Grade = b11,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "106",
                Grade = b11,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "106",
                Grade = b7,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "106",
                Grade = a6,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "106",
                Grade = a10,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "106",
                Grade = a8,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "106",
                Grade = a10,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "106",
                Grade = a6,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "106",
                Grade = b5,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "106",
                Grade = b11,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "106",
                Grade = b9,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "106",
                Grade = a4,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "106",
                Grade = b4,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "106",
                Grade = a6,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "106",
                Grade = b11,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "106",
                Grade = b9,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "106",
                Grade = a8,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "106",
                Grade = a10,
                Subject = french,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "106",
                Grade = b9,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "106",
                Grade = b11,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "106",
                Grade = b5,
                Subject = english,
                Teacher = kurach
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "106",
                Grade = a8,
                Subject = french,
                Teacher = kurach
            },
            #endregion
            #region martynenko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "107",
                Grade = b1,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "107",
                Grade = b6,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "107",
                Grade = b8,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "107",
                Grade = b10,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "107",
                Grade = a3,
                Subject = english,
                Teacher = martynenko
            },
                        new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "107",
                Grade = b3,
                Subject = english,
                Teacher = martynenko
            },

            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "107",
                Grade = b6,
                Subject = french,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "107",
                Grade = b8,
                Subject = french,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "107",
                Grade = b10,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "107",
                Grade = b6,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "107",
                Grade = b6,
                Subject = french,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "107",
                Grade = b8,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "107",
                Grade = b10,
                Subject = french,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "107",
                Grade = b6,
                Subject = english,
                Teacher = martynenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "107",
                Grade = b8,
                Subject = french,
                Teacher = martynenko
            },
            #endregion
            #region boyarska
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "108",
                Grade = a5,
                Subject = nature,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "108",
                Grade = a6,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "108",
                Grade = a7,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "108",
                Grade = a8,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "108",
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "108",
                Grade = a10,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "108",
                Grade = a11,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "108",
                Grade = a7,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "108",
                Grade = a6,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "108",
                Grade = a10,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "108",
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "108",
                Grade = a10,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "108",
                Grade = a6,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "108",
                Grade = a5,
                Subject = nature,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "108",
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "108",
                Grade = a6,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "108",
                Grade = a11,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "108",
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "108",
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "108",
                Grade = a7,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "108",
                Grade = a11,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "108",
                Grade = a5,
                Subject = nature,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "108",
                Grade = a8,
                Subject = biology,
                Teacher = boyarska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "108",
                Grade = a10,
                Subject = biology,
                Teacher = boyarska
            },
            #endregion
            #region dybka
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "109",
                Grade = b5,
                Subject = nature,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "109",
                Grade = b6,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "109",
                Grade = b7,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "109",
                Grade = b8,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "109",
                Grade = b10,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "109",
                Grade = b11,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "109",
                Grade = b7,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "109",
                Grade = b6,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "109",
                Grade = b9,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "109",
                Grade = b10,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "109",
                Grade = b6,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "109",
                Grade = b5,
                Subject = nature,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "109",
                Grade = b9,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "109",
                Grade = b7,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "109",
                Grade = b6,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "109",
                Grade = b9,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "109",
                Grade = b5,
                Subject = nature,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "109",
                Grade = b9,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "109",
                Grade = b7,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "109",
                Grade = b11,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "109",
                Grade = b5,
                Subject = nature,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "109",
                Grade = b8,
                Subject = biology,
                Teacher = dybka
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "109",
                Grade = b10,
                Subject = biology,
                Teacher = dybka
            },
            #endregion
            #region ponomarenko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "110",
                Grade = a11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "110",
                Grade = a5,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "110",
                Grade = a7,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "110",
                Grade = a8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "110",
                Grade = a9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "110",
                Grade = a10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "110",
                Grade = a10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "110",
                Grade = a5,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "110",
                Grade = a11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "110",
                Grade = a6,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "110",
                Grade = b8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "110",
                Grade = a10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "110",
                Grade = b11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "110",
                Grade = a9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "110",
                Grade = b6,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "110",
                Grade = a11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "110",
                Grade = b9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "110",
                Grade = b10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "110",
                Grade = a8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "110",
                Grade = a6,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "110",
                Grade = b9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "110",
                Grade = a5,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "110",
                Grade = a8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "110",
                Grade = a10,
                Subject = geography,
                Teacher = ponomarenko
            },
            #endregion
            #region synko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "111",
                Grade = b11,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "111",
                Grade = b5,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "111",
                Grade = b6,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "111",
                Grade = b7,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "111",
                Grade = b8,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "111",
                Grade = b9,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "111",
                Grade = b10,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "111",
                Grade = a11,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "111",
                Grade = a9,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "111",
                Grade = a6,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "111",
                Grade = b10,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "111",
                Grade = b5,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "111",
                Grade = a8,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "111",
                Grade = b11,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "111",
                Grade = b10,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "111",
                Grade = b5,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "111",
                Grade = b9,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "111",
                Grade = b11,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "111",
                Grade = a9,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "111",
                Grade = a10,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "111",
                Grade = b7,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "111",
                Grade = a9,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "111",
                Grade = b5,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "111",
                Grade = b8,
                Subject = wliterature,
                Teacher = synko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "111",
                Grade = b10,
                Subject = wliterature,
                Teacher = synko
            },
            #endregion
            #region kholodiuk
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "112",
                Grade = a2,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "112",
                Grade = a11,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "112",
                Grade = b2,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "112",
                Grade = a5,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "112",
                Grade = a7,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "112",
                Grade = a9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "112",
                Grade = a11,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "112",
                Grade = a7,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "112",
                Grade = a5,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "112",
                Grade = a9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "112",
                Grade = a6,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "112",
                Grade = a9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "112",
                Grade = a7,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "112",
                Grade = a11,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "112",
                Grade = a11,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "112",
                Grade = a5,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "112",
                Grade = a7,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "112",
                Grade = a9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "112",
                Grade = a7,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "112",
                Grade = a6,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "112",
                Grade = a9,
                Subject = it,
                Teacher = kholodiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "112",
                Grade = a11,
                Subject = it,
                Teacher = kholodiuk
            },
            #endregion
            #region kyrianov
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "113",
                Grade = a10,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "113",
                Grade = b5,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "113",
                Grade = a6,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "113",
                Grade = b7,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "113",
                Grade = a8,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 8,
                Room = "113",
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "113",
                Grade = b11,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "113",
                Grade = a10,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "113",
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "113",
                Grade = a4,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "113",
                Grade = b4,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "113",
                Grade = a8,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "113",
                Grade = b6,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "113",
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "113",
                Grade = b7,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "113",
                Grade = b11,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "113",
                Grade = a10,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "113",
                Grade = a6,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "113",
                Grade = b11,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "113",
                Grade = a8,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "113",
                Grade = b5,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "113",
                Grade = a10,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "113",
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "113",
                Grade = b7,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "113",
                Grade = b6,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "113",
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "113",
                Grade = b11,
                Subject = it,
                Teacher = kyrianov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "113",
                Grade = a10,
                Subject = it,
                Teacher = kyrianov
            },
            #endregion
            #region shafran
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "114",
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "114",
                Grade = b6,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "114",
                Grade = b8,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "114",
                Grade = a3,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "114",
                Grade = b3,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "114",
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "114",
                Grade = b8,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "114",
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "114",
                Grade = b6,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "114",
                Grade = b8,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "114",
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "114",
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            #endregion
            #region bulachok
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "115",
                Grade = a9,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "115",
                Grade = a10,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "115",
                Grade = a11,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "115",
                Grade = b11,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "115",
                Grade = b9,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "115",
                Grade = a5,
                Subject = history,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "115",
                Grade = b6,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "115",
                Grade = a8,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "115",
                Grade = a7,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "115",
                Grade = b8,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "115",
                Grade = a10,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "115",
                Grade = a6,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "115",
                Grade = b11,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "115",
                Grade = b7,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "115",
                Grade = b9,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "115",
                Grade = b10,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "115",
                Grade = b6,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "115",
                Grade = a7,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "115",
                Grade = b8,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "115",
                Grade = a9,
                Subject = whistory,
                Teacher = bulachok
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "115",
                Grade = a11,
                Subject = whistory,
                Teacher = bulachok
            },
            #endregion
            #region smychnikova
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "116",
                Grade = a8,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "116",
                Grade = a9,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "116",
                Grade = a11,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "116",
                Grade = a6,
                Subject = maths,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "116",
                Grade = a11,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "116",
                Grade = a5,
                Subject = maths,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "116",
                Grade = a9,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "116",
                Grade = a8,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "116",
                Grade = a11,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "116",
                Grade = a9,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "116",
                Grade = a8,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "116",
                Grade = a6,
                Subject = maths,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "116",
                Grade = a11,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "116",
                Grade = a9,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "116",
                Grade = a8,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "116",
                Grade = a6,
                Subject = maths,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "116",
                Grade = a11,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "116",
                Grade = a6,
                Subject = maths,
                Teacher = smychnikova
            },
            #endregion
            #region manko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "117",
                Grade = b8,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "117",
                Grade = b9,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "117",
                Grade = a10,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "117",
                Grade = b11,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "117",
                Grade = a5,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "117",
                Grade = b6,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "117",
                Grade = a7,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "117",
                Grade = a10,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "117",
                Grade = a7,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "117",
                Grade = b11,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "117",
                Grade = b5,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "117",
                Grade = b9,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "117",
                Grade = b8,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "117",
                Grade = a5,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "117",
                Grade = b11,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "117",
                Grade = b9,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "117",
                Grade = b8,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "117",
                Grade = a7,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "117",
                Grade = b6,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "117",
                Grade = a10,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "117",
                Grade = b11,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "117",
                Grade = a7,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "117",
                Grade = a5,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "117",
                Grade = b6,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "117",
                Grade = a10,
                Subject = geometry,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "117",
                Grade = a10,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "117",
                Grade = b11,
                Subject = algebra,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "117",
                Grade = a5,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "117",
                Grade = b6,
                Subject = maths,
                Teacher = manko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "117",
                Grade = a7,
                Subject = algebra,
                Teacher = manko
            },
            #endregion
            #region shulga
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "118",
                Grade = b10,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "118",
                Grade = b5,
                Subject = maths,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "118",
                Grade = b7,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "118",
                Grade = b10,
                Subject = geometry,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "118",
                Grade = b7,
                Subject = geometry,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "118",
                Grade = b5,
                Subject = maths,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "118",
                Grade = b7,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "118",
                Grade = b10,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "118",
                Grade = b7,
                Subject = geometry,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "118",
                Grade = b5,
                Subject = maths,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "118",
                Grade = b10,
                Subject = geometry,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "118",
                Grade = b10,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "118",
                Grade = b5,
                Subject = maths,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "118",
                Grade = b10,
                Subject = algebra,
                Teacher = shulga
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "118",
                Grade = b7,
                Subject = algebra,
                Teacher = shulga
            },
            #endregion
            #region zviahelskyi
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "205",
                Grade = b9,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "205",
                Grade = b10,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "205",
                Grade = b11,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "205",
                Grade = a10,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "205",
                Grade = a3,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "205",
                Grade = a7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "205",
                Grade = b5,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "205",
                Grade = a9,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "205",
                Grade = b8,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "205",
                Grade = b7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "205",
                Grade = b10,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "205",
                Grade = b11,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "205",
                Grade = a2,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "205",
                Grade = b2,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "205",
                Grade = b3,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "205",
                Grade = b6,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "205",
                Grade = a11,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "205",
                Grade = a7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "205",
                Grade = a9,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "205",
                Grade = a4,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "205",
                Grade = a10,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "205",
                Grade = a6,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "205",
                Grade = b8,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "205",
                Grade = b4,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "205",
                Grade = b7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "205",
                Grade = a8,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "205",
                Grade = b9,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "205",
                Grade = b11,
                Subject = music,
                Teacher = zviahelskyi
            },
            #endregion
            # region havro
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "206",
                Grade = a6,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "206",
                Grade = a8,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "206",
                Grade = a11,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "206",
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "206",
                Grade = a8,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "206",
                Grade = a5,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "206",
                Grade = a6,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "206",
                Grade = a8,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "206",
                Grade = a11,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "206",
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "206",
                Grade = a11,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "206",
                Grade = a8,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "206",
                Grade = a5,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "206",
                Grade = a11,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "206",
                Grade = a11,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "206",
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "206",
                Grade = a8,
                Subject = ukrlit,
                Teacher = havro
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "206",
                Grade = a6,
                Subject = ukrainian,
                Teacher = havro
            },
            #endregion
            #region symonenko_u
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "207",
                Grade = b6,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "207",
                Grade = b8,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "207",
                Grade = b11,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "207",
                Grade = b5,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "207",
                Grade = b8,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "207",
                Grade = b5,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "207",
                Grade = b6,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "207",
                Grade = b8,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "207",
                Grade = b11,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "207",
                Grade = b5,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "207",
                Grade = b11,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "207",
                Grade = b8,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "207",
                Grade = b5,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "207",
                Grade = b11,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "207",
                Grade = b11,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "207",
                Grade = b5,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "207",
                Grade = b8,
                Subject = ukrlit,
                Teacher = symonenko_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "207",
                Grade = b6,
                Subject = ukrainian,
                Teacher = symonenko_u
            },
            #endregion
            #region kyrylusha
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "208",
                Grade = a7,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "208",
                Grade = a9,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "208",
                Grade = a10,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "208",
                Grade = a9,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "208",
                Grade = a10,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "208",
                Grade = a7,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "208",
                Grade = a9,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "208",
                Grade = a10,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "208",
                Grade = a9,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "208",
                Grade = a10,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "208",
                Grade = a7,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "208",
                Grade = a10,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "208",
                Grade = a7,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "208",
                Grade = a9,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            #endregion
            #region verbova_u
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "209",
                Grade = b7,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "209",
                Grade = b9,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "209",
                Grade = b10,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "209",
                Grade = b9,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "209",
                Grade = b10,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "209",
                Grade = b7,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "209",
                Grade = b9,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "209",
                Grade = b10,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "209",
                Grade = b9,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "209",
                Grade = b10,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "209",
                Grade = b7,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "209",
                Grade = b10,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "209",
                Grade = b7,
                Subject = ukrlit,
                Teacher = verbova_u
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "209",
                Grade = b9,
                Subject = ukrainian,
                Teacher = verbova_u
            },
            #endregion
            #region verbova_p
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "210",
                Grade = a7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "210",
                Grade = a9,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "210",
                Grade = b10,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "210",
                Grade = b7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "210",
                Grade = b6,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "210",
                Grade = a8,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "210",
                Grade = a11,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "210",
                Grade = a7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "210",
                Grade = a7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "210",
                Grade = b9,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "210",
                Grade = b10,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "210",
                Grade = b8,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "210",
                Grade = a11,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "210",
                Grade = b5,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "210",
                Grade = a8,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "210",
                Grade = a10,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "210",
                Grade = a7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "210",
                Grade = b11,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "210",
                Grade = b8,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "210",
                Grade = a10,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "210",
                Grade = b7,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "210",
                Grade = a6,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "210",
                Grade = a11,
                Subject = physics,
                Teacher = verbova_p
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "210",
                Grade = a9,
                Subject = physics,
                Teacher = verbova_p
            },
            #endregion
            #region melnychuk
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "210",
                Grade = a8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "210",
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "210",
                Grade = a6,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "210",
                Grade = a8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "210",
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "210",
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "210",
                Grade = a7,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "210",
                Grade = a7,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "210",
                Grade = a8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 8,
                Room = "210",
                Grade = b11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "210",
                Grade = a5,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "210",
                Grade = a8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "210",
                Grade = a7,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "210",
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "210",
                Grade = a5,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "210",
                Grade = a8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "210",
                Grade = a7,
                Subject = pt,
                Teacher = melnychuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "210",
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            #endregion
            #region slavov
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "212",
                Grade = b8,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "212",
                Grade = b11,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "212",
                Grade = b6,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "212",
                Grade = b8,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "212",
                Grade = a9,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "212",
                Grade = a3,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "212",
                Grade = b3,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "212",
                Grade = b11,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "212",
                Grade = a9,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "212",
                Grade = b7,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "212",
                Grade = b5,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "212",
                Grade = b7,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "212",
                Grade = a10,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "212",
                Grade = b8,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "212",
                Grade = a10,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "212",
                Grade = b5,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "212",
                Grade = b8,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "212",
                Grade = b7,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "212",
                Grade = a9,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 8,
                Room = "212",
                Grade = b11,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "212",
                Grade = b5,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "212",
                Grade = b8,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "212",
                Grade = b7,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "212",
                Grade = a9,
                Subject = pt,
                Teacher = slavov
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "212",
                Grade = b11,
                Subject = pt,
                Teacher = slavov
            },
            #endregion
            #region tverdokhlibova
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "213",
                Grade = a4,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "213",
                Grade = b4,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "213",
                Grade = a1,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "213",
                Grade = b1,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "213",
                Grade = a5,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "213",
                Grade = a10,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "213",
                Grade = b9,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "213",
                Grade = b9,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "213",
                Grade = a2,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "213",
                Grade = b2,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "213",
                Grade = b10,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "213",
                Grade = b10,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "213",
                Grade = b9,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "213",
                Grade = a2,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "213",
                Grade = b2,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "213",
                Grade = b10,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "213",
                Grade = b9,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            #endregion
            #region shevchenko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "214",
                Grade = b7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "214",
                Grade = b9,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "214",
                Grade = b5,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "214",
                Grade = b10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "214",
                Grade = b8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "214",
                Grade = b11,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "214",
                Grade = b7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "214",
                Grade = b7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "214",
                Grade = a9,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "214",
                Grade = a10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "214",
                Grade = a8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "214",
                Grade = a5,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "214",
                Grade = b8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "214",
                Grade = b10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "214",
                Grade = b7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "214",
                Grade = a11,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "214",
                Grade = a8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "214",
                Grade = b10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "214",
                Grade = a7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 6,
                Room = "214",
                Grade = b6,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 7,
                Room = "214",
                Grade = b11,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 8,
                Room = "214",
                Grade = b9,
                Subject = chemistry,
                Teacher = shevchenko
            },
            #endregion
            #region honcharuk
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "215",
                Grade = b5,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "215",
                Grade = b7,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "215",
                Grade = a9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 7,
                Room = "215",
                Grade = a11,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "215",
                Grade = a6,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "215",
                Grade = b9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 6,
                Room = "215",
                Grade = b10,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 8,
                Room = "215",
                Grade = b9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "215",
                Grade = a8,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "215",
                Grade = a5,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "215",
                Grade = b8,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "215",
                Grade = a6,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "215",
                Grade = b9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "215",
                Grade = b11,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 6,
                Room = "215",
                Grade = a5,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "215",
                Grade = b6,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "215",
                Grade = a7,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "215",
                Grade = a10,
                Subject = crafts,
                Teacher = honcharuk
            },
            #endregion
            #region moskalenko
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "216",
                Grade = b11,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "216",
                Grade = a6,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 6,
                Room = "216",
                Grade = b9,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "216",
                Grade = b7,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "216",
                Grade = b5,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 7,
                Room = "216",
                Grade = b10,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "216",
                Grade = b6,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "216",
                Grade = a11,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 6,
                Room = "216",
                Grade = a5,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 7,
                Room = "216",
                Grade = a7,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "216",
                Grade = a8,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "216",
                Grade = b8,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 7,
                Room = "216",
                Grade = b7,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "216",
                Grade = a6,
                Subject = health,
                Teacher = moskalenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "216",
                Grade = a10,
                Subject = health,
                Teacher = moskalenko
            },
            #endregion
            #region bondarenko
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "305",
                Grade = a1,
                Subject = design,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "305",
                Grade = a1,
                Subject = individual,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "305",
                Grade = a1,
                Subject = litreading,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "305",
                Grade = a1,
                Subject = maths_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "305",
                Grade = a1,
                Subject = literacy,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "305",
                Grade = a1,
                Subject = arts_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "305",
                Grade = a1,
                Subject = health_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "305",
                Grade = a1,
                Subject = writing,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "305",
                Grade = a1,
                Subject = nature_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "305",
                Grade = a1,
                Subject = crafts_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "305",
                Grade = a1,
                Subject = ukrainian_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "305",
                Grade = a1,
                Subject = iexplore,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "305",
                Grade = a1,
                Subject = iandworld,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "305",
                Grade = a1,
                Subject = design,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "305",
                Grade = a1,
                Subject = individual,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "305",
                Grade = a1,
                Subject = litreading,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "305",
                Grade = a1,
                Subject = maths_primary,
                Teacher = bondarenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "305",
                Grade = a1,
                Subject = literacy,
                Teacher = bondarenko
            },
            #endregion
            #region vlasiuk
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "306",
                Grade = b1,
                Subject = arts_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "306",
                Grade = b1,
                Subject = health_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "306",
                Grade = b1,
                Subject = writing,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "306",
                Grade = b1,
                Subject = nature_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "306",
                Grade = b1,
                Subject = crafts_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "306",
                Grade = b1,
                Subject = ukrainian_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "306",
                Grade = b1,
                Subject = iexplore,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "306",
                Grade = b1,
                Subject = iandworld,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "306",
                Grade = b1,
                Subject = design,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "306",
                Grade = b1,
                Subject = individual,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "306",
                Grade = b1,
                Subject = litreading,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "306",
                Grade = b1,
                Subject = maths_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "306",
                Grade = b1,
                Subject = literacy,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "306",
                Grade = b1,
                Subject = arts_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "306",
                Grade = b1,
                Subject = health_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "306",
                Grade = b1,
                Subject = writing,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "306",
                Grade = b1,
                Subject = nature_primary,
                Teacher = vlasiuk
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "306",
                Grade = b1,
                Subject = crafts_primary,
                Teacher = vlasiuk
            },
            #endregion
            #region horlova
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "307",
                Grade = a2,
                Subject = ukrainian_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "307",
                Grade = a2,
                Subject = iexplore,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "307",
                Grade = a2,
                Subject = iandworld,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "307",
                Grade = a2,
                Subject = design,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "307",
                Grade = a2,
                Subject = individual,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "307",
                Grade = a2,
                Subject = litreading,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "307",
                Grade = a2,
                Subject = maths_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "307",
                Grade = a2,
                Subject = literacy,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "307",
                Grade = a2,
                Subject = arts_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "307",
                Grade = a2,
                Subject = health_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "307",
                Grade = a2,
                Subject = writing,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "307",
                Grade = a2,
                Subject = nature_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "307",
                Grade = a2,
                Subject = crafts_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "307",
                Grade = a2,
                Subject = ukrainian_primary,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "307",
                Grade = a2,
                Subject = iexplore,
                Teacher = horlova
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "307",
                Grade = a2,
                Subject = iandworld,
                Teacher = horlova
            },
            #endregion
            #region yeroshkina
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "308",
                Grade = b2,
                Subject = design,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "308",
                Grade = b2,
                Subject = individual,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "308",
                Grade = b2,
                Subject = litreading,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "308",
                Grade = b2,
                Subject = maths_primary,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "308",
                Grade = b2,
                Subject = literacy,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "308",
                Grade = b2,
                Subject = arts_primary,
                Teacher = yeroshkina
            },new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "308",
                Grade = b2,
                Subject = health_primary,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "308",
                Grade = b2,
                Subject = writing,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "308",
                Grade = b2,
                Subject = nature_primary,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "308",
                Grade = b2,
                Subject = crafts_primary,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "308",
                Grade = b2,
                Subject = ukrainian_primary,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "308",
                Grade = b2,
                Subject = iexplore,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "308",
                Grade = b2,
                Subject = iandworld,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "308",
                Grade = b2,
                Subject = design,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "308",
                Grade = b2,
                Subject = individual,
                Teacher = yeroshkina
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "308",
                Grade = b2,
                Subject = litreading,
                Teacher = yeroshkina
            },
            #endregion
            #region zadorozhnia
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "309",
                Grade = a3,
                Subject = maths_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "309",
                Grade = a3,
                Subject = literacy,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "309",
                Grade = a3,
                Subject = arts_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "309",
                Grade = a3,
                Subject = health_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "309",
                Grade = a3,
                Subject = writing,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "309",
                Grade = a3,
                Subject = nature_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "309",
                Grade = a3,
                Subject = crafts_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "309",
                Grade = a3,
                Subject = ukrainian_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "309",
                Grade = a3,
                Subject = iexplore,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "309",
                Grade = a3,
                Subject = iandworld,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "309",
                Grade = a3,
                Subject = design,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "309",
                Grade = a3,
                Subject = individual,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "309",
                Grade = a3,
                Subject = litreading,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "309",
                Grade = a3,
                Subject = maths_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "309",
                Grade = a3,
                Subject = literacy,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "309",
                Grade = a3,
                Subject = arts_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "309",
                Grade = a3,
                Subject = health_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "309",
                Grade = a3,
                Subject = writing,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "309",
                Grade = a3,
                Subject = nature_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "309",
                Grade = a3,
                Subject = crafts_primary,
                Teacher = zadorozhnia
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "309",
                Grade = a3,
                Subject = ukrainian_primary,
                Teacher = zadorozhnia
            },
            #endregion
            #region hnots
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "310",
                Grade = b3,
                Subject = iexplore,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "310",
                Grade = b3,
                Subject = iandworld,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "310",
                Grade = b3,
                Subject = design,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "310",
                Grade = b3,
                Subject = individual,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "310",
                Grade = b3,
                Subject = litreading,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "310",
                Grade = b3,
                Subject = maths_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "310",
                Grade = b3,
                Subject = literacy,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "310",
                Grade = b3,
                Subject = arts_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "310",
                Grade = b3,
                Subject = health_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "310",
                Grade = b3,
                Subject = writing,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "310",
                Grade = b3,
                Subject = nature_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "310",
                Grade = b3,
                Subject = crafts_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "310",
                Grade = b3,
                Subject = ukrainian_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "310",
                Grade = b3,
                Subject = iexplore,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "310",
                Grade = b3,
                Subject = iandworld,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "310",
                Grade = b3,
                Subject = design,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "310",
                Grade = b3,
                Subject = individual,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "310",
                Grade = b3,
                Subject = litreading,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "310",
                Grade = b3,
                Subject = maths_primary,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "310",
                Grade = b3,
                Subject = literacy,
                Teacher = hnots
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "310",
                Grade = b3,
                Subject = arts_primary,
                Teacher = hnots
            },
            #endregion
            #region lavrychenko
            new Lesson
            {
                Day = "Пн",
                Slot = 2,
                Room = "311",
                Grade = a4,
                Subject = health_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "311",
                Grade = a4,
                Subject = writing,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "311",
                Grade = a4,
                Subject = nature_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "311",
                Grade = a4,
                Subject = crafts_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "311",
                Grade = a4,
                Subject = ukrainian_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "311",
                Grade = a4,
                Subject = iexplore,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "311",
                Grade = a4,
                Subject = iandworld,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "311",
                Grade = a4,
                Subject = design,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "311",
                Grade = a4,
                Subject = individual,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 2,
                Room = "311",
                Grade = a4,
                Subject = litreading,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "311",
                Grade = a4,
                Subject = maths_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "311",
                Grade = a4,
                Subject = literacy,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "311",
                Grade = a4,
                Subject = arts_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 2,
                Room = "311",
                Grade = a4,
                Subject = health_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "311",
                Grade = a4,
                Subject = writing,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "311",
                Grade = a4,
                Subject = nature_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "311",
                Grade = a4,
                Subject = crafts_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 2,
                Room = "311",
                Grade = a4,
                Subject = ukrainian_primary,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "311",
                Grade = a4,
                Subject = iexplore,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "311",
                Grade = a4,
                Subject = iandworld,
                Teacher = lavrychenko
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "311",
                Grade = a4,
                Subject = design,
                Teacher = lavrychenko
            },
            #endregion
            #region lonska
            new Lesson
            {
                Day = "Пн",
                Slot = 1,
                Room = "312",
                Grade = b4,
                Subject = individual,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 3,
                Room = "312",
                Grade = b4,
                Subject = litreading,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 4,
                Room = "312",
                Grade = b4,
                Subject = maths_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пн",
                Slot = 5,
                Room = "312",
                Grade = b4,
                Subject = literacy,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 1,
                Room = "312",
                Grade = b4,
                Subject = arts_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 2,
                Room = "312",
                Grade = b4,
                Subject = health_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 3,
                Room = "312",
                Grade = b4,
                Subject = writing,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 4,
                Room = "312",
                Grade = b4,
                Subject = nature_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Вт",
                Slot = 5,
                Room = "312",
                Grade = b4,
                Subject = crafts_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 1,
                Room = "312",
                Grade = b4,
                Subject = ukrainian_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 3,
                Room = "312",
                Grade = b4,
                Subject = iexplore,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 4,
                Room = "312",
                Grade = b4,
                Subject = iandworld,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Ср",
                Slot = 5,
                Room = "312",
                Grade = b4,
                Subject = design,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 1,
                Room = "312",
                Grade = b4,
                Subject = individual,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 3,
                Room = "312",
                Grade = b4,
                Subject = litreading,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 4,
                Room = "312",
                Grade = b4,
                Subject = maths_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Чт",
                Slot = 5,
                Room = "312",
                Grade = b4,
                Subject = literacy,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 1,
                Room = "312",
                Grade = b4,
                Subject = arts_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 3,
                Room = "312",
                Grade = b4,
                Subject = health_primary,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 4,
                Room = "312",
                Grade = b4,
                Subject = writing,
                Teacher = lonska
            },
            new Lesson
            {
                Day = "Пт",
                Slot = 5,
                Room = "312",
                Grade = b4,
                Subject = nature_primary,
                Teacher = lonska
            },
            #endregion
        };
    }
}
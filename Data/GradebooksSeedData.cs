using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using static sms.Data.GradesSeedData;
using static sms.Data.SubjectsSeedData;
using static sms.Data.TeachersSeedData;
using static sms.Data.StudentsSeedData;

namespace sms.Data
{
    public class GradebooksSeedData
    {
        public static List<Gradebook> data = new List<Gradebook>
        {
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "4",
Student = s001,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "10",
Student = s001,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s001,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "8",
Student = s001,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "9",
Student = s001,
Subject = maths_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s001,
Subject = maths_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "8",
Student = s001,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "12",
Student = s001,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "6",
Student = s001,
Subject = finearts,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "12",
Student = s001,
Subject = finearts,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s001,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s001,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "10",
Student = s001,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "12",
Student = s001,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s001,
Subject = iexplore,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "4",
Student = s001,
Subject = iexplore,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "7",
Student = s001,
Subject = maths_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "9",
Student = s001,
Subject = maths_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s001,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "5",
Student = s099,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s010,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "5",
Student = s099,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s010,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "7",
Student = s099,
Subject = maths_primary,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "6",
Student = s008,
Subject = maths_primary,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "8",
Student = s011,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s009,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "4",
Student = s008,
Subject = finearts,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s010,
Subject = finearts,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "11",
Student = s011,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s010,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "4",
Student = s099,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "8",
Student = s009,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s099,
Subject = iexplore,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s008,
Subject = iexplore,
Teacher = vlasiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "8",
Student = s015,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s017,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s015,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "6",
Student = s018,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "7",
Student = s016,
Subject = maths_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s018,
Subject = maths_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "3",
Student = s016,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s013,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s015,
Subject = finearts,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "10",
Student = s013,
Subject = finearts,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s015,
Subject = crafts_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "8",
Student = s013,
Subject = crafts_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s016,
Subject = ukrainian_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s018,
Subject = ukrainian_primary,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s016,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s013,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s016,
Subject = reading,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s018,
Subject = reading,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "5",
Student = s016,
Subject = iexplore,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "12",
Student = s013,
Subject = iexplore,
Teacher = horlova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s020,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "5",
Student = s022,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s021,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "11",
Student = s023,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s020,
Subject = maths_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s022,
Subject = maths_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s020,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s022,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s021,
Subject = finearts,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "11",
Student = s022,
Subject = finearts,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "7",
Student = s020,
Subject = crafts_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "5",
Student = s023,
Subject = crafts_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "10",
Student = s021,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s020,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s020,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "4",
Student = s023,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s020,
Subject = reading,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "11",
Student = s022,
Subject = reading,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s021,
Subject = iexplore,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s023,
Subject = iexplore,
Teacher = yeroshkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s026,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "12",
Student = s028,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "8",
Student = s026,
Subject = design,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s028,
Subject = design,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "5",
Student = s028,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "11",
Student = s026,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s026,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s028,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s029,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "10",
Student = s026,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s026,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s029,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s026,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s027,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "11",
Student = s026,
Subject = reading,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "6",
Student = s027,
Subject = reading,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s029,
Subject = iexplore,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "12",
Student = s026,
Subject = iexplore,
Teacher = zadorozhnia
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "8",
Student = s032,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s034,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s033,
Subject = design,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "10",
Student = s035,
Subject = design,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s032,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "5",
Student = s033,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "5",
Student = s032,
Subject = maths_primary,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s035,
Subject = maths_primary,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "5",
Student = s032,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s035,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "5",
Student = s032,
Subject = ukrainian_primary,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s033,
Subject = ukrainian_primary,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s032,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s034,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "5",
Student = s032,
Subject = reading,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "9",
Student = s035,
Subject = reading,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s033,
Subject = iexplore,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "11",
Student = s035,
Subject = iexplore,
Teacher = hnots
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s038,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "5",
Student = s042,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s038,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "6",
Student = s042,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "8",
Student = s038,
Subject = litreading,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s042,
Subject = litreading,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s039,
Subject = maths_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "11",
Student = s040,
Subject = maths_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "4",
Student = s038,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s040,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "5",
Student = s038,
Subject = finearts,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "9",
Student = s040,
Subject = finearts,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s038,
Subject = health_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "10",
Student = s040,
Subject = health_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "5",
Student = s039,
Subject = nature_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s040,
Subject = nature_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s038,
Subject = crafts_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "8",
Student = s040,
Subject = crafts_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "5",
Student = s038,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s039,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s038,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "12",
Student = s042,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s047,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s043,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s047,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "7",
Student = s044,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s048,
Subject = litreading,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s044,
Subject = litreading,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s048,
Subject = maths_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "4",
Student = s044,
Subject = maths_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s048,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "12",
Student = s045,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s047,
Subject = finearts,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s044,
Subject = finearts,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "7",
Student = s048,
Subject = health_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s045,
Subject = health_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "7",
Student = s048,
Subject = nature_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s043,
Subject = nature_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s043,
Subject = crafts_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "10",
Student = s045,
Subject = crafts_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s048,
Subject = ukrainian_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "10",
Student = s044,
Subject = ukrainian_primary,
Teacher = lonska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "5",
Student = s048,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "10",
Student = s044,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s050,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s052,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s050,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "8",
Student = s053,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "5",
Student = s050,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "9",
Student = s053,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "7",
Student = s050,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "9",
Student = s053,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s051,
Subject = maths,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s050,
Subject = maths,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "5",
Student = s050,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "11",
Student = s053,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "8",
Student = s051,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "11",
Student = s053,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s050,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "9",
Student = s053,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "5",
Student = s050,
Subject = nature,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s052,
Subject = nature,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "3",
Student = s050,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s054,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s051,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s049,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s050,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "10",
Student = s053,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "5",
Student = s050,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s052,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s051,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "10",
Student = s053,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "7",
Student = s055,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s058,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s056,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "9",
Student = s059,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "5",
Student = s056,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "9",
Student = s060,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s056,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "7",
Student = s059,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s056,
Subject = maths,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s059,
Subject = maths,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "4",
Student = s058,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "9",
Student = s056,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "5",
Student = s056,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "10",
Student = s059,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s056,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "8",
Student = s058,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s057,
Subject = nature,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "11",
Student = s060,
Subject = nature,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "4",
Student = s056,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s059,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "8",
Student = s056,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s058,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s056,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s059,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "4",
Student = s056,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s058,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "5",
Student = s056,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s059,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "5",
Student = s063,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s061,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "5",
Student = s064,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "8",
Student = s062,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "8",
Student = s061,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s062,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s063,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "11",
Student = s062,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s064,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "11",
Student = s065,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "5",
Student = s064,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "11",
Student = s065,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "6",
Student = s064,
Subject = maths,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s062,
Subject = maths,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "4",
Student = s064,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "10",
Student = s065,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s064,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s062,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "6",
Student = s064,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "10",
Student = s065,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s065,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s061,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s064,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "8",
Student = s065,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "11",
Student = s064,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s062,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "10",
Student = s061,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s064,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "5",
Student = s061,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s066,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s083,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s070,
Subject = english,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "5",
Student = s083,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s070,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "3",
Student = s070,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "11",
Student = s083,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s083,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s070,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "6",
Student = s083,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "4",
Student = s071,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s083,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "9",
Student = s071,
Subject = history,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "5",
Student = s083,
Subject = maths,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "8",
Student = s071,
Subject = maths,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s069,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "5",
Student = s067,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "4",
Student = s083,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s071,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "5",
Student = s083,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "11",
Student = s070,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "5",
Student = s083,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "11",
Student = s070,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s069,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "10",
Student = s070,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s070,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "6",
Student = s083,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s083,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s070,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "6",
Student = s083,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "10",
Student = s070,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "4",
Student = s078,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s076,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s073,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "6",
Student = s075,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "6",
Student = s075,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s073,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "4",
Student = s078,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s075,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "9",
Student = s074,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "4",
Student = s073,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "5",
Student = s073,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s076,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s073,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s074,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "6",
Student = s073,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "11",
Student = s075,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s074,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s077,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "10",
Student = s073,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "6",
Student = s074,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s073,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "9",
Student = s076,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "7",
Student = s074,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "5",
Student = s073,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s076,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s073,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s078,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "5",
Student = s076,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "6",
Student = s074,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "11",
Student = s073,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s073,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "10",
Student = s076,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s073,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "11",
Student = s076,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s073,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "7",
Student = s075,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s073,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "8",
Student = s074,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s079,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s068,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "7",
Student = s080,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "11",
Student = s081,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s080,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "7",
Student = s081,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s080,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s068,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s080,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "10",
Student = s081,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s080,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "9",
Student = s082,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s080,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "9",
Student = s082,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "9",
Student = s081,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s082,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "9",
Student = s081,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 29),
Mark = "4",
Student = s079,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "6",
Student = s084,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s080,
Subject = music,
Teacher = zviahelskyi
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "9",
Student = s080,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "8",
Student = s082,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "4",
Student = s080,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "11",
Student = s084,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s080,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "6",
Student = s082,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "7",
Student = s080,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "11",
Student = s082,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s080,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "8",
Student = s082,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s080,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s081,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "9",
Student = s080,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "5",
Student = s082,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "10",
Student = s080,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "9",
Student = s081,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "12",
Student = s081,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s080,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s085,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s087,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s086,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "4",
Student = s088,
Subject = english,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "8",
Student = s087,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "4",
Student = s088,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "8",
Student = s086,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "9",
Student = s088,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "8",
Student = s086,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "5",
Student = s089,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s086,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s087,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "5",
Student = s086,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "11",
Student = s089,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s086,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s088,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "6",
Student = s087,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "10",
Student = s089,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "7",
Student = s085,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "10",
Student = s088,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "6",
Student = s086,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "10",
Student = s088,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s086,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "5",
Student = s088,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s086,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "4",
Student = s088,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s087,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "10",
Student = s089,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "8",
Student = s087,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "5",
Student = s086,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s086,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s089,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "7",
Student = s087,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "12",
Student = s086,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s086,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "11",
Student = s089,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "7",
Student = s091,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "8",
Student = s095,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s092,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s093,
Subject = english,
Teacher = vasylieva
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "4",
Student = s092,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s095,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "3",
Student = s092,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "12",
Student = s095,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "4",
Student = s092,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "10",
Student = s095,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s092,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "4",
Student = s094,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s093,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s094,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s092,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "4",
Student = s093,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "8",
Student = s093,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "4",
Student = s092,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s092,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s095,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "12",
Student = s092,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s095,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s092,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "9",
Student = s094,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s091,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "11",
Student = s093,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "8",
Student = s092,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "4",
Student = s094,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s093,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s092,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s092,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "6",
Student = s095,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "10",
Student = s092,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s093,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "9",
Student = s092,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "4",
Student = s095,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s097,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "9",
Student = s007,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "7",
Student = s098,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s007,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "5",
Student = s100,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "11",
Student = s098,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s098,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "10",
Student = s100,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "7",
Student = s097,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "5",
Student = s101,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "7",
Student = s098,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s100,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "3",
Student = s098,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s102,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "4",
Student = s097,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "10",
Student = s100,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s098,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s007,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s098,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "5",
Student = s100,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "7",
Student = s098,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s101,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "5",
Student = s098,
Subject = jurisprudence,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "10",
Student = s100,
Subject = jurisprudence,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "4",
Student = s100,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "11",
Student = s098,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "10",
Student = s007,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s098,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "9",
Student = s098,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "5",
Student = s101,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "12",
Student = s098,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s101,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "11",
Student = s007,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "5",
Student = s102,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "8",
Student = s100,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s098,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "12",
Student = s098,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "6",
Student = s007,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "9",
Student = s104,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "9",
Student = s107,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s107,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s104,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s104,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "8",
Student = s106,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "11",
Student = s107,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s104,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s104,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "6",
Student = s105,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "9",
Student = s104,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "4",
Student = s106,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "4",
Student = s104,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s105,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s104,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "6",
Student = s105,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s104,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "6",
Student = s105,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s104,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "11",
Student = s106,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s104,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "11",
Student = s106,
Subject = health,
Teacher = moskalenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s104,
Subject = jurisprudence,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "6",
Student = s107,
Subject = jurisprudence,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "8",
Student = s106,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s104,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s104,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s105,
Subject = crafts,
Teacher = honcharuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "10",
Student = s104,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "8",
Student = s107,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s107,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "12",
Student = s104,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "10",
Student = s104,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s106,
Subject = pt,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s107,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "11",
Student = s104,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "9",
Student = s104,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "4",
Student = s105,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s112,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "10",
Student = s109,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s111,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s114,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s112,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "11",
Student = s109,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s112,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s114,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "6",
Student = s112,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s109,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s111,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "11",
Student = s114,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s112,
Subject = civileduc,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "11",
Student = s114,
Subject = civileduc,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "6",
Student = s112,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "7",
Student = s109,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "10",
Student = s113,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s112,
Subject = it,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "8",
Student = s114,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s110,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s112,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s109,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "10",
Student = s113,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "5",
Student = s109,
Subject = ukrlit,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "10",
Student = s113,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s114,
Subject = ukrainian,
Teacher = kyrylusha
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "10",
Student = s111,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s114,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "10",
Student = s112,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "5",
Student = s109,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "10",
Student = s112,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s113,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "11",
Student = s112,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "12",
Student = s113,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 27),
Mark = "9",
Student = s116,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "10",
Student = s117,
Subject = algebra,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "8",
Student = s118,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "3",
Student = s115,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "10",
Student = s116,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "11",
Student = s117,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s116,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "5",
Student = s118,
Subject = whistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "9",
Student = s116,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "4",
Student = s119,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "9",
Student = s115,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s117,
Subject = geometry,
Teacher = shulga
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s117,
Subject = civileduc,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "6",
Student = s116,
Subject = civileduc,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "8",
Student = s116,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "9",
Student = s118,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s115,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "11",
Student = s118,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s115,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "11",
Student = s118,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "5",
Student = s116,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "11",
Student = s119,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "8",
Student = s116,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s118,
Subject = ukrlit,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s116,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "12",
Student = s119,
Subject = ukrainian,
Teacher = verbova_nv
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s116,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "11",
Student = s118,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s116,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "9",
Student = s119,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "10",
Student = s116,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "6",
Student = s118,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s117,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s119,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "8",
Student = s121,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "10",
Student = s123,
Subject = algebra,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s121,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s124,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "11",
Student = s121,
Subject = astronomy,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "7",
Student = s122,
Subject = astronomy,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "8",
Student = s122,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "4",
Student = s121,
Subject = biology,
Teacher = boyarska
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "8",
Student = s126,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "10",
Student = s123,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "10",
Student = s121,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "8",
Student = s122,
Subject = geometry,
Teacher = smychnikova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "8",
Student = s121,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "6",
Student = s124,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "9",
Student = s121,
Subject = civildef,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "5",
Student = s123,
Subject = civildef,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s121,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s123,
Subject = it,
Teacher = kyrianov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "7",
Student = s121,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "7",
Student = s123,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "9",
Student = s122,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "9",
Student = s123,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s126,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "4",
Student = s122,
Subject = ukrlit,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 29),
Mark = "9",
Student = s123,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "7",
Student = s121,
Subject = ukrainian,
Teacher = havro
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "9",
Student = s122,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "6",
Student = s121,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "8",
Student = s121,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "6",
Student = s124,
Subject = pt,
Teacher = melnychuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "8",
Student = s121,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "12",
Student = s124,
Subject = french,
Teacher = kurach
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "9",
Student = s121,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "8",
Student = s123,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "8",
Student = s128,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "11",
Student = s129,
Subject = algebra,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s129,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "11",
Student = s131,
Subject = english,
Teacher = lisichkina
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 28),
Mark = "7",
Student = s128,
Subject = astronomy,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "6",
Student = s130,
Subject = astronomy,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "12",
Student = s129,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 17),
Mark = "4",
Student = s128,
Subject = biology,
Teacher = dybka
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "8",
Student = s128,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 22),
Mark = "6",
Student = s131,
Subject = geography,
Teacher = ponomarenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "7",
Student = s128,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s132,
Subject = geometry,
Teacher = manko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "7",
Student = s127,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 16),
Mark = "6",
Student = s129,
Subject = wliterature,
Teacher = synko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 20),
Mark = "6",
Student = s127,
Subject = civildef,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "9",
Student = s131,
Subject = civildef,
Teacher = tverdokhlibova
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 23),
Mark = "11",
Student = s129,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "5",
Student = s127,
Subject = it,
Teacher = shafran
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 24),
Mark = "7",
Student = s127,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "10",
Student = s130,
Subject = uhistory,
Teacher = bulachok
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s127,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 15),
Mark = "10",
Student = s129,
Subject = arts,
Teacher = kholodiuk
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 1),
Mark = "8",
Student = s129,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 9),
Mark = "11",
Student = s131,
Subject = ukrlit,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 6),
Mark = "10",
Student = s128,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 13),
Mark = "6",
Student = s130,
Subject = ukrainian,
Teacher = symonenko_op
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 10),
Mark = "8",
Student = s129,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 3),
Mark = "8",
Student = s128,
Subject = physics,
Teacher = verbova_vo
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 8),
Mark = "6",
Student = s129,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 2),
Mark = "10",
Student = s131,
Subject = pt,
Teacher = slavov
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 21),
Mark = "12",
Student = s128,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "7",
Student = s127,
Subject = french,
Teacher = martynenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 14),
Mark = "9",
Student = s128,
Subject = chemistry,
Teacher = shevchenko
},
new Gradebook
{
LessonDate = new DateTime(2021, 9, 7),
Mark = "3",
Student = s129,
Subject = chemistry,
Teacher = shevchenko
}
        };
    }
}

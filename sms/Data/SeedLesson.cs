using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using static sms.Data.SeedGrade;
using static sms.Data.SeedSubject;
using static sms.Data.SeedTeacher;

namespace sms.Data
{
    public class SeedLesson
    {
        public static List<Lesson> data = new List<Lesson>
        {
new Lesson {
Day = 1,
Slot = 1,
Room = "209",
Grade = a7,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 4,
Room = "111",
Grade = a4,
Subject = maths_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "111",
Grade = a4,
Subject = maths_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "111",
Grade = a4,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 5,
Slot = 4,
Room = "111",
Grade = a4,
Subject = nature_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 1,
Slot = 5,
Room = "111",
Grade = a4,
Subject = finearts,
Teacher = lavrychenko
},
new Lesson {
Day = 1,
Slot = 1,
Room = "112",
Grade = b4,
Subject = ukrainian_primary,
Teacher = lonska
},
new Lesson {
Day = 5,
Slot = 3,
Room = "111",
Grade = a4,
Subject = maths_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "112",
Grade = b4,
Subject = finearts,
Teacher = lonska
},
new Lesson {
Day = 3,
Slot = 2,
Room = "112",
Grade = b4,
Subject = health_primary,
Teacher = lonska
},
new Lesson {
Day = 4,
Slot = 2,
Room = "112",
Grade = b4,
Subject = nature_primary,
Teacher = lonska
},
new Lesson {
Day = 5,
Slot = 2,
Room = "112",
Grade = b4,
Subject = maths_primary,
Teacher = lonska
},
new Lesson {
Day = 1,
Slot = 3,
Room = "112",
Grade = b4,
Subject = nature_primary,
Teacher = lonska
},
new Lesson {
Day = 2,
Slot = 3,
Room = "112",
Grade = b4,
Subject = crafts_primary,
Teacher = lonska
},
new Lesson {
Day = 3,
Slot = 3,
Room = "112",
Grade = b4,
Subject = maths_primary,
Teacher = lonska
},
new Lesson {
Day = 2,
Slot = 2,
Room = "112",
Grade = b4,
Subject = litreading,
Teacher = lonska
},
new Lesson {
Day = 2,
Slot = 3,
Room = "111",
Grade = a4,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 1,
Slot = 3,
Room = "111",
Grade = a4,
Subject = crafts_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "111",
Grade = a4,
Subject = nature_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "207",
Grade = a6,
Subject = maths,
Teacher = shulga
},
new Lesson {
Day = 3,
Slot = 4,
Room = "210",
Grade = b7,
Subject = geometry,
Teacher = shulga
},
new Lesson {
Day = 2,
Slot = 5,
Room = "305",
Grade = a9,
Subject = geometry,
Teacher = shulga
},
new Lesson {
Day = 3,
Slot = 5,
Room = "305",
Grade = a9,
Subject = geometry,
Teacher = shulga
},
new Lesson {
Day = 4,
Slot = 5,
Room = "210",
Grade = b7,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 5,
Slot = 5,
Room = "305",
Grade = a9,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 1,
Slot = 6,
Room = "210",
Grade = b7,
Subject = geometry,
Teacher = shulga
},
new Lesson {
Day = 2,
Slot = 6,
Room = "210",
Grade = b7,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 1,
Slot = 1,
Room = "111",
Grade = a4,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 2,
Slot = 1,
Room = "111",
Grade = a4,
Subject = litreading,
Teacher = lavrychenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "111",
Grade = a4,
Subject = health_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "111",
Grade = a4,
Subject = litreading,
Teacher = lavrychenko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "111",
Grade = a4,
Subject = litreading,
Teacher = lavrychenko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "111",
Grade = a4,
Subject = maths_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 4,
Slot = 2,
Room = "111",
Grade = a4,
Subject = ukrainian_primary,
Teacher = lavrychenko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "112",
Grade = b4,
Subject = ukrainian_primary,
Teacher = lonska
},
new Lesson {
Day = 5,
Slot = 3,
Room = "112",
Grade = b4,
Subject = maths_primary,
Teacher = lonska
},
new Lesson {
Day = 1,
Slot = 4,
Room = "112",
Grade = b4,
Subject = ukrainian_primary,
Teacher = lonska
},
new Lesson {
Day = 2,
Slot = 4,
Room = "112",
Grade = b4,
Subject = maths_primary,
Teacher = lonska
},
new Lesson {
Day = 1,
Slot = 1,
Room = "108",
Grade = b2,
Subject = iexplore,
Teacher = yeroshkina
},
new Lesson {
Day = 2,
Slot = 1,
Room = "108",
Grade = b2,
Subject = finearts,
Teacher = yeroshkina
},
new Lesson {
Day = 4,
Slot = 1,
Room = "108",
Grade = b2,
Subject = reading,
Teacher = yeroshkina
},
new Lesson {
Day = 5,
Slot = 1,
Room = "108",
Grade = b2,
Subject = iexplore,
Teacher = yeroshkina
},
new Lesson {
Day = 1,
Slot = 2,
Room = "108",
Grade = b2,
Subject = iexplore,
Teacher = yeroshkina
},
new Lesson {
Day = 3,
Slot = 2,
Room = "108",
Grade = b2,
Subject = reading,
Teacher = yeroshkina
},
new Lesson {
Day = 4,
Slot = 2,
Room = "108",
Grade = b2,
Subject = crafts_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 2,
Slot = 3,
Room = "108",
Grade = b2,
Subject = maths_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 3,
Slot = 3,
Room = "108",
Grade = b2,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 4,
Slot = 3,
Room = "108",
Grade = b2,
Subject = reading,
Teacher = yeroshkina
},
new Lesson {
Day = 1,
Slot = 4,
Room = "108",
Grade = b2,
Subject = maths_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 2,
Slot = 4,
Room = "108",
Grade = b2,
Subject = maths_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 4,
Slot = 4,
Room = "108",
Grade = b2,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 5,
Slot = 4,
Room = "108",
Grade = b2,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 1,
Slot = 5,
Room = "108",
Grade = b2,
Subject = ukrainian_primary,
Teacher = yeroshkina
},
new Lesson {
Day = 2,
Slot = 5,
Room = "107",
Grade = a2,
Subject = iexplore,
Teacher = horlova
},
new Lesson {
Day = 1,
Slot = 4,
Room = "305",
Grade = a9,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 1,
Slot = 5,
Room = "107",
Grade = a2,
Subject = reading,
Teacher = horlova
},
new Lesson {
Day = 4,
Slot = 4,
Room = "107",
Grade = a2,
Subject = iexplore,
Teacher = horlova
},
new Lesson {
Day = 3,
Slot = 4,
Room = "112",
Grade = b4,
Subject = ukrainian_primary,
Teacher = lonska
},
new Lesson {
Day = 4,
Slot = 4,
Room = "112",
Grade = b4,
Subject = litreading,
Teacher = lonska
},
new Lesson {
Day = 5,
Slot = 4,
Room = "112",
Grade = b4,
Subject = litreading,
Teacher = lonska
},
new Lesson {
Day = 2,
Slot = 1,
Room = "107",
Grade = a2,
Subject = crafts_primary,
Teacher = horlova
},
new Lesson {
Day = 3,
Slot = 1,
Room = "107",
Grade = a2,
Subject = reading,
Teacher = horlova
},
new Lesson {
Day = 4,
Slot = 5,
Room = "107",
Grade = a2,
Subject = finearts,
Teacher = horlova
},
new Lesson {
Day = 1,
Slot = 2,
Room = "107",
Grade = a2,
Subject = maths_primary,
Teacher = horlova
},
new Lesson {
Day = 3,
Slot = 2,
Room = "107",
Grade = a2,
Subject = maths_primary,
Teacher = horlova
},
new Lesson {
Day = 1,
Slot = 3,
Room = "107",
Grade = a2,
Subject = maths_primary,
Teacher = horlova
},
new Lesson {
Day = 2,
Slot = 3,
Room = "107",
Grade = a2,
Subject = ukrainian_primary,
Teacher = horlova
},
new Lesson {
Day = 3,
Slot = 3,
Room = "107",
Grade = a2,
Subject = iexplore,
Teacher = horlova
},
new Lesson {
Day = 5,
Slot = 3,
Room = "107",
Grade = a2,
Subject = ukrainian_primary,
Teacher = horlova
},
new Lesson {
Day = 1,
Slot = 4,
Room = "107",
Grade = a2,
Subject = ukrainian_primary,
Teacher = horlova
},
new Lesson {
Day = 2,
Slot = 4,
Room = "107",
Grade = a2,
Subject = reading,
Teacher = horlova
},
new Lesson {
Day = 3,
Slot = 4,
Room = "107",
Grade = a2,
Subject = ukrainian_primary,
Teacher = horlova
},
new Lesson {
Day = 5,
Slot = 4,
Room = "107",
Grade = a2,
Subject = reading,
Teacher = horlova
},
new Lesson {
Day = 4,
Slot = 3,
Room = "207",
Grade = a6,
Subject = maths,
Teacher = shulga
},
new Lesson {
Day = 3,
Slot = 3,
Room = "207",
Grade = a6,
Subject = maths,
Teacher = shulga
},
new Lesson {
Day = 2,
Slot = 3,
Room = "308",
Grade = b10,
Subject = geometry,
Teacher = shulga
},
new Lesson {
Day = 3,
Slot = 1,
Room = "109",
Grade = a3,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 4,
Slot = 1,
Room = "208",
Grade = b6,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 5,
Slot = 1,
Room = "106",
Grade = b1,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 1,
Slot = 2,
Room = "112",
Grade = b4,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 2,
Room = "109",
Grade = a3,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 3,
Slot = 2,
Room = "109",
Grade = a3,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 4,
Slot = 2,
Room = "305",
Grade = a9,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 5,
Slot = 2,
Room = "208",
Grade = b6,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 1,
Slot = 3,
Room = "208",
Grade = b6,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 3,
Room = "307",
Grade = a10,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 4,
Room = "211",
Grade = a8,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 3,
Slot = 4,
Room = "208",
Grade = b6,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 1,
Slot = 5,
Room = "205",
Grade = a5,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 5,
Room = "309",
Grade = a11,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 6,
Room = "209",
Grade = a7,
Subject = french,
Teacher = kurach
},
new Lesson {
Day = 2,
Slot = 1,
Room = "112",
Grade = b4,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 1,
Slot = 1,
Room = "110",
Grade = b3,
Subject = ukrainian_primary,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 1,
Room = "106",
Grade = b1,
Subject = english,
Teacher = kurach
},
new Lesson {
Day = 5,
Slot = 4,
Room = "305",
Grade = a9,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 2,
Slot = 6,
Room = "308",
Grade = b10,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "210",
Grade = b7,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "307",
Grade = a10,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "211",
Grade = a8,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "308",
Grade = b10,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "310",
Grade = b11,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 4,
Slot = 2,
Room = "309",
Grade = a11,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "306",
Grade = b9,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "209",
Grade = a7,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "211",
Grade = a8,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "305",
Grade = a9,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 1,
Slot = 4,
Room = "212",
Grade = b8,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "309",
Grade = a11,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 3,
Slot = 4,
Room = "212",
Grade = b8,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "310",
Grade = b11,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 2,
Slot = 5,
Room = "306",
Grade = b9,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 2,
Slot = 5,
Room = "108",
Grade = b2,
Subject = reading,
Teacher = yeroshkina
},
new Lesson {
Day = 2,
Slot = 1,
Room = "110",
Grade = b3,
Subject = maths_primary,
Teacher = hnots
},
new Lesson {
Day = 2,
Slot = 2,
Room = "110",
Grade = b3,
Subject = iexplore,
Teacher = hnots
},
new Lesson {
Day = 5,
Slot = 2,
Room = "109",
Grade = a3,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 1,
Slot = 3,
Room = "109",
Grade = a3,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 2,
Slot = 3,
Room = "109",
Grade = a3,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 3,
Slot = 3,
Room = "109",
Grade = a3,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 4,
Slot = 3,
Room = "109",
Grade = a3,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 1,
Slot = 4,
Room = "109",
Grade = a3,
Subject = ukrainian_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 2,
Slot = 4,
Room = "109",
Grade = a3,
Subject = reading,
Teacher = zadorozhnia
},
new Lesson {
Day = 3,
Slot = 4,
Room = "109",
Grade = a3,
Subject = reading,
Teacher = zadorozhnia
},
new Lesson {
Day = 4,
Slot = 4,
Room = "109",
Grade = a3,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 5,
Slot = 4,
Room = "109",
Grade = a3,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 1,
Slot = 5,
Room = "109",
Grade = a3,
Subject = reading,
Teacher = zadorozhnia
},
new Lesson {
Day = 1,
Slot = 1,
Room = "308",
Grade = b10,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 2,
Slot = 1,
Room = "207",
Grade = a6,
Subject = maths,
Teacher = shulga
},
new Lesson {
Day = 2,
Slot = 2,
Room = "210",
Grade = b7,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 1,
Slot = 3,
Room = "308",
Grade = b10,
Subject = algebra,
Teacher = shulga
},
new Lesson {
Day = 4,
Slot = 2,
Room = "109",
Grade = a3,
Subject = maths_primary,
Teacher = zadorozhnia
},
new Lesson {
Day = 1,
Slot = 2,
Room = "110",
Grade = b3,
Subject = maths_primary,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 2,
Room = "109",
Grade = a3,
Subject = iexplore,
Teacher = zadorozhnia
},
new Lesson {
Day = 4,
Slot = 1,
Room = "109",
Grade = a3,
Subject = iexplore,
Teacher = zadorozhnia
},
new Lesson {
Day = 3,
Slot = 2,
Room = "110",
Grade = b3,
Subject = iexplore,
Teacher = hnots
},
new Lesson {
Day = 4,
Slot = 2,
Room = "110",
Grade = b3,
Subject = iexplore,
Teacher = hnots
},
new Lesson {
Day = 5,
Slot = 2,
Room = "110",
Grade = b3,
Subject = ukrainian_primary,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 3,
Room = "110",
Grade = b3,
Subject = reading,
Teacher = hnots
},
new Lesson {
Day = 2,
Slot = 3,
Room = "110",
Grade = b3,
Subject = design,
Teacher = hnots
},
new Lesson {
Day = 4,
Slot = 3,
Room = "110",
Grade = b3,
Subject = reading,
Teacher = hnots
},
new Lesson {
Day = 5,
Slot = 3,
Room = "110",
Grade = b3,
Subject = reading,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 4,
Room = "110",
Grade = b3,
Subject = maths_primary,
Teacher = hnots
},
new Lesson {
Day = 3,
Slot = 4,
Room = "110",
Grade = b3,
Subject = reading,
Teacher = hnots
},
new Lesson {
Day = 5,
Slot = 4,
Room = "110",
Grade = b3,
Subject = maths_primary,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 5,
Room = "110",
Grade = b3,
Subject = maths_primary,
Teacher = hnots
},
new Lesson {
Day = 2,
Slot = 5,
Room = "110",
Grade = b3,
Subject = ukrainian_primary,
Teacher = hnots
},
new Lesson {
Day = 3,
Slot = 5,
Room = "110",
Grade = b3,
Subject = ukrainian_primary,
Teacher = hnots
},
new Lesson {
Day = 1,
Slot = 1,
Room = "109",
Grade = a3,
Subject = design,
Teacher = zadorozhnia
},
new Lesson {
Day = 2,
Slot = 1,
Room = "109",
Grade = a3,
Subject = iexplore,
Teacher = zadorozhnia
},
new Lesson {
Day = 5,
Slot = 1,
Room = "109",
Grade = a3,
Subject = reading,
Teacher = zadorozhnia
},
new Lesson {
Day = 2,
Slot = 1,
Room = "105",
Grade = a1,
Subject = finearts,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "105",
Grade = a1,
Subject = iexplore,
Teacher = bondarenko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 6,
Room = "211",
Grade = a8,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 2,
Slot = 5,
Room = "308",
Grade = b10,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 3,
Slot = 5,
Room = "308",
Grade = b10,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 4,
Slot = 5,
Room = "208",
Grade = b6,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 5,
Slot = 5,
Room = "208",
Grade = b6,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 1,
Slot = 6,
Room = "208",
Grade = b6,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 2,
Slot = 1,
Room = "308",
Grade = b10,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 3,
Slot = 6,
Room = "208",
Grade = b6,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 4,
Slot = 6,
Room = "212",
Grade = b8,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 5,
Slot = 6,
Room = "212",
Grade = b8,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 1,
Slot = 7,
Room = "212",
Grade = b8,
Subject = ukrainian,
Teacher = verbova_nv
},
new Lesson {
Day = 2,
Slot = 6,
Room = "208",
Grade = b6,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 3,
Slot = 7,
Room = "308",
Grade = b10,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 4,
Slot = 7,
Room = "212",
Grade = b8,
Subject = ukrlit,
Teacher = verbova_nv
},
new Lesson {
Day = 1,
Slot = 5,
Room = "207",
Grade = a6,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 2,
Slot = 6,
Room = "307",
Grade = a10,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 2,
Slot = 5,
Room = "210",
Grade = b7,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 1,
Slot = 7,
Room = "211",
Grade = a8,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 4,
Slot = 6,
Room = "207",
Grade = a6,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 3,
Slot = 6,
Room = "309",
Grade = a11,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 4,
Slot = 2,
Room = "306",
Grade = b9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 5,
Slot = 6,
Room = "306",
Grade = b9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 1,
Slot = 7,
Room = "306",
Grade = b9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 2,
Slot = 7,
Room = "305",
Grade = a9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 3,
Slot = 7,
Room = "305",
Grade = a9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 4,
Slot = 6,
Room = "305",
Grade = a9,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 5,
Slot = 4,
Room = "207",
Grade = a6,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 1,
Slot = 5,
Room = "211",
Grade = a8,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 2,
Slot = 5,
Room = "207",
Grade = a6,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 3,
Slot = 5,
Room = "207",
Grade = a6,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 5,
Slot = 5,
Room = "207",
Grade = a6,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 1,
Slot = 6,
Room = "307",
Grade = a10,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 2,
Slot = 1,
Room = "211",
Grade = a8,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 3,
Slot = 1,
Room = "307",
Grade = a10,
Subject = ukrlit,
Teacher = kyrylusha
},
new Lesson {
Day = 5,
Slot = 6,
Room = "307",
Grade = a10,
Subject = ukrainian,
Teacher = kyrylusha
},
new Lesson {
Day = 2,
Slot = 6,
Room = "309",
Grade = a11,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 3,
Slot = 5,
Room = "208",
Grade = b6,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 5,
Slot = 5,
Room = "206",
Grade = b5,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 1,
Slot = 6,
Room = "206",
Grade = b5,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 2,
Slot = 6,
Room = "212",
Grade = b8,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "207",
Grade = a6,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 4,
Slot = 6,
Room = "211",
Grade = a8,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 5,
Slot = 6,
Room = "208",
Grade = b6,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 1,
Slot = 7,
Room = "305",
Grade = a9,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 2,
Slot = 7,
Room = "306",
Grade = b9,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 3,
Slot = 6,
Room = "209",
Grade = a7,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 1,
Slot = 5,
Room = "105",
Grade = a1,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 2,
Slot = 5,
Room = "111",
Grade = a4,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 3,
Slot = 5,
Room = "109",
Grade = a3,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 4,
Slot = 5,
Room = "306",
Grade = b9,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 5,
Slot = 5,
Room = "107",
Grade = a2,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 1,
Slot = 6,
Room = "309",
Grade = a11,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 2,
Slot = 6,
Room = "306",
Grade = b9,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 5,
Slot = 5,
Room = "210",
Grade = b7,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 4,
Slot = 5,
Room = "212",
Grade = b8,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 4,
Slot = 5,
Room = "205",
Grade = a5,
Subject = health,
Teacher = moskalenko
},
new Lesson {
Day = 4,
Slot = 6,
Room = "310",
Grade = b11,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 1,
Slot = 6,
Room = "205",
Grade = a5,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 2,
Slot = 6,
Room = "305",
Grade = a9,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 3,
Slot = 6,
Room = "306",
Grade = b9,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 4,
Slot = 6,
Room = "208",
Grade = b6,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 5,
Slot = 6,
Room = "207",
Grade = a6,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 1,
Slot = 7,
Room = "209",
Grade = a7,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 2,
Slot = 7,
Room = "211",
Grade = a8,
Subject = crafts,
Teacher = honcharuk
},
new Lesson {
Day = 1,
Slot = 5,
Room = "106",
Grade = b1,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 2,
Slot = 5,
Room = "112",
Grade = b4,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 3,
Slot = 5,
Room = "108",
Grade = b2,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 4,
Slot = 5,
Room = "308",
Grade = b10,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 5,
Slot = 1,
Room = "212",
Grade = b8,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 1,
Slot = 6,
Room = "207",
Grade = a6,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 2,
Slot = 6,
Room = "110",
Grade = b3,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 3,
Slot = 6,
Room = "212",
Grade = b8,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 5,
Slot = 5,
Room = "308",
Grade = b10,
Subject = it,
Teacher = shafran
},
new Lesson {
Day = 1,
Slot = 1,
Room = "307",
Grade = a10,
Subject = chemistry,
Teacher = shevchenko
},
new Lesson {
Day = 1,
Slot = 6,
Room = "310",
Grade = b11,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 4,
Slot = 5,
Room = "307",
Grade = a10,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 1,
Slot = 3,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 2,
Slot = 3,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 4,
Slot = 3,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 5,
Slot = 3,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 1,
Slot = 4,
Room = "106",
Grade = b1,
Subject = maths_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 2,
Slot = 4,
Room = "106",
Grade = b1,
Subject = maths_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 3,
Slot = 4,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 5,
Slot = 4,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 1,
Slot = 1,
Room = "206",
Grade = b5,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 3,
Slot = 1,
Room = "209",
Grade = a7,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 5,
Slot = 1,
Room = "205",
Grade = a5,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 2,
Slot = 2,
Room = "207",
Grade = a6,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 4,
Slot = 4,
Room = "208",
Grade = b6,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 1,
Slot = 5,
Room = "112",
Grade = b4,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 2,
Slot = 5,
Room = "106",
Grade = b1,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 5,
Slot = 2,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 3,
Slot = 5,
Room = "111",
Grade = a4,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 4,
Slot = 2,
Room = "106",
Grade = b1,
Subject = ukrainian_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 2,
Slot = 2,
Room = "106",
Grade = b1,
Subject = finearts,
Teacher = vlasiuk
},
new Lesson {
Day = 5,
Slot = 1,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "105",
Grade = a1,
Subject = maths_primary,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 2,
Room = "105",
Grade = a1,
Subject = iexplore,
Teacher = bondarenko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "105",
Grade = a1,
Subject = maths_primary,
Teacher = bondarenko
},
new Lesson {
Day = 2,
Slot = 3,
Room = "105",
Grade = a1,
Subject = maths_primary,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "105",
Grade = a1,
Subject = maths_primary,
Teacher = bondarenko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 4,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 5,
Slot = 4,
Room = "105",
Grade = a1,
Subject = ukrainian_primary,
Teacher = bondarenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "106",
Grade = b1,
Subject = maths_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 4,
Slot = 1,
Room = "106",
Grade = b1,
Subject = iexplore,
Teacher = vlasiuk
},
new Lesson {
Day = 1,
Slot = 2,
Room = "106",
Grade = b1,
Subject = iexplore,
Teacher = vlasiuk
},
new Lesson {
Day = 3,
Slot = 2,
Room = "106",
Grade = b1,
Subject = maths_primary,
Teacher = vlasiuk
},
new Lesson {
Day = 5,
Slot = 5,
Room = "307",
Grade = a10,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 4,
Slot = 1,
Room = "107",
Grade = a2,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 1,
Slot = 6,
Room = "105",
Grade = a1,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 3,
Slot = 3,
Room = "308",
Grade = b10,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 4,
Slot = 3,
Room = "308",
Grade = b10,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 5,
Slot = 4,
Room = "208",
Grade = b6,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 1,
Slot = 5,
Room = "208",
Grade = b6,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 2,
Slot = 5,
Room = "212",
Grade = b8,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 3,
Slot = 5,
Room = "306",
Grade = b9,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 4,
Slot = 5,
Room = "206",
Grade = b5,
Subject = nature,
Teacher = dybka
},
new Lesson {
Day = 5,
Slot = 5,
Room = "310",
Grade = b11,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 1,
Slot = 6,
Room = "212",
Grade = b8,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 2,
Slot = 6,
Room = "310",
Grade = b11,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 4,
Slot = 6,
Room = "210",
Grade = b7,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 5,
Slot = 6,
Room = "210",
Grade = b7,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 5,
Slot = 3,
Room = "308",
Grade = b10,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 5,
Slot = 4,
Room = "308",
Grade = b10,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 1,
Slot = 5,
Room = "310",
Grade = b11,
Subject = english,
Teacher = lisichkina
},
new Lesson {
Day = 3,
Slot = 2,
Room = "206",
Grade = b5,
Subject = nature,
Teacher = dybka
},
new Lesson {
Day = 5,
Slot = 5,
Room = "110",
Grade = b3,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 3,
Slot = 1,
Room = "306",
Grade = b9,
Subject = biology,
Teacher = dybka
},
new Lesson {
Day = 4,
Slot = 6,
Room = "209",
Grade = a7,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 2,
Slot = 6,
Room = "109",
Grade = a3,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 3,
Slot = 6,
Room = "210",
Grade = b7,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 4,
Slot = 5,
Room = "108",
Grade = b2,
Subject = music,
Teacher = zviahelskyi
},
new Lesson {
Day = 4,
Slot = 2,
Room = "211",
Grade = a8,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 4,
Slot = 3,
Room = "305",
Grade = a9,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 5,
Slot = 3,
Room = "307",
Grade = a10,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 3,
Slot = 4,
Room = "207",
Grade = a6,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 4,
Slot = 4,
Room = "207",
Grade = a6,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 1,
Slot = 5,
Room = "309",
Grade = a11,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 3,
Slot = 5,
Room = "307",
Grade = a10,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 4,
Slot = 5,
Room = "309",
Grade = a11,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 5,
Slot = 5,
Room = "205",
Grade = a5,
Subject = nature,
Teacher = boyarska
},
new Lesson {
Day = 1,
Slot = 6,
Room = "211",
Grade = a8,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 2,
Slot = 6,
Room = "205",
Grade = a5,
Subject = nature,
Teacher = boyarska
},
new Lesson {
Day = 3,
Slot = 6,
Room = "305",
Grade = a9,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 5,
Slot = 6,
Room = "209",
Grade = a7,
Subject = biology,
Teacher = boyarska
},
new Lesson {
Day = 3,
Slot = 6,
Room = "206",
Grade = b5,
Subject = it,
Teacher = kyrianov
},
new Lesson {
Day = 5,
Slot = 5,
Room = "209",
Grade = a7,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 3,
Slot = 5,
Room = "205",
Grade = a5,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 1,
Slot = 4,
Room = "105",
Grade = a1,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 4,
Room = "307",
Grade = a10,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 3,
Slot = 4,
Room = "108",
Grade = b2,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 4,
Slot = 4,
Room = "307",
Grade = a10,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 5,
Slot = 4,
Room = "309",
Grade = a11,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 1,
Slot = 5,
Room = "206",
Grade = b5,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 5,
Slot = 3,
Room = "109",
Grade = a3,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 5,
Room = "109",
Grade = a3,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 4,
Slot = 5,
Room = "109",
Grade = a3,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 1,
Slot = 1,
Room = "207",
Grade = a6,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 2,
Slot = 1,
Room = "210",
Grade = b7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 1,
Room = "212",
Grade = b8,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 4,
Slot = 1,
Room = "207",
Grade = a6,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 5,
Slot = 5,
Room = "212",
Grade = b8,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 5,
Room = "309",
Grade = a11,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 4,
Slot = 3,
Room = "212",
Grade = b8,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 3,
Slot = 3,
Room = "212",
Grade = b8,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 3,
Room = "209",
Grade = a7,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 5,
Room = "211",
Grade = a8,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 3,
Slot = 5,
Room = "211",
Grade = a8,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 5,
Room = "211",
Grade = a8,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 6,
Room = "306",
Grade = b9,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 1,
Room = "105",
Grade = a1,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 1,
Room = "309",
Grade = a11,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 3,
Slot = 1,
Room = "108",
Grade = b2,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 4,
Slot = 1,
Room = "212",
Grade = b8,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 5,
Slot = 1,
Room = "206",
Grade = b5,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 1,
Slot = 2,
Room = "209",
Grade = a7,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 2,
Slot = 2,
Room = "108",
Grade = b2,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 3,
Slot = 2,
Room = "209",
Grade = a7,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 4,
Slot = 2,
Room = "206",
Grade = b5,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 5,
Slot = 2,
Room = "307",
Grade = a10,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 1,
Slot = 3,
Room = "105",
Grade = a1,
Subject = pt,
Teacher = melnychuk
},
new Lesson {
Day = 1,
Slot = 2,
Room = "210",
Grade = b7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 2,
Slot = 2,
Room = "105",
Grade = a1,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 2,
Room = "207",
Grade = a6,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 4,
Slot = 2,
Room = "105",
Grade = a1,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 1,
Slot = 2,
Room = "111",
Grade = a4,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 2,
Slot = 2,
Room = "308",
Grade = b10,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 3,
Slot = 2,
Room = "111",
Grade = a4,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 4,
Slot = 2,
Room = "308",
Grade = b10,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 2,
Room = "308",
Grade = b10,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 1,
Slot = 3,
Room = "310",
Grade = b11,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 2,
Slot = 3,
Room = "207",
Grade = a6,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 3,
Slot = 3,
Room = "106",
Grade = b1,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 4,
Slot = 3,
Room = "210",
Grade = b7,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 3,
Room = "207",
Grade = a6,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 1,
Slot = 4,
Room = "207",
Grade = a6,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 2,
Slot = 4,
Room = "305",
Grade = a9,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 3,
Slot = 4,
Room = "305",
Grade = a9,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 4,
Slot = 4,
Room = "106",
Grade = b1,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 4,
Room = "210",
Grade = b7,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 1,
Room = "110",
Grade = b3,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 1,
Slot = 5,
Room = "307",
Grade = a10,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 1,
Room = "110",
Grade = b3,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 2,
Slot = 1,
Room = "106",
Grade = b1,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 2,
Room = "108",
Grade = b2,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 1,
Slot = 3,
Room = "108",
Grade = b2,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 2,
Slot = 3,
Room = "206",
Grade = b5,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 3,
Room = "111",
Grade = a4,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 4,
Slot = 3,
Room = "111",
Grade = a4,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 5,
Slot = 3,
Room = "108",
Grade = b2,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 1,
Slot = 4,
Room = "206",
Grade = b5,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 2,
Slot = 4,
Room = "209",
Grade = a7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 4,
Room = "111",
Grade = a4,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 4,
Slot = 4,
Room = "210",
Grade = b7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 5,
Slot = 4,
Room = "206",
Grade = b5,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 1,
Slot = 5,
Room = "212",
Grade = b8,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 2,
Slot = 5,
Room = "209",
Grade = a7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 3,
Slot = 5,
Room = "209",
Grade = a7,
Subject = english,
Teacher = vasylieva
},
new Lesson {
Day = 1,
Slot = 1,
Room = "305",
Grade = a9,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 3,
Slot = 1,
Room = "110",
Grade = b3,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 5,
Slot = 4,
Room = "307",
Grade = a10,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 4,
Room = "305",
Grade = a9,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 3,
Slot = 4,
Room = "307",
Grade = a10,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 5,
Room = "308",
Grade = b10,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 5,
Room = "208",
Grade = b6,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 5,
Room = "210",
Grade = b7,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 4,
Slot = 5,
Room = "207",
Grade = a6,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 5,
Slot = 5,
Room = "309",
Grade = a11,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 6,
Room = "209",
Grade = a7,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 6,
Room = "207",
Grade = a6,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 6,
Room = "308",
Grade = b10,
Subject = civileduc,
Teacher = bulachok
},
new Lesson {
Day = 4,
Slot = 6,
Room = "308",
Grade = b10,
Subject = civileduc,
Teacher = bulachok
},
new Lesson {
Day = 5,
Slot = 6,
Room = "211",
Grade = a8,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 1,
Room = "309",
Grade = a11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 2,
Slot = 6,
Room = "211",
Grade = a8,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 1,
Room = "308",
Grade = b10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 1,
Room = "308",
Grade = b10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 5,
Slot = 1,
Room = "310",
Grade = b11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 5,
Slot = 4,
Room = "211",
Grade = a8,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 2,
Room = "211",
Grade = a8,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 4,
Room = "212",
Grade = b8,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 4,
Room = "306",
Grade = b9,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 1,
Room = "307",
Grade = a10,
Subject = civileduc,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 1,
Room = "205",
Grade = a5,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 4,
Slot = 1,
Room = "306",
Grade = b9,
Subject = jurisprudence,
Teacher = bulachok
},
new Lesson {
Day = 5,
Slot = 1,
Room = "208",
Grade = b6,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 2,
Room = "307",
Grade = a10,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 2,
Room = "206",
Grade = b5,
Subject = history,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 2,
Room = "305",
Grade = a9,
Subject = jurisprudence,
Teacher = bulachok
},
new Lesson {
Day = 4,
Slot = 2,
Room = "307",
Grade = a10,
Subject = civileduc,
Teacher = bulachok
},
new Lesson {
Day = 5,
Slot = 2,
Room = "310",
Grade = b11,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 3,
Room = "210",
Grade = b7,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 2,
Slot = 3,
Room = "305",
Grade = a9,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 3,
Room = "305",
Grade = a9,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 4,
Slot = 3,
Room = "307",
Grade = a10,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 5,
Slot = 3,
Room = "212",
Grade = b8,
Subject = uhistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 4,
Room = "306",
Grade = b9,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 3,
Slot = 4,
Room = "308",
Grade = b10,
Subject = whistory,
Teacher = bulachok
},
new Lesson {
Day = 1,
Slot = 5,
Room = "210",
Grade = b7,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 2,
Slot = 2,
Room = "307",
Grade = a10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 2,
Room = "212",
Grade = b8,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 1,
Room = "305",
Grade = a9,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 1,
Room = "205",
Grade = a5,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 5,
Slot = 1,
Room = "309",
Grade = a11,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 2,
Room = "205",
Grade = a5,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 2,
Slot = 2,
Room = "305",
Grade = a9,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 3,
Slot = 2,
Room = "310",
Grade = b11,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 2,
Room = "310",
Grade = b11,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 5,
Slot = 2,
Room = "209",
Grade = a7,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 3,
Room = "207",
Grade = a6,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 2,
Slot = 3,
Room = "208",
Grade = b6,
Subject = it,
Teacher = kholodiuk
},
new Lesson {
Day = 3,
Slot = 3,
Room = "210",
Grade = b7,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 4,
Slot = 3,
Room = "206",
Grade = b5,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 5,
Slot = 3,
Room = "209",
Grade = a7,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 1,
Slot = 4,
Room = "309",
Grade = a11,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 2,
Slot = 4,
Room = "308",
Grade = b10,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 2,
Slot = 1,
Room = "212",
Grade = b8,
Subject = arts,
Teacher = kholodiuk
},
new Lesson {
Day = 3,
Slot = 2,
Room = "307",
Grade = a10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 1,
Slot = 1,
Room = "208",
Grade = b6,
Subject = finearts_primary,
Teacher = kholodiuk
},
new Lesson {
Day = 5,
Slot = 5,
Room = "306",
Grade = b9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 5,
Slot = 2,
Room = "305",
Grade = a9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 1,
Slot = 3,
Room = "309",
Grade = a11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 2,
Slot = 3,
Room = "210",
Grade = b7,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 3,
Room = "307",
Grade = a10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 3,
Room = "209",
Grade = a7,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 5,
Slot = 3,
Room = "309",
Grade = a11,
Subject = astronomy,
Teacher = verbova_vo
},
new Lesson {
Day = 1,
Slot = 4,
Room = "308",
Grade = b10,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 2,
Slot = 4,
Room = "310",
Grade = b11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 4,
Room = "310",
Grade = b11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 4,
Room = "309",
Grade = a11,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 5,
Slot = 4,
Room = "306",
Grade = b9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 1,
Slot = 5,
Room = "306",
Grade = b9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 2,
Slot = 5,
Room = "310",
Grade = b11,
Subject = astronomy,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 5,
Room = "212",
Grade = b8,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 4,
Slot = 5,
Room = "305",
Grade = a9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 1,
Slot = 6,
Room = "305",
Grade = a9,
Subject = physics,
Teacher = verbova_vo
},
new Lesson {
Day = 3,
Slot = 5,
Room = "310",
Grade = b11,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 4,
Slot = 5,
Room = "310",
Grade = b11,
Subject = pt,
Teacher = slavov
},
new Lesson {
Day = 1,
Slot = 1,
Room = "306",
Grade = b9,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 3,
Slot = 4,
Room = "211",
Grade = a8,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 4,
Slot = 4,
Room = "205",
Grade = a5,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 1,
Slot = 1,
Room = "210",
Grade = b7,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 3,
Slot = 1,
Room = "206",
Grade = b5,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 4,
Slot = 1,
Room = "310",
Grade = b11,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 5,
Slot = 1,
Room = "210",
Grade = b7,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 1,
Slot = 2,
Room = "306",
Grade = b9,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 2,
Slot = 2,
Room = "306",
Grade = b9,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 3,
Slot = 2,
Room = "210",
Grade = b7,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 4,
Slot = 2,
Room = "210",
Grade = b7,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 5,
Slot = 2,
Room = "206",
Grade = b5,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 1,
Slot = 3,
Room = "206",
Grade = b5,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 3,
Slot = 3,
Room = "310",
Grade = b11,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 5,
Slot = 3,
Room = "206",
Grade = b5,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 1,
Slot = 4,
Room = "310",
Grade = b11,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 2,
Slot = 4,
Room = "208",
Grade = b6,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 3,
Slot = 4,
Room = "306",
Grade = b9,
Subject = ukrlit,
Teacher = symonenko_op
},
new Lesson {
Day = 1,
Slot = 4,
Room = "208",
Grade = b6,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 4,
Slot = 3,
Room = "306",
Grade = b9,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 4,
Slot = 4,
Room = "206",
Grade = b5,
Subject = maths,
Teacher = manko
},
new Lesson {
Day = 2,
Slot = 5,
Room = "307",
Grade = a10,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 1,
Slot = 1,
Room = "107",
Grade = a2,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 2,
Slot = 1,
Room = "306",
Grade = b9,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 3,
Slot = 1,
Room = "112",
Grade = b4,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 4,
Slot = 1,
Room = "112",
Grade = b4,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 5,
Slot = 1,
Room = "107",
Grade = a2,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 1,
Slot = 2,
Room = "310",
Grade = b11,
Subject = civildef,
Teacher = tverdokhlibova
},
new Lesson {
Day = 2,
Slot = 2,
Room = "211",
Grade = a8,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 3,
Slot = 2,
Room = "211",
Grade = a8,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 4,
Slot = 6,
Room = "306",
Grade = b9,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 5,
Slot = 2,
Room = "107",
Grade = a2,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 1,
Slot = 3,
Room = "205",
Grade = a5,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 2,
Slot = 3,
Room = "309",
Grade = a11,
Subject = civildef,
Teacher = tverdokhlibova
},
new Lesson {
Day = 3,
Slot = 3,
Room = "205",
Grade = a5,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 5,
Slot = 3,
Room = "208",
Grade = b6,
Subject = pt,
Teacher = tverdokhlibova
},
new Lesson {
Day = 3,
Slot = 4,
Room = "209",
Grade = a7,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "306",
Grade = b9,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 2,
Slot = 5,
Room = "206",
Grade = b5,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 2,
Slot = 1,
Room = "205",
Grade = a5,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 3,
Slot = 1,
Room = "309",
Grade = a11,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 4,
Slot = 1,
Room = "305",
Grade = a9,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 5,
Slot = 1,
Room = "305",
Grade = a9,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 1,
Slot = 2,
Room = "305",
Grade = a9,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 2,
Slot = 2,
Room = "209",
Grade = a7,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 3,
Slot = 2,
Room = "309",
Grade = a11,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 4,
Slot = 2,
Room = "205",
Grade = a5,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 5,
Slot = 2,
Room = "309",
Grade = a11,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 1,
Slot = 3,
Room = "305",
Grade = a9,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 3,
Slot = 3,
Room = "309",
Grade = a11,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 4,
Slot = 3,
Room = "205",
Grade = a5,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 5,
Slot = 4,
Room = "205",
Grade = a5,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 1,
Slot = 5,
Room = "209",
Grade = a7,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 2,
Slot = 5,
Room = "205",
Grade = a5,
Subject = ukrainian,
Teacher = havro
},
new Lesson {
Day = 5,
Slot = 4,
Room = "209",
Grade = a7,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 5,
Slot = 4,
Room = "310",
Grade = b11,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 4,
Slot = 4,
Room = "209",
Grade = a7,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 1,
Slot = 4,
Room = "210",
Grade = b7,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 3,
Slot = 5,
Room = "206",
Grade = b5,
Subject = ukrainian,
Teacher = symonenko_op
},
new Lesson {
Day = 1,
Slot = 1,
Room = "211",
Grade = a8,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 2,
Slot = 1,
Room = "305",
Grade = a9,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "310",
Grade = b11,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "211",
Grade = a8,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "207",
Grade = a6,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "212",
Grade = b8,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "309",
Grade = a11,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 3,
Slot = 2,
Room = "308",
Grade = b10,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "207",
Grade = a6,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 1,
Slot = 3,
Room = "307",
Grade = a10,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 2,
Slot = 3,
Room = "212",
Grade = b8,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "208",
Grade = b6,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "208",
Grade = b6,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "306",
Grade = b9,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "210",
Grade = b7,
Subject = geography,
Teacher = ponomarenko
},
new Lesson {
Day = 4,
Slot = 5,
Room = "209",
Grade = a7,
Subject = ukrlit,
Teacher = havro
},
new Lesson {
Day = 2,
Slot = 4,
Room = "212",
Grade = b8,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "310",
Grade = b11,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 1,
Slot = 5,
Room = "305",
Grade = a9,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 5,
Slot = 5,
Room = "211",
Grade = a8,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 1,
Slot = 1,
Room = "212",
Grade = b8,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 2,
Slot = 1,
Room = "310",
Grade = b11,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 3,
Slot = 1,
Room = "211",
Grade = a8,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "210",
Grade = b7,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "308",
Grade = b10,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "207",
Grade = a6,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "107",
Grade = a2,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 3,
Slot = 2,
Room = "205",
Grade = a5,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 4,
Slot = 2,
Room = "107",
Grade = a2,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "211",
Grade = a8,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 1,
Slot = 3,
Room = "211",
Grade = a8,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 2,
Slot = 3,
Room = "306",
Grade = b9,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "110",
Grade = b3,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 5,
Slot = 4,
Room = "212",
Grade = b8,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "107",
Grade = a2,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "308",
Grade = b10,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "206",
Grade = b5,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 2,
Slot = 1,
Room = "209",
Grade = a7,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 3,
Slot = 6,
Room = "207",
Grade = a6,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "206",
Grade = b5,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "307",
Grade = a10,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "208",
Grade = b6,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "205",
Grade = a5,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 3,
Slot = 2,
Room = "208",
Grade = b6,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 4,
Slot = 2,
Room = "207",
Grade = a6,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "210",
Grade = b7,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 1,
Slot = 3,
Room = "212",
Grade = b8,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 2,
Slot = 3,
Room = "205",
Grade = a5,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "211",
Grade = a8,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 4,
Slot = 3,
Room = "310",
Grade = b11,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "210",
Grade = b7,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 1,
Slot = 4,
Room = "209",
Grade = a7,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 3,
Slot = 4,
Room = "309",
Grade = a11,
Subject = wliterature,
Teacher = synko
},
new Lesson {
Day = 1,
Slot = 4,
Room = "307",
Grade = a10,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 5,
Slot = 3,
Room = "205",
Grade = a5,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "110",
Grade = b3,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 3,
Slot = 4,
Room = "205",
Grade = a5,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 4,
Slot = 4,
Room = "211",
Grade = a8,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 1,
Slot = 1,
Room = "310",
Grade = b11,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 2,
Slot = 1,
Room = "206",
Grade = b5,
Subject = maths,
Teacher = manko
},
new Lesson {
Day = 3,
Slot = 6,
Room = "307",
Grade = a10,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 4,
Slot = 1,
Room = "209",
Grade = a7,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 5,
Slot = 1,
Room = "209",
Grade = a7,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 1,
Slot = 2,
Room = "206",
Grade = b5,
Subject = maths,
Teacher = manko
},
new Lesson {
Day = 2,
Slot = 2,
Room = "212",
Grade = b8,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 3,
Slot = 2,
Room = "212",
Grade = b8,
Subject = geometry,
Teacher = manko
},
new Lesson {
Day = 4,
Slot = 2,
Room = "209",
Grade = a7,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 5,
Slot = 2,
Room = "212",
Grade = b8,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 1,
Slot = 3,
Room = "209",
Grade = a7,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 2,
Slot = 3,
Room = "310",
Grade = b11,
Subject = algebra,
Teacher = manko
},
new Lesson {
Day = 3,
Slot = 3,
Room = "206",
Grade = b5,
Subject = maths,
Teacher = manko
},
new Lesson {
Day = 2,
Slot = 4,
Room = "205",
Grade = a5,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 1,
Slot = 4,
Room = "205",
Grade = a5,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 1,
Slot = 4,
Room = "211",
Grade = a8,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 4,
Slot = 3,
Room = "309",
Grade = a11,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 3,
Slot = 4,
Room = "206",
Grade = b5,
Subject = french,
Teacher = martynenko
},
new Lesson {
Day = 4,
Slot = 4,
Room = "110",
Grade = b3,
Subject = english,
Teacher = martynenko
},
new Lesson {
Day = 1,
Slot = 1,
Room = "205",
Grade = a5,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 2,
Slot = 1,
Room = "208",
Grade = b6,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 3,
Slot = 1,
Room = "208",
Grade = b6,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 4,
Slot = 1,
Room = "309",
Grade = a11,
Subject = geometry,
Teacher = smychnikova
},
new Lesson {
Day = 5,
Slot = 1,
Room = "306",
Grade = b9,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 1,
Slot = 2,
Room = "309",
Grade = a11,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 2,
Slot = 2,
Room = "208",
Grade = b6,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 3,
Slot = 2,
Room = "306",
Grade = b9,
Subject = algebra,
Teacher = smychnikova
},
new Lesson {
Day = 4,
Slot = 2,
Room = "208",
Grade = b6,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 5,
Slot = 2,
Room = "205",
Grade = a5,
Subject = maths,
Teacher = smychnikova
},
new Lesson {
Day = 1,
Slot = 3,
Room = "306",
Grade = b9,
Subject = geometry,
Teacher = smychnikova
},
new Lesson {
Day = 2,
Slot = 3,
Room = "211",
Grade = a8,
Subject = geometry,
Teacher = smychnikova
},
new Lesson {
Day = 3,
Slot = 3,
Room = "306",
Grade = b9,
Subject = geometry,
Teacher = smychnikova
},
new Lesson {
Day = 5,
Slot = 3,
Room = "211",
Grade = a8,
Subject = geometry,
Teacher = smychnikova
},
new Lesson {
Day = 1,
Slot = 7,
Room = "210",
Grade = b7,
Subject = it,
Teacher = kyrianov
}
        };
    }
}
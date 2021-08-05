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
    public class CurriculaSeedData
    {
        public static List<Curriculum> data = new List<Curriculum>
        {
            new Curriculum
            {
                Quantity = 2,
                Grade = a1,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a1,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a1,
                Subject = maths_primary,
                Teacher = bondarenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a1,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a1,
                Subject = finearts_primary,
                Teacher = bondarenko
            },
            new Curriculum
            {
                Quantity = 8,
                Grade = a1,
                Subject = ukrainian_primary,
                Teacher = bondarenko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a1,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a1,
                Subject = iexplore,
                Teacher = bondarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b1,
                Subject = english,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b1,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b1,
                Subject = maths_primary,
                Teacher = vlasiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b1,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b1,
                Subject = finearts_primary,
                Teacher = vlasiuk
            },
            new Curriculum
            {
                Quantity = 8,
                Grade = b1,
                Subject = ukrainian_primary,
                Teacher = vlasiuk
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b1,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b1,
                Subject = iexplore,
                Teacher = vlasiuk
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a2,
                Subject = english,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a2,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a2,
                Subject = maths_primary,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a2,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a2,
                Subject = finearts_primary,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a2,
                Subject = crafts_primary,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a2,
                Subject = ukrainian_primary,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a2,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a2,
                Subject = reading,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a2,
                Subject = iexplore,
                Teacher = horlova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b2,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b2,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b2,
                Subject = maths_primary,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b2,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b2,
                Subject = finearts_primary,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b2,
                Subject = crafts_primary,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b2,
                Subject = ukrainian_primary,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b2,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b2,
                Subject = reading,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b2,
                Subject = iexplore,
                Teacher = yeroshkina
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a3,
                Subject = english,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a3,
                Subject = design,
                Teacher = zadorozhnia
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a3,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 5,
                Grade = a3,
                Subject = maths_primary,
                Teacher = zadorozhnia
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a3,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a3,
                Subject = ukrainian_primary,
                Teacher = zadorozhnia
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a3,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a3,
                Subject = reading,
                Teacher = zadorozhnia
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a3,
                Subject = iexplore,
                Teacher = zadorozhnia
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b3,
                Subject = english,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b3,
                Subject = design,
                Teacher = hnots
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b3,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 5,
                Grade = b3,
                Subject = maths_primary,
                Teacher = hnots
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b3,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b3,
                Subject = ukrainian_primary,
                Teacher = hnots
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b3,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b3,
                Subject = reading,
                Teacher = hnots
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b3,
                Subject = iexplore,
                Teacher = hnots
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a4,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a4,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a4,
                Subject = litreading,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a4,
                Subject = maths_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a4,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a4,
                Subject = finearts_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a4,
                Subject = health_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a4,
                Subject = nature_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a4,
                Subject = crafts_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a4,
                Subject = ukrainian_primary,
                Teacher = lavrychenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a4,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b4,
                Subject = english,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b4,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b4,
                Subject = litreading,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b4,
                Subject = maths_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b4,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b4,
                Subject = finearts_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b4,
                Subject = health_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b4,
                Subject = nature_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b4,
                Subject = crafts_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b4,
                Subject = ukrainian_primary,
                Teacher = lonska
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b4,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a5,
                Subject = english,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a5,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = history,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a5,
                Subject = maths,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a5,
                Subject = nature,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a5,
                Subject = ukrlit,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a5,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a5,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b5,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b5,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = history,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b5,
                Subject = maths,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b5,
                Subject = nature,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b5,
                Subject = ukrlit,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b5,
                Subject = ukrainian,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b5,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b5,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a6,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a6,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = history,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = a6,
                Subject = maths,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a6,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a6,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a6,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a6,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a6,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a6,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a6,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b6,
                Subject = english,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b6,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = history,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 4,
                Grade = b6,
                Subject = maths,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b6,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b6,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b6,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b6,
                Subject = ukrlit,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b6,
                Subject = ukrainian,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b6,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b6,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a7,
                Subject = algebra,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a7,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = geometry,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = ukrlit,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a7,
                Subject = ukrainian,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a7,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b7,
                Subject = algebra,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b7,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = geometry,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = music,
                Teacher = zviahelskyi
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = finearts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = ukrlit,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b7,
                Subject = ukrainian,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b7,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b7,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a8,
                Subject = english,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a8,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a8,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = algebra,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b8,
                Subject = english,
                Teacher = vasylieva
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = geometry,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = ukrlit,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = ukrainian,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b8,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b8,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b8,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = algebra,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a9,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = geometry,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = jurisprudence,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = ukrlit,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = ukrainian,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a9,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a9,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a9,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a9,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b9,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = health,
                Teacher = moskalenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = jurisprudence,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = crafts,
                Teacher = honcharuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = ukrlit,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = ukrainian,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b9,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b9,
                Subject = pt,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b9,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b9,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = algebra,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = geometry,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = civileduc,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = it,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = ukrlit,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = ukrainian,
                Teacher = kyrylusha
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a10,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a10,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a10,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = algebra,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = whistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = geometry,
                Teacher = shulga
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = civileduc,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = ukrlit,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = ukrainian,
                Teacher = verbova_nv
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b10,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b10,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b10,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b10,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = algebra,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = astronomy,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = biology,
                Teacher = boyarska
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = geometry,
                Teacher = smychnikova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = civildef,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = it,
                Teacher = kyrianov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = ukrlit,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = ukrainian,
                Teacher = havro
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a11,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = a11,
                Subject = pt,
                Teacher = melnychuk
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = a11,
                Subject = french,
                Teacher = kurach
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = a11,
                Subject = chemistry,
                Teacher = shevchenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = algebra,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = english,
                Teacher = lisichkina
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = astronomy,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = biology,
                Teacher = dybka
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = geography,
                Teacher = ponomarenko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = geometry,
                Teacher = manko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = wliterature,
                Teacher = synko
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = civildef,
                Teacher = tverdokhlibova
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = it,
                Teacher = shafran
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = uhistory,
                Teacher = bulachok
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = arts,
                Teacher = kholodiuk
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = ukrlit,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = ukrainian,
                Teacher = symonenko_op
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b11,
                Subject = physics,
                Teacher = verbova_vo
            },
            new Curriculum
            {
                Quantity = 3,
                Grade = b11,
                Subject = pt,
                Teacher = slavov
            },
            new Curriculum
            {
                Quantity = 1,
                Grade = b11,
                Subject = french,
                Teacher = martynenko
            },
            new Curriculum
            {
                Quantity = 2,
                Grade = b11,
                Subject = chemistry,
                Teacher = shevchenko
            }
        };
    }
}

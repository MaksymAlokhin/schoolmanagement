using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedCurriculum
    {
        public List<Curriculum> data;
        SeedGrade grades;
        SeedSubject subjects;
        SeedTeacher teachers;
        public SeedCurriculum(SeedGrade _grades, SeedSubject _subjects, SeedTeacher _teachers)
        {
            grades = _grades;
            subjects = _subjects;
            teachers = _teachers;
            CreateCurricula();
        }
        void CreateCurricula()
        {
            #region Create curricula
            data = new List<Curriculum>
            {
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a1,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a1,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a1,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.bondarenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a1,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a1,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.bondarenko
                },
                new Curriculum
                {
                    Quantity = 8,
                    Grade = grades.a1,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.bondarenko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a1,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a1,
                    Subject = subjects.iexplore,
                    Teacher = teachers.bondarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b1,
                    Subject = subjects.english,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b1,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b1,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.vlasiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b1,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b1,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.vlasiuk
                },
                new Curriculum
                {
                    Quantity = 8,
                    Grade = grades.b1,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.vlasiuk
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b1,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b1,
                    Subject = subjects.iexplore,
                    Teacher = teachers.vlasiuk
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a2,
                    Subject = subjects.english,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a2,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a2,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a2,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a2,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a2,
                    Subject = subjects.crafts_primary,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a2,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a2,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a2,
                    Subject = subjects.reading,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a2,
                    Subject = subjects.iexplore,
                    Teacher = teachers.horlova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b2,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b2,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b2,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b2,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b2,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b2,
                    Subject = subjects.crafts_primary,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b2,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b2,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b2,
                    Subject = subjects.reading,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b2,
                    Subject = subjects.iexplore,
                    Teacher = teachers.yeroshkina
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a3,
                    Subject = subjects.english,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a3,
                    Subject = subjects.design,
                    Teacher = teachers.zadorozhnia
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a3,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 5,
                    Grade = grades.a3,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.zadorozhnia
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a3,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a3,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.zadorozhnia
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a3,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a3,
                    Subject = subjects.reading,
                    Teacher = teachers.zadorozhnia
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a3,
                    Subject = subjects.iexplore,
                    Teacher = teachers.zadorozhnia
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b3,
                    Subject = subjects.english,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b3,
                    Subject = subjects.design,
                    Teacher = teachers.hnots
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b3,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 5,
                    Grade = grades.b3,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.hnots
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b3,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b3,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.hnots
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b3,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b3,
                    Subject = subjects.reading,
                    Teacher = teachers.hnots
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b3,
                    Subject = subjects.iexplore,
                    Teacher = teachers.hnots
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a4,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a4,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a4,
                    Subject = subjects.litreading,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a4,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a4,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a4,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a4,
                    Subject = subjects.health_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a4,
                    Subject = subjects.nature_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a4,
                    Subject = subjects.crafts_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a4,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.lavrychenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a4,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b4,
                    Subject = subjects.english,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b4,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b4,
                    Subject = subjects.litreading,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b4,
                    Subject = subjects.maths_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b4,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b4,
                    Subject = subjects.finearts_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b4,
                    Subject = subjects.health_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b4,
                    Subject = subjects.nature_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b4,
                    Subject = subjects.crafts_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b4,
                    Subject = subjects.ukrainian_primary,
                    Teacher = teachers.lonska
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b4,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a5,
                    Subject = subjects.english,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a5,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.history,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a5,
                    Subject = subjects.maths,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a5,
                    Subject = subjects.nature,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a5,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a5,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a5,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a5,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b5,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b5,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.history,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b5,
                    Subject = subjects.maths,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b5,
                    Subject = subjects.nature,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b5,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b5,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b5,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b5,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a6,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a6,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.history,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.a6,
                    Subject = subjects.maths,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a6,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a6,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a6,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a6,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a6,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a6,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a6,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b6,
                    Subject = subjects.english,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b6,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.history,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 4,
                    Grade = grades.b6,
                    Subject = subjects.maths,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b6,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b6,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b6,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b6,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b6,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b6,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b6,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a7,
                    Subject = subjects.algebra,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a7,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.geometry,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a7,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a7,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a7,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b7,
                    Subject = subjects.algebra,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b7,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.geometry,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.music,
                    Teacher = teachers.zviahelskyi
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.finearts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b7,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b7,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b7,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.algebra,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a8,
                    Subject = subjects.english,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.geometry,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a8,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a8,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a8,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.algebra,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b8,
                    Subject = subjects.english,
                    Teacher = teachers.vasylieva
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.geometry,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b8,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b8,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b8,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.algebra,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a9,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.geometry,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.jurisprudence,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a9,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a9,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a9,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a9,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.algebra,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b9,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.geometry,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.health,
                    Teacher = teachers.moskalenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.jurisprudence,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.crafts,
                    Teacher = teachers.honcharuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b9,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b9,
                    Subject = subjects.pt,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b9,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b9,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.algebra,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.geometry,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.civileduc,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.it,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.kyrylusha
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a10,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a10,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a10,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a10,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.algebra,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.whistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.geometry,
                    Teacher = teachers.shulga
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.civileduc,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.verbova_nv
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b10,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b10,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b10,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b10,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.algebra,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.astronomy,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.biology,
                    Teacher = teachers.boyarska
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.geometry,
                    Teacher = teachers.smychnikova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.civildef,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.it,
                    Teacher = teachers.kyrianov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.havro
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a11,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.a11,
                    Subject = subjects.pt,
                    Teacher = teachers.melnychuk
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.a11,
                    Subject = subjects.french,
                    Teacher = teachers.kurach
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.a11,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.algebra,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.english,
                    Teacher = teachers.lisichkina
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.astronomy,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.biology,
                    Teacher = teachers.dybka
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.geography,
                    Teacher = teachers.ponomarenko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.geometry,
                    Teacher = teachers.manko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.wliterature,
                    Teacher = teachers.synko
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.civildef,
                    Teacher = teachers.tverdokhlibova
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.it,
                    Teacher = teachers.shafran
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.uhistory,
                    Teacher = teachers.bulachok
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.arts,
                    Teacher = teachers.kholodiuk
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.ukrlit,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.ukrainian,
                    Teacher = teachers.symonenko_op
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b11,
                    Subject = subjects.physics,
                    Teacher = teachers.verbova_vo
                },
                new Curriculum
                {
                    Quantity = 3,
                    Grade = grades.b11,
                    Subject = subjects.pt,
                    Teacher = teachers.slavov
                },
                new Curriculum
                {
                    Quantity = 1,
                    Grade = grades.b11,
                    Subject = subjects.french,
                    Teacher = teachers.martynenko
                },
                new Curriculum
                {
                    Quantity = 2,
                    Grade = grades.b11,
                    Subject = subjects.chemistry,
                    Teacher = teachers.shevchenko
                }
            };
            #endregion
        }
    }
}

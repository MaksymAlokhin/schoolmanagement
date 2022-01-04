using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedLesson
    {
        public List<Lesson> data;
        SeedGrade grades;
        SeedSubject subjects;
        SeedTeacher teachers;
        public SeedLesson(SeedGrade _grades, SeedSubject _subjects, SeedTeacher _teachers)
        {
            grades = _grades;
            subjects = _subjects;
            teachers = _teachers;
            CreateLessons();
        }
        void CreateLessons()
        {
            #region Create lessons
            data = new List<Lesson>
            {
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.finearts,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.finearts,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.finearts,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.litreading,
                        Teacher = teachers.lonska
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.finearts,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.iexplore,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.design,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.design,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.iexplore,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.finearts,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.iexplore,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 3,
                        Slot = 7,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 4,
                        Slot = 7,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 2,
                        Slot = 7,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 3,
                        Slot = 7,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 7,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 7,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.finearts,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.iexplore,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.iexplore,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.iexplore,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.nature,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.nature,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.nature,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.nature,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "109",
                        Grade = grades.a3,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "105",
                        Grade = grades.a1,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "106",
                        Grade = grades.b1,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "108",
                        Grade = grades.b2,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "111",
                        Grade = grades.a4,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 5,
                        Slot = 6,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 2,
                        Slot = 6,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 1,
                        Slot = 6,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "112",
                        Grade = grades.b4,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 4,
                        Slot = 6,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 2,
                        Slot = 5,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 5,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 5,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 1,
                        Slot = 5,
                        Room = "305",
                        Grade = grades.a9,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 5,
                        Slot = 5,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 5,
                        Slot = 4,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "107",
                        Grade = grades.a2,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "308",
                        Grade = grades.b10,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "207",
                        Grade = grades.a6,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 3,
                        Slot = 6,
                        Room = "307",
                        Grade = grades.a10,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "212",
                        Grade = grades.b8,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "209",
                        Grade = grades.a7,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "310",
                        Grade = grades.b11,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Lesson {
                    Day = 2,
                        Slot = 4,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 4,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 4,
                        Slot = 3,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 3,
                        Slot = 4,
                        Room = "206",
                        Grade = grades.b5,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 4,
                        Slot = 4,
                        Room = "110",
                        Grade = grades.b3,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Lesson {
                    Day = 1,
                        Slot = 1,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 2,
                        Slot = 1,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 3,
                        Slot = 1,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 4,
                        Slot = 1,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 5,
                        Slot = 1,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 1,
                        Slot = 2,
                        Room = "309",
                        Grade = grades.a11,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 2,
                        Slot = 2,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 3,
                        Slot = 2,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 4,
                        Slot = 2,
                        Room = "208",
                        Grade = grades.b6,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 5,
                        Slot = 2,
                        Room = "205",
                        Grade = grades.a5,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 1,
                        Slot = 3,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 2,
                        Slot = 3,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 3,
                        Slot = 3,
                        Room = "306",
                        Grade = grades.b9,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 5,
                        Slot = 3,
                        Room = "211",
                        Grade = grades.a8,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Lesson {
                    Day = 1,
                        Slot = 7,
                        Room = "210",
                        Grade = grades.b7,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                }
            };
            #endregion
        }
    }
}
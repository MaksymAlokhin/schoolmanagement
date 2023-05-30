using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedGradebook
    {
        public List<Gradebook> data;
        SeedStudent students;
        SeedSubject subjects;
        SeedTeacher teachers;
        public SeedGradebook(SeedStudent _students, SeedSubject _subjects, SeedTeacher _teachers)
        {
            students = _students;
            subjects = _subjects;
            teachers = _teachers;
            CreateGradebooks();
        }
        void CreateGradebooks()
        {
            #region Create gradebooks
            data = new List<Gradebook>
            {
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "4",
                        Student = students.s001,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "10",
                        Student = students.s001,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s001,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "8",
                        Student = students.s001,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "9",
                        Student = students.s001,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s001,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "8",
                        Student = students.s001,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "12",
                        Student = students.s001,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "6",
                        Student = students.s001,
                        Subject = subjects.finearts,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "12",
                        Student = students.s001,
                        Subject = subjects.finearts,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s001,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s001,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "10",
                        Student = students.s001,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "12",
                        Student = students.s001,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s001,
                        Subject = subjects.iexplore,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "4",
                        Student = students.s001,
                        Subject = subjects.iexplore,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "7",
                        Student = students.s001,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "9",
                        Student = students.s001,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s001,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.bondarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "5",
                        Student = students.s099,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s010,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "5",
                        Student = students.s099,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s010,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "7",
                        Student = students.s099,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "6",
                        Student = students.s008,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "8",
                        Student = students.s011,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s009,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "4",
                        Student = students.s008,
                        Subject = subjects.finearts,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s010,
                        Subject = subjects.finearts,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "11",
                        Student = students.s011,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s010,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "4",
                        Student = students.s099,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "8",
                        Student = students.s009,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s099,
                        Subject = subjects.iexplore,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s008,
                        Subject = subjects.iexplore,
                        Teacher = teachers.vlasiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "8",
                        Student = students.s015,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s017,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s015,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "6",
                        Student = students.s018,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "7",
                        Student = students.s016,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s018,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "3",
                        Student = students.s016,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s013,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s015,
                        Subject = subjects.finearts,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "10",
                        Student = students.s013,
                        Subject = subjects.finearts,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s015,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "8",
                        Student = students.s013,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s016,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s018,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s016,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s013,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s016,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s018,
                        Subject = subjects.reading,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "5",
                        Student = students.s016,
                        Subject = subjects.iexplore,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "12",
                        Student = students.s013,
                        Subject = subjects.iexplore,
                        Teacher = teachers.horlova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s020,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "5",
                        Student = students.s022,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s021,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "11",
                        Student = students.s023,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s020,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s022,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s020,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s022,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s021,
                        Subject = subjects.finearts,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "11",
                        Student = students.s022,
                        Subject = subjects.finearts,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "7",
                        Student = students.s020,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "5",
                        Student = students.s023,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "10",
                        Student = students.s021,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s020,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s020,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "4",
                        Student = students.s023,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s020,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "11",
                        Student = students.s022,
                        Subject = subjects.reading,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s021,
                        Subject = subjects.iexplore,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s023,
                        Subject = subjects.iexplore,
                        Teacher = teachers.yeroshkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s026,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "12",
                        Student = students.s028,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "8",
                        Student = students.s026,
                        Subject = subjects.design,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s028,
                        Subject = subjects.design,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "5",
                        Student = students.s028,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "11",
                        Student = students.s026,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s026,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s028,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s029,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "10",
                        Student = students.s026,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s026,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s029,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s026,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s027,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "11",
                        Student = students.s026,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "6",
                        Student = students.s027,
                        Subject = subjects.reading,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s029,
                        Subject = subjects.iexplore,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "12",
                        Student = students.s026,
                        Subject = subjects.iexplore,
                        Teacher = teachers.zadorozhnia
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "8",
                        Student = students.s032,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s034,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s033,
                        Subject = subjects.design,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "10",
                        Student = students.s035,
                        Subject = subjects.design,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s032,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "5",
                        Student = students.s033,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "5",
                        Student = students.s032,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s035,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "5",
                        Student = students.s032,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s035,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "5",
                        Student = students.s032,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s033,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s032,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s034,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "5",
                        Student = students.s032,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "9",
                        Student = students.s035,
                        Subject = subjects.reading,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s033,
                        Subject = subjects.iexplore,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "11",
                        Student = students.s035,
                        Subject = subjects.iexplore,
                        Teacher = teachers.hnots
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s038,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "5",
                        Student = students.s042,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s038,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "6",
                        Student = students.s042,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "8",
                        Student = students.s038,
                        Subject = subjects.litreading,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s042,
                        Subject = subjects.litreading,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s039,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "11",
                        Student = students.s040,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "4",
                        Student = students.s038,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s040,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "5",
                        Student = students.s038,
                        Subject = subjects.finearts,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "9",
                        Student = students.s040,
                        Subject = subjects.finearts,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s038,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "10",
                        Student = students.s040,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "5",
                        Student = students.s039,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s040,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s038,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "8",
                        Student = students.s040,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "5",
                        Student = students.s038,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s039,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lavrychenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s038,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "12",
                        Student = students.s042,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s047,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s043,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s047,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "7",
                        Student = students.s044,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s048,
                        Subject = subjects.litreading,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s044,
                        Subject = subjects.litreading,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s048,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "4",
                        Student = students.s044,
                        Subject = subjects.maths_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s048,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "12",
                        Student = students.s045,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s047,
                        Subject = subjects.finearts,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s044,
                        Subject = subjects.finearts,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "7",
                        Student = students.s048,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s045,
                        Subject = subjects.health_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "7",
                        Student = students.s048,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s043,
                        Subject = subjects.nature_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s043,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "10",
                        Student = students.s045,
                        Subject = subjects.crafts_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s048,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "10",
                        Student = students.s044,
                        Subject = subjects.ukrainian_primary,
                        Teacher = teachers.lonska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "5",
                        Student = students.s048,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "10",
                        Student = students.s044,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s050,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s052,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s050,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "8",
                        Student = students.s053,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "5",
                        Student = students.s050,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "9",
                        Student = students.s053,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "7",
                        Student = students.s050,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "9",
                        Student = students.s053,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s051,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s050,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "5",
                        Student = students.s050,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "11",
                        Student = students.s053,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "8",
                        Student = students.s051,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "11",
                        Student = students.s053,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s050,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "9",
                        Student = students.s053,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "5",
                        Student = students.s050,
                        Subject = subjects.nature,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s052,
                        Subject = subjects.nature,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "3",
                        Student = students.s050,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s054,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s051,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s049,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s050,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "10",
                        Student = students.s053,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "5",
                        Student = students.s050,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s052,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s051,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "10",
                        Student = students.s053,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "7",
                        Student = students.s055,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s058,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s056,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "9",
                        Student = students.s059,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "5",
                        Student = students.s056,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "9",
                        Student = students.s060,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s056,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "7",
                        Student = students.s059,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s056,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s059,
                        Subject = subjects.maths,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "4",
                        Student = students.s058,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "9",
                        Student = students.s056,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "5",
                        Student = students.s056,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "10",
                        Student = students.s059,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s056,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "8",
                        Student = students.s058,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s057,
                        Subject = subjects.nature,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "11",
                        Student = students.s060,
                        Subject = subjects.nature,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "4",
                        Student = students.s056,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s059,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "8",
                        Student = students.s056,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s058,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s056,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s059,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "4",
                        Student = students.s056,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s058,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "5",
                        Student = students.s056,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s059,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "5",
                        Student = students.s063,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s061,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "5",
                        Student = students.s064,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "8",
                        Student = students.s062,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "8",
                        Student = students.s061,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s062,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s063,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "11",
                        Student = students.s062,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s064,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "11",
                        Student = students.s065,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "5",
                        Student = students.s064,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "11",
                        Student = students.s065,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "6",
                        Student = students.s064,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s062,
                        Subject = subjects.maths,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "4",
                        Student = students.s064,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "10",
                        Student = students.s065,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s064,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s062,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "6",
                        Student = students.s064,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "10",
                        Student = students.s065,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s065,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s061,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s064,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "8",
                        Student = students.s065,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "11",
                        Student = students.s064,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s062,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "10",
                        Student = students.s061,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s064,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "5",
                        Student = students.s061,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s066,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s083,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s070,
                        Subject = subjects.english,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "5",
                        Student = students.s083,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s070,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "3",
                        Student = students.s070,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "11",
                        Student = students.s083,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s083,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s070,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "6",
                        Student = students.s083,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "4",
                        Student = students.s071,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s083,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "9",
                        Student = students.s071,
                        Subject = subjects.history,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "5",
                        Student = students.s083,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "8",
                        Student = students.s071,
                        Subject = subjects.maths,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s069,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "5",
                        Student = students.s067,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "4",
                        Student = students.s083,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s071,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "5",
                        Student = students.s083,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "11",
                        Student = students.s070,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "5",
                        Student = students.s083,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "11",
                        Student = students.s070,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s069,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "10",
                        Student = students.s070,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s070,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "6",
                        Student = students.s083,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s083,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s070,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "6",
                        Student = students.s083,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "10",
                        Student = students.s070,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "4",
                        Student = students.s078,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s076,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s073,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "6",
                        Student = students.s075,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "6",
                        Student = students.s075,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s073,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "4",
                        Student = students.s078,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s075,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "9",
                        Student = students.s074,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "4",
                        Student = students.s073,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "5",
                        Student = students.s073,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s076,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s073,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s074,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "6",
                        Student = students.s073,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "11",
                        Student = students.s075,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s074,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s077,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "10",
                        Student = students.s073,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "6",
                        Student = students.s074,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s073,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "9",
                        Student = students.s076,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "7",
                        Student = students.s074,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "5",
                        Student = students.s073,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s076,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s073,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s078,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "5",
                        Student = students.s076,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "6",
                        Student = students.s074,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "11",
                        Student = students.s073,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s073,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "10",
                        Student = students.s076,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s073,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "11",
                        Student = students.s076,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s073,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "7",
                        Student = students.s075,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s073,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "8",
                        Student = students.s074,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s079,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s068,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "7",
                        Student = students.s080,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "11",
                        Student = students.s081,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s080,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "7",
                        Student = students.s081,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s080,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s068,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s080,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "10",
                        Student = students.s081,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s080,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "9",
                        Student = students.s082,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s080,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "9",
                        Student = students.s082,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "9",
                        Student = students.s081,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s082,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "9",
                        Student = students.s081,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 29),
                        Mark = "4",
                        Student = students.s079,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "6",
                        Student = students.s084,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s080,
                        Subject = subjects.music,
                        Teacher = teachers.zviahelskyi
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "9",
                        Student = students.s080,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "8",
                        Student = students.s082,
                        Subject = subjects.finearts_primary,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "4",
                        Student = students.s080,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "11",
                        Student = students.s084,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s080,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "6",
                        Student = students.s082,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "7",
                        Student = students.s080,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "11",
                        Student = students.s082,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s080,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "8",
                        Student = students.s082,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s080,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s081,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "9",
                        Student = students.s080,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "5",
                        Student = students.s082,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "10",
                        Student = students.s080,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "9",
                        Student = students.s081,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "12",
                        Student = students.s081,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s080,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s085,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s087,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s086,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "4",
                        Student = students.s088,
                        Subject = subjects.english,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "8",
                        Student = students.s087,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "4",
                        Student = students.s088,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "8",
                        Student = students.s086,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "9",
                        Student = students.s088,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "8",
                        Student = students.s086,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "5",
                        Student = students.s089,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s086,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s087,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "5",
                        Student = students.s086,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "11",
                        Student = students.s089,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s086,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s088,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "6",
                        Student = students.s087,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "10",
                        Student = students.s089,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "7",
                        Student = students.s085,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "10",
                        Student = students.s088,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "6",
                        Student = students.s086,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "10",
                        Student = students.s088,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s086,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "5",
                        Student = students.s088,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s086,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "4",
                        Student = students.s088,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s087,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "10",
                        Student = students.s089,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "8",
                        Student = students.s087,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "5",
                        Student = students.s086,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s086,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s089,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "7",
                        Student = students.s087,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "12",
                        Student = students.s086,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s086,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "11",
                        Student = students.s089,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "7",
                        Student = students.s091,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "8",
                        Student = students.s095,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s092,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s093,
                        Subject = subjects.english,
                        Teacher = teachers.vasylieva
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "4",
                        Student = students.s092,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s095,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "3",
                        Student = students.s092,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "12",
                        Student = students.s095,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "4",
                        Student = students.s092,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "10",
                        Student = students.s095,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s092,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "4",
                        Student = students.s094,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s093,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s094,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s092,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "4",
                        Student = students.s093,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "8",
                        Student = students.s093,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "4",
                        Student = students.s092,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s092,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s095,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "12",
                        Student = students.s092,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s095,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s092,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "9",
                        Student = students.s094,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s091,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "11",
                        Student = students.s093,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "8",
                        Student = students.s092,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "4",
                        Student = students.s094,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s093,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s092,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s092,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "6",
                        Student = students.s095,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "10",
                        Student = students.s092,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s093,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "9",
                        Student = students.s092,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "4",
                        Student = students.s095,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s097,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "7",
                        Student = students.s098,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s007,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "5",
                        Student = students.s100,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "11",
                        Student = students.s098,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s098,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "10",
                        Student = students.s100,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "7",
                        Student = students.s097,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "5",
                        Student = students.s101,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "7",
                        Student = students.s098,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s100,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "3",
                        Student = students.s098,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s102,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "4",
                        Student = students.s097,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "10",
                        Student = students.s100,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s098,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s007,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s098,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "5",
                        Student = students.s100,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "7",
                        Student = students.s098,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s101,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "5",
                        Student = students.s098,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "10",
                        Student = students.s100,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "4",
                        Student = students.s100,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "11",
                        Student = students.s098,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "10",
                        Student = students.s007,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s098,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "9",
                        Student = students.s098,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "5",
                        Student = students.s101,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "12",
                        Student = students.s098,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s101,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "11",
                        Student = students.s007,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "5",
                        Student = students.s102,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "8",
                        Student = students.s100,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s098,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "12",
                        Student = students.s098,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "9",
                        Student = students.s104,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "9",
                        Student = students.s107,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s107,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s104,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s104,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "8",
                        Student = students.s106,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "11",
                        Student = students.s107,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s104,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s104,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "6",
                        Student = students.s105,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "9",
                        Student = students.s104,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "4",
                        Student = students.s106,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "4",
                        Student = students.s104,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s105,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s104,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "6",
                        Student = students.s105,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s104,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "6",
                        Student = students.s105,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s104,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "11",
                        Student = students.s106,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s104,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "11",
                        Student = students.s106,
                        Subject = subjects.health,
                        Teacher = teachers.moskalenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s104,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "6",
                        Student = students.s107,
                        Subject = subjects.jurisprudence,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "8",
                        Student = students.s106,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s104,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s104,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s105,
                        Subject = subjects.crafts,
                        Teacher = teachers.honcharuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "10",
                        Student = students.s104,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "8",
                        Student = students.s107,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s107,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "12",
                        Student = students.s104,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "10",
                        Student = students.s104,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s106,
                        Subject = subjects.pt,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s107,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "11",
                        Student = students.s104,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "9",
                        Student = students.s104,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "4",
                        Student = students.s105,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s112,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "10",
                        Student = students.s109,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s111,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s114,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s112,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "11",
                        Student = students.s109,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s112,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s114,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "6",
                        Student = students.s112,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s109,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s111,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "11",
                        Student = students.s114,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s112,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "11",
                        Student = students.s114,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "6",
                        Student = students.s112,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "7",
                        Student = students.s109,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "10",
                        Student = students.s113,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s112,
                        Subject = subjects.it,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "8",
                        Student = students.s114,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s110,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s112,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s109,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "10",
                        Student = students.s113,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "5",
                        Student = students.s109,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "10",
                        Student = students.s113,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s114,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.kyrylusha
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "10",
                        Student = students.s111,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s114,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "10",
                        Student = students.s112,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "5",
                        Student = students.s109,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "10",
                        Student = students.s112,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s113,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "11",
                        Student = students.s112,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "12",
                        Student = students.s113,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 27),
                        Mark = "9",
                        Student = students.s116,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "10",
                        Student = students.s117,
                        Subject = subjects.algebra,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "8",
                        Student = students.s118,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "3",
                        Student = students.s115,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "10",
                        Student = students.s116,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "11",
                        Student = students.s117,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s116,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "5",
                        Student = students.s118,
                        Subject = subjects.whistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "9",
                        Student = students.s116,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "4",
                        Student = students.s119,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "9",
                        Student = students.s115,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s117,
                        Subject = subjects.geometry,
                        Teacher = teachers.shulga
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s117,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "6",
                        Student = students.s116,
                        Subject = subjects.civileduc,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "8",
                        Student = students.s116,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "9",
                        Student = students.s118,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s115,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "11",
                        Student = students.s118,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s115,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "11",
                        Student = students.s118,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "5",
                        Student = students.s116,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "11",
                        Student = students.s119,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "8",
                        Student = students.s116,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s118,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s116,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "12",
                        Student = students.s119,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.verbova_nv
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s116,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "11",
                        Student = students.s118,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s116,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "9",
                        Student = students.s119,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "10",
                        Student = students.s116,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "6",
                        Student = students.s118,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s117,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s119,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "8",
                        Student = students.s121,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "10",
                        Student = students.s123,
                        Subject = subjects.algebra,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s121,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s124,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "11",
                        Student = students.s121,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "7",
                        Student = students.s122,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "8",
                        Student = students.s122,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "4",
                        Student = students.s121,
                        Subject = subjects.biology,
                        Teacher = teachers.boyarska
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "8",
                        Student = students.s126,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "10",
                        Student = students.s123,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "10",
                        Student = students.s121,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "8",
                        Student = students.s122,
                        Subject = subjects.geometry,
                        Teacher = teachers.smychnikova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "8",
                        Student = students.s121,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "6",
                        Student = students.s124,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "9",
                        Student = students.s121,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "5",
                        Student = students.s123,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s121,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s123,
                        Subject = subjects.it,
                        Teacher = teachers.kyrianov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "7",
                        Student = students.s121,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "7",
                        Student = students.s123,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "9",
                        Student = students.s122,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "9",
                        Student = students.s123,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s126,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "4",
                        Student = students.s122,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 29),
                        Mark = "9",
                        Student = students.s123,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "7",
                        Student = students.s121,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.havro
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "9",
                        Student = students.s122,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "6",
                        Student = students.s121,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "8",
                        Student = students.s121,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "6",
                        Student = students.s124,
                        Subject = subjects.pt,
                        Teacher = teachers.melnychuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "8",
                        Student = students.s121,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "12",
                        Student = students.s124,
                        Subject = subjects.french,
                        Teacher = teachers.kurach
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "9",
                        Student = students.s121,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "8",
                        Student = students.s123,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "8",
                        Student = students.s128,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "11",
                        Student = students.s129,
                        Subject = subjects.algebra,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s129,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "11",
                        Student = students.s131,
                        Subject = subjects.english,
                        Teacher = teachers.lisichkina
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 28),
                        Mark = "7",
                        Student = students.s128,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "6",
                        Student = students.s130,
                        Subject = subjects.astronomy,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "12",
                        Student = students.s129,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 17),
                        Mark = "4",
                        Student = students.s128,
                        Subject = subjects.biology,
                        Teacher = teachers.dybka
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "8",
                        Student = students.s128,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 22),
                        Mark = "6",
                        Student = students.s131,
                        Subject = subjects.geography,
                        Teacher = teachers.ponomarenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "7",
                        Student = students.s128,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s132,
                        Subject = subjects.geometry,
                        Teacher = teachers.manko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "7",
                        Student = students.s127,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 16),
                        Mark = "6",
                        Student = students.s129,
                        Subject = subjects.wliterature,
                        Teacher = teachers.synko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 20),
                        Mark = "6",
                        Student = students.s127,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "9",
                        Student = students.s131,
                        Subject = subjects.civildef,
                        Teacher = teachers.tverdokhlibova
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 23),
                        Mark = "11",
                        Student = students.s129,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "5",
                        Student = students.s127,
                        Subject = subjects.it,
                        Teacher = teachers.shafran
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 24),
                        Mark = "7",
                        Student = students.s127,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "10",
                        Student = students.s130,
                        Subject = subjects.uhistory,
                        Teacher = teachers.bulachok
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s127,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 15),
                        Mark = "10",
                        Student = students.s129,
                        Subject = subjects.arts,
                        Teacher = teachers.kholodiuk
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 1),
                        Mark = "8",
                        Student = students.s129,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 9),
                        Mark = "11",
                        Student = students.s131,
                        Subject = subjects.ukrlit,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 6),
                        Mark = "10",
                        Student = students.s128,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 13),
                        Mark = "6",
                        Student = students.s130,
                        Subject = subjects.ukrainian,
                        Teacher = teachers.symonenko_op
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 10),
                        Mark = "8",
                        Student = students.s129,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 3),
                        Mark = "8",
                        Student = students.s128,
                        Subject = subjects.physics,
                        Teacher = teachers.verbova_vo
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 8),
                        Mark = "6",
                        Student = students.s129,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 2),
                        Mark = "10",
                        Student = students.s131,
                        Subject = subjects.pt,
                        Teacher = teachers.slavov
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 21),
                        Mark = "12",
                        Student = students.s128,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "7",
                        Student = students.s127,
                        Subject = subjects.french,
                        Teacher = teachers.martynenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 14),
                        Mark = "9",
                        Student = students.s128,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                },
                new Gradebook
                {
                    LessonDate = new DateTime(2023, 9, 7),
                        Mark = "3",
                        Student = students.s129,
                        Subject = subjects.chemistry,
                        Teacher = teachers.shevchenko
                }
            };
            #endregion
        }
    }
}

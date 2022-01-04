using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedGrade
    {
        public List<Grade> data;
        SeedStudent students;
        #region Grade declarations
        public Grade a1;
        public Grade b1;
        public Grade a2;
        public Grade b2;
        public Grade a3;
        public Grade b3;
        public Grade a4;
        public Grade b4;
        public Grade a5;
        public Grade b5;
        public Grade a6;
        public Grade b6;
        public Grade a7;
        public Grade b7;
        public Grade a8;
        public Grade b8;
        public Grade a9;
        public Grade b9;
        public Grade a10;
        public Grade b10;
        public Grade a11;
        public Grade b11;
        #endregion

        public SeedGrade(SeedStudent _students)
        {
            students = _students;
            CreateGrades();
        }
        void CreateGrades()
        {
            #region Create grades
            a1 = new Grade
            {
                Number = 1,
                Letter = "А",
                Room = "105",
                Students = new List<Student>
                {
                    students.s001, students.s002, students.s003, students.s004, students.s005, students.s006
                }
            };
            b1 = new Grade
            {
                Number = 1,
                Letter = "Б",
                Room = "106",
                Students = new List<Student>
                {
                    students.s007, students.s008, students.s009, students.s010, students.s011, students.s012
                }
            };
            a2 = new Grade
            {
                Number = 2,
                Letter = "А",
                Room = "107",
                Students = new List<Student>
                {
                    students.s013, students.s014, students.s015, students.s016, students.s017, students.s018
                }
            };
            b2 = new Grade
            {
                Number = 2,
                Letter = "Б",
                Room = "108",
                Students = new List<Student>
                {
                    students.s019, students.s020, students.s021, students.s022, students.s023, students.s024
                }
            };
            a3 = new Grade
            {
                Number = 3,
                Letter = "А",
                Room = "109",
                Students = new List<Student>
                {
                    students.s025, students.s026, students.s027, students.s028, students.s029, students.s030
                }
            };
            b3 = new Grade
            {
                Number = 3,
                Letter = "Б",
                Room = "110",
                Students = new List<Student>
                {
                    students.s031, students.s032, students.s033, students.s034, students.s035, students.s036
                }
            };
            a4 = new Grade
            {
                Number = 4,
                Letter = "А",
                Room = "111",
                Students = new List<Student>
                {
                    students.s037, students.s038, students.s039, students.s040, students.s041, students.s042
                }
            };
            b4 = new Grade
            {
                Number = 4,
                Letter = "Б",
                Room = "112",
                Students = new List<Student>
                {
                    students.s043, students.s044, students.s045, students.s046, students.s047, students.s048
                }
            };
            a5 = new Grade
            {
                Number = 5,
                Letter = "А",
                Room = "205",
                Students = new List<Student>
                {
                    students.s049, students.s050, students.s051, students.s052, students.s053, students.s054
                }
            };
            b5 = new Grade
            {
                Number = 5,
                Letter = "Б",
                Room = "206",
                Students = new List<Student>
                {
                    students.s055, students.s056, students.s057, students.s058, students.s059, students.s060
                }
            };
            a6 = new Grade
            {
                Number = 6,
                Letter = "А",
                Room = "207",
                Students = new List<Student>
                {
                    students.s061, students.s062, students.s063, students.s064, students.s065, students.s066
                }
            };
            b6 = new Grade
            {
                Number = 6,
                Letter = "Б",
                Room = "208",
                Students = new List<Student>
                {
                    students.s067, students.s068, students.s069, students.s070, students.s071, students.s072
                }
            };
            a7 = new Grade
            {
                Number = 7,
                Letter = "А",
                Room = "209",
                Students = new List<Student>
                {
                    students.s073, students.s074, students.s075, students.s076, students.s077, students.s078
                }
            };
            b7 = new Grade
            {
                Number = 7,
                Letter = "Б",
                Room = "210",
                Students = new List<Student>
                {
                    students.s079, students.s080, students.s081, students.s082, students.s083, students.s084
                }
            };
            a8 = new Grade
            {
                Number = 8,
                Letter = "А",
                Room = "211",
                Students = new List<Student>
                {
                    students.s085, students.s086, students.s087, students.s088, students.s089, students.s090
                }
            };
            b8 = new Grade
            {
                Number = 8,
                Letter = "Б",
                Room = "212",
                Students = new List<Student>
                {
                    students.s091, students.s092, students.s093, students.s094, students.s095, students.s096
                }
            };
            a9 = new Grade
            {
                Number = 9,
                Letter = "А",
                Room = "305",
                Students = new List<Student>
                {
                    students.s097, students.s098, students.s099, students.s100, students.s101, students.s102
                }
            };
            b9 = new Grade
            {
                Number = 9,
                Letter = "Б",
                Room = "306",
                Students = new List<Student>
                {
                    students.s103, students.s104, students.s105, students.s106, students.s107, students.s108
                }
            };
            a10 = new Grade
            {
                Number = 10,
                Letter = "А",
                Room = "307",
                Students = new List<Student>
                {
                    students.s109, students.s110, students.s111, students.s112, students.s113, students.s114
                }
            };
            b10 = new Grade
            {
                Number = 10,
                Letter = "Б",
                Room = "308",
                Students = new List<Student>
                {
                    students.s115, students.s116, students.s117, students.s118, students.s119, students.s120
                }
            };
            a11 = new Grade
            {
                Number = 11,
                Letter = "А",
                Room = "309",
                Students = new List<Student>
                {
                    students.s121, students.s122, students.s123, students.s124, students.s125, students.s126
                }
            };
            b11 = new Grade
            {
                Number = 11,
                Letter = "Б",
                Room = "310",
                Students = new List<Student>
                {
                    students.s127, students.s128, students.s129, students.s130, students.s131, students.s132
                }
            };
            #endregion
            #region Add grades
            data = new List<Grade>();
            data.Add(a1);
            data.Add(b1);
            data.Add(a2);
            data.Add(b2);
            data.Add(a3);
            data.Add(b3);
            data.Add(a4);
            data.Add(b4);
            data.Add(a5);
            data.Add(b5);
            data.Add(a6);
            data.Add(b6);
            data.Add(a7);
            data.Add(b7);
            data.Add(a8);
            data.Add(b8);
            data.Add(a9);
            data.Add(b9);
            data.Add(a10);
            data.Add(b10);
            data.Add(a11);
            data.Add(b11);
            #endregion
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using static sms.Data.StudentsSeedData;

namespace sms.Data
{
    public static class GradesSeedData
    {
        #region Create grades
        public static Grade a1 = new Grade 
        { 
            Number = 1, 
            Letter = "А",
            Students = new List<Student> { s001, s002, s003, s004, s005, s006 }
        };
        public static Grade b1 = new Grade 
        { 
            Number = 1, 
            Letter = "Б",
            Students = new List<Student> { s007, s008, s009, s010, s011, s012 }
        };
        public static Grade a2 = new Grade 
        { 
            Number = 2, 
            Letter = "А",
            Students = new List<Student> { s013, s014, s015, s016, s017, s018 }
        };
        public static Grade b2 = new Grade 
        { 
            Number = 2, 
            Letter = "Б",
            Students = new List<Student> { s019, s020, s021, s022, s023, s024 }
        };
        public static Grade a3 = new Grade 
        { 
            Number = 3, 
            Letter = "А",
            Students = new List<Student> { s025, s026, s027, s028, s029, s030 }
        };
        public static Grade b3 = new Grade 
        { 
            Number = 3, 
            Letter = "Б",
            Students = new List<Student> { s031, s032, s033, s034, s035, s036 }
        };
        public static Grade a4 = new Grade 
        { 
            Number = 4, 
            Letter = "А",
            Students = new List<Student> { s037, s038, s039, s040, s041, s042 }
        };
        public static Grade b4 = new Grade 
        { 
            Number = 4, 
            Letter = "Б",
            Students = new List<Student> { s043, s044, s045, s046, s047, s048 }
        };
        public static Grade a5 = new Grade 
        { 
            Number = 5, 
            Letter = "А",
            Students = new List<Student> { s049, s050, s051, s052, s053, s054 }
        };
        public static Grade b5 = new Grade 
        { 
            Number = 5, 
            Letter = "Б",
            Students = new List<Student> { s055, s056, s057, s058, s059, s060 }
        };
        public static Grade a6 = new Grade 
        { 
            Number = 6, 
            Letter = "А",
            Students = new List<Student> { s061, s062, s063, s064, s065, s066 }
        };
        public static Grade b6 = new Grade 
        { 
            Number = 6, 
            Letter = "Б",
            Students = new List<Student> { s067, s068, s069, s070, s071, s072 }
        };
        public static Grade a7 = new Grade 
        { 
            Number = 7, 
            Letter = "А",
            Students = new List<Student> { s073, s074, s075, s076, s077, s078 }
        };
        public static Grade b7 = new Grade 
        { 
            Number = 7, 
            Letter = "Б",
            Students = new List<Student> { s079, s080, s081, s082, s083, s084 }
        };
        public static Grade a8 = new Grade 
        { 
            Number = 8, 
            Letter = "А",
            Students = new List<Student> { s085, s086, s087, s088, s089, s090 }
        };
        public static Grade b8 = new Grade 
        { 
            Number = 8, 
            Letter = "Б",
            Students = new List<Student> { s091, s092, s093, s094, s095, s096 }
        };
        public static Grade a9 = new Grade 
        { 
            Number = 9, 
            Letter = "А",
            Students = new List<Student> { s097, s098, s099, s100, s101, s102 }
        };
        public static Grade b9 = new Grade 
        { 
            Number = 9, 
            Letter = "Б",
            Students = new List<Student> { s103, s104, s105, s106, s107, s108 }
        };
        public static Grade a10 = new Grade 
        { 
            Number = 10, 
            Letter = "А",
            Students = new List<Student> { s109, s110, s111, s112, s113, s114 }
        };
        public static Grade b10 = new Grade 
        { 
            Number = 10, 
            Letter = "Б",
            Students = new List<Student> { s115, s116, s117, s118, s119, s120 }
        };
        public static Grade a11 = new Grade 
        { 
            Number = 11, 
            Letter = "А",
            Students = new List<Student> { s121, s122, s123, s124, s125, s126 }
        };
        public static Grade b11 = new Grade 
        { 
            Number = 11, 
            Letter = "Б",
            Students = new List<Student> { s127, s128, s129, s130, s131, s132 }
        };
        #endregion
        public static List<Grade> data;
        static GradesSeedData()
        {
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
        }
    }
}
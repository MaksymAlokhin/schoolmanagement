using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    //slot is single block of timetable
    //Слот це найменша одиниця розкладу
    public class Slot
    {
        public int GradeId;
        public int SubjectId;
        public int TeacherId;
        public Slot (int gradeId, int subjectId, int teacherId)
        {
            GradeId = gradeId;
            SubjectId = subjectId;
            TeacherId = teacherId;
        }
        public Slot() { }
    }
}

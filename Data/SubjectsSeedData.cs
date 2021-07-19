using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public static class SubjectsSeedData
    {
        #region Create teachers
        public static Subject biology = new Subject { Name = "Біологія" };
        public static Subject nature = new Subject { Name = "Природознавство" };
        public static Subject geography = new Subject { Name = "Географія" };
        public static Subject chemistry = new Subject { Name = "Хімія" };
        public static Subject physics = new Subject { Name = "Фізика" };
        public static Subject history = new Subject { Name = "Історія" };
        public static Subject whistory = new Subject { Name = "Всесвітня Історія" };
        public static Subject uhistory = new Subject { Name = "Історія України" };
        public static Subject jurisprudence = new Subject { Name = "Правознавство" };
        public static Subject maths = new Subject { Name = "Математика" };
        public static Subject algebra = new Subject { Name = "Алгебра" };
        public static Subject geometry = new Subject { Name = "Геометрія" };
        public static Subject it = new Subject { Name = "Інформатика" };
        public static Subject arts = new Subject { Name = "Образотворче мистецтво" };
        public static Subject music = new Subject { Name = "Музичне мистецтво" };
        public static Subject english = new Subject { Name = "Англійська мова" };
        public static Subject french = new Subject { Name = "Французька мова" };
        public static Subject ukrainian = new Subject { Name = "Українська мова" };
        public static Subject ukrlit = new Subject { Name = "Українська література" };
        public static Subject wliterature = new Subject { Name = "Зарубіжна література" };
        public static Subject pt = new Subject { Name = "Фізична культура" };
        public static Subject primary = new Subject { Name = "Початкові класи" };
        #endregion
        public static List<Subject> data;
        static SubjectsSeedData()
        {
            data = new List<Subject>();
            data.Add(biology);
            data.Add(geography);
            data.Add(chemistry);
            data.Add(physics);
            data.Add(history);
            data.Add(whistory);
            data.Add(uhistory);
            data.Add(jurisprudence);
            data.Add(maths);
            data.Add(algebra);
            data.Add(geometry);
            data.Add(it);
            data.Add(arts);
            data.Add(music);
            data.Add(english);
            data.Add(french);
            data.Add(ukrainian);
            data.Add(ukrlit);
            data.Add(wliterature);
            data.Add(pt);
            data.Add(primary);
        }
    }
}

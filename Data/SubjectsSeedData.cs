using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public static class SubjectsSeedData
    {
        #region Create subjects
        public static Subject biology = new Subject { Name = "Біологія" };
        public static Subject nature = new Subject { Name = "Природознавство" };
        public static Subject geography = new Subject { Name = "Географія" };
        public static Subject chemistry = new Subject { Name = "Хімія" };
        public static Subject physics = new Subject { Name = "Фізика" };
        public static Subject astronomy = new Subject { Name = "Астрономія" };
        public static Subject history = new Subject { Name = "Історія" };
        public static Subject whistory = new Subject { Name = "Всесвітня Історія" };
        public static Subject uhistory = new Subject { Name = "Історія України" };
        public static Subject jurisprudence = new Subject { Name = "Правознавство" };
        public static Subject civileduc = new Subject { Name = "Громадянська освіта" };
        public static Subject maths = new Subject { Name = "Математика" };
        public static Subject algebra = new Subject { Name = "Алгебра" };
        public static Subject geometry = new Subject { Name = "Геометрія" };
        public static Subject it = new Subject { Name = "Інформатика" };
        public static Subject finearts = new Subject { Name = "Образотворче мистецтво" };
        public static Subject arts = new Subject { Name = "Мистецтво" };
        public static Subject music = new Subject { Name = "Музичне мистецтво" };
        public static Subject english = new Subject { Name = "Англійська мова" };
        public static Subject french = new Subject { Name = "Французька мова" };
        public static Subject ukrainian = new Subject { Name = "Українська мова" };
        public static Subject ukrlit = new Subject { Name = "Українська література" };
        public static Subject wliterature = new Subject { Name = "Зарубіжна література" };
        public static Subject pt = new Subject { Name = "Фізична культура" };
        public static Subject civildef = new Subject { Name = "Захист України" };
        public static Subject design = new Subject { Name = "Дизайн і технології" };
        public static Subject individual = new Subject { Name = "Індивідуальні заняття" };
        public static Subject litreading = new Subject { Name = "Літературне читання" };
        public static Subject maths_primary = new Subject { Name = "Математика (поч.шк.)" };
        public static Subject literacy = new Subject { Name = "Навчання грамоти" };
        public static Subject finearts_primary = new Subject { Name = "Образотворче мистецтво (поч.шк.)" };
        public static Subject health = new Subject { Name = "Основи здоров'я" };
        public static Subject health_primary = new Subject { Name = "Основи здоров'я (поч.шк.)" };
        public static Subject writing = new Subject { Name = "Письмо" };
        public static Subject nature_primary = new Subject { Name = "Природознавство (поч.шк.)" };
        public static Subject crafts = new Subject { Name = "Труд. навч. / Технол." };
        public static Subject crafts_primary = new Subject { Name = "Трудове навчання (поч.шк.)" };
        public static Subject iexplore = new Subject { Name = "Я досліджую світ" };
        public static Subject ukrainian_primary = new Subject { Name = "Українська мова (поч.шк.)" };
        public static Subject iandworld = new Subject { Name = "Я у світі" };
        public static Subject reading = new Subject { Name = "Читання" };

        #endregion
        public static List<Subject> data;
        static SubjectsSeedData()
        {
            data = new List<Subject>();
            data.Add(biology);
            data.Add(nature);
            data.Add(geography);
            data.Add(chemistry);
            data.Add(physics);
            data.Add(astronomy);
            data.Add(history);
            data.Add(whistory);
            data.Add(uhistory);
            data.Add(jurisprudence);
            data.Add(civileduc);
            data.Add(maths);
            data.Add(algebra);
            data.Add(geometry);
            data.Add(it);
            data.Add(arts);
            data.Add(finearts);
            data.Add(music);
            data.Add(english);
            data.Add(french);
            data.Add(ukrainian);
            data.Add(ukrlit);
            data.Add(wliterature);
            data.Add(pt);
            data.Add(civildef);
            data.Add(design);
            data.Add(individual);
            data.Add(litreading);
            data.Add(maths_primary);
            data.Add(literacy);
            data.Add(finearts_primary);
            data.Add(health);
            data.Add(health_primary);
            data.Add(writing);
            data.Add(nature_primary);
            data.Add(crafts);
            data.Add(crafts_primary);
            data.Add(iexplore);
            data.Add(ukrainian_primary);
            data.Add(iandworld);
            data.Add(reading);
        }
    }
}

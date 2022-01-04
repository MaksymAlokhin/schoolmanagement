using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedSubject
    {
        public List<Subject> data;
        public SeedSubject()
        {
            CreateSubjects();
        }
        void CreateSubjects()
        {
            #region Create subjects
            Subject biology = new Subject { Name = "Біологія" };
            Subject nature = new Subject { Name = "Природознавство" };
            Subject geography = new Subject { Name = "Географія" };
            Subject chemistry = new Subject { Name = "Хімія" };
            Subject physics = new Subject { Name = "Фізика" };
            Subject astronomy = new Subject { Name = "Астрономія" };
            Subject history = new Subject { Name = "Історія" };
            Subject whistory = new Subject { Name = "Всесвітня Історія" };
            Subject uhistory = new Subject { Name = "Історія України" };
            Subject jurisprudence = new Subject { Name = "Правознавство" };
            Subject civileduc = new Subject { Name = "Громадянська освіта" };
            Subject maths = new Subject { Name = "Математика" };
            Subject algebra = new Subject { Name = "Алгебра" };
            Subject geometry = new Subject { Name = "Геометрія" };
            Subject it = new Subject { Name = "Інформатика" };
            Subject finearts = new Subject { Name = "Образотворче мистецтво" };
            Subject arts = new Subject { Name = "Мистецтво" };
            Subject music = new Subject { Name = "Музичне мистецтво" };
            Subject english = new Subject { Name = "Англійська мова" };
            Subject french = new Subject { Name = "Французька мова" };
            Subject ukrainian = new Subject { Name = "Українська мова" };
            Subject ukrlit = new Subject { Name = "Українська література" };
            Subject wliterature = new Subject { Name = "Зарубіжна література" };
            Subject pt = new Subject { Name = "Фізична культура" };
            Subject civildef = new Subject { Name = "Захист України" };
            Subject design = new Subject { Name = "Дизайн і технології" };
            Subject individual = new Subject { Name = "Індивідуальні заняття" };
            Subject litreading = new Subject { Name = "Літературне читання" };
            Subject maths_primary = new Subject { Name = "Математика (поч.шк.)" };
            Subject literacy = new Subject { Name = "Навчання грамоти" };
            Subject finearts_primary = new Subject { Name = "Образотворче мистецтво (поч.шк.)" };
            Subject health = new Subject { Name = "Основи здоров'я" };
            Subject health_primary = new Subject { Name = "Основи здоров'я (поч.шк.)" };
            Subject writing = new Subject { Name = "Письмо" };
            Subject nature_primary = new Subject { Name = "Природознавство (поч.шк.)" };
            Subject crafts = new Subject { Name = "Труд. навч. / Технол." };
            Subject crafts_primary = new Subject { Name = "Трудове навчання (поч.шк.)" };
            Subject iexplore = new Subject { Name = "Я досліджую світ" };
            Subject ukrainian_primary = new Subject { Name = "Українська мова (поч.шк.)" };
            Subject iandworld = new Subject { Name = "Я у світі" };
            Subject reading = new Subject { Name = "Читання" };
            #endregion
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

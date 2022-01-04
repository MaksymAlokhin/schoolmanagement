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
        #region Subject declarations
        public Subject biology;
        public Subject nature;
        public Subject geography;
        public Subject chemistry;
        public Subject physics;
        public Subject astronomy;
        public Subject history;
        public Subject whistory;
        public Subject uhistory;
        public Subject jurisprudence;
        public Subject civileduc;
        public Subject maths;
        public Subject algebra;
        public Subject geometry;
        public Subject it;
        public Subject finearts;
        public Subject arts;
        public Subject music;
        public Subject english;
        public Subject french;
        public Subject ukrainian;
        public Subject ukrlit;
        public Subject wliterature;
        public Subject pt;
        public Subject civildef;
        public Subject design;
        public Subject individual;
        public Subject litreading;
        public Subject maths_primary;
        public Subject literacy;
        public Subject finearts_primary;
        public Subject health;
        public Subject health_primary;
        public Subject writing;
        public Subject nature_primary;
        public Subject crafts;
        public Subject crafts_primary;
        public Subject iexplore;
        public Subject ukrainian_primary;
        public Subject iandworld;
        public Subject reading;
        #endregion
        public SeedSubject()
        {
            CreateSubjects();
        }
        void CreateSubjects()
        {
            #region Create subjects
            biology = new Subject { Name = "Біологія" };
            nature = new Subject { Name = "Природознавство" };
            geography = new Subject { Name = "Географія" };
            chemistry = new Subject { Name = "Хімія" };
            physics = new Subject { Name = "Фізика" };
            astronomy = new Subject { Name = "Астрономія" };
            history = new Subject { Name = "Історія" };
            whistory = new Subject { Name = "Всесвітня Історія" };
            uhistory = new Subject { Name = "Історія України" };
            jurisprudence = new Subject { Name = "Правознавство" };
            civileduc = new Subject { Name = "Громадянська освіта" };
            maths = new Subject { Name = "Математика" };
            algebra = new Subject { Name = "Алгебра" };
            geometry = new Subject { Name = "Геометрія" };
            it = new Subject { Name = "Інформатика" };
            finearts = new Subject { Name = "Образотворче мистецтво" };
            arts = new Subject { Name = "Мистецтво" };
            music = new Subject { Name = "Музичне мистецтво" };
            english = new Subject { Name = "Англійська мова" };
            french = new Subject { Name = "Французька мова" };
            ukrainian = new Subject { Name = "Українська мова" };
            ukrlit = new Subject { Name = "Українська література" };
            wliterature = new Subject { Name = "Зарубіжна література" };
            pt = new Subject { Name = "Фізична культура" };
            civildef = new Subject { Name = "Захист України" };
            design = new Subject { Name = "Дизайн і технології" };
            individual = new Subject { Name = "Індивідуальні заняття" };
            litreading = new Subject { Name = "Літературне читання" };
            maths_primary = new Subject { Name = "Математика (поч.шк.)" };
            literacy = new Subject { Name = "Навчання грамоти" };
            finearts_primary = new Subject { Name = "Образотворче мистецтво (поч.шк.)" };
            health = new Subject { Name = "Основи здоров'я" };
            health_primary = new Subject { Name = "Основи здоров'я (поч.шк.)" };
            writing = new Subject { Name = "Письмо" };
            nature_primary = new Subject { Name = "Природознавство (поч.шк.)" };
            crafts = new Subject { Name = "Труд. навч. / Технол." };
            crafts_primary = new Subject { Name = "Трудове навчання (поч.шк.)" };
            iexplore = new Subject { Name = "Я досліджую світ" };
            ukrainian_primary = new Subject { Name = "Українська мова (поч.шк.)" };
            iandworld = new Subject { Name = "Я у світі" };
            reading = new Subject { Name = "Читання" };
            #endregion
            #region Add subjects
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
            #endregion
        }
    }
}

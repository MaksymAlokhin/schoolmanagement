using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;

namespace sms.Data
{
    public class SeedTeacher
    {
        SeedSubject subjects;
        #region Teacher declarations
        public Teacher lisichkina;
        public Teacher vasylieva;
        public Teacher kurach;
        public Teacher martynenko;
        public Teacher boyarska;
        public Teacher dybka;
        public Teacher ponomarenko;
        public Teacher synko;
        public Teacher kholodiuk;
        public Teacher kyrianov;
        public Teacher shafran;
        public Teacher bulachok;
        public Teacher smychnikova;
        public Teacher manko;
        public Teacher shulga;
        public Teacher zviahelskyi;
        public Teacher havro;
        public Teacher symonenko_op;
        public Teacher kyrylusha;
        public Teacher verbova_nv;
        public Teacher verbova_vo;
        public Teacher melnychuk;
        public Teacher slavov;
        public Teacher tverdokhlibova;
        public Teacher shevchenko;
        public Teacher honcharuk;
        public Teacher moskalenko;
        public Teacher bondarenko;
        public Teacher vlasiuk;
        public Teacher horlova;
        public Teacher yeroshkina;
        public Teacher zadorozhnia;
        public Teacher hnots;
        public Teacher lavrychenko;
        public Teacher lonska;
        public Teacher mandro;
        public Teacher nanivska;
        public Teacher nimchenko;
        public Teacher plotnik;
        public Teacher symonenko_ov;
        public Teacher sovenko;
        public Teacher sulyma;

        #endregion
        public List<Teacher> data;
        public SeedTeacher(SeedSubject _subjects)
        {
            subjects = _subjects;
            CreateTeachers();
        }
        void CreateTeachers()
        {
            #region Create teachers
            lisichkina = new Teacher
            {
                LastName = "Лісічкіна",
                FirstName = "Світлана",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_001.jpg",
                Subjects = new List<Subject>
               {
                subjects.english
               }
            };

            boyarska = new Teacher
            {
                LastName = "Боярська",
                FirstName = "Олена",
                Patronymic = "Романівна",
                ProfilePicture = "female_002.jpg",
                Subjects = new List<Subject>
               {
                subjects.biology,
                subjects.nature
               }
            };

            dybka = new Teacher
            {
                LastName = "Дибка",
                FirstName = "Оксана",
                Patronymic = "Євгеніїна",
                ProfilePicture = "female_003.jpg",
                Subjects = new List<Subject>
            {
                subjects.biology,
                subjects.nature
               }
            };

            ponomarenko = new Teacher
            {
                LastName = "Пономаренко",
                FirstName = "Ольга",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_004.jpg",
                Subjects = new List<Subject>
               {
                   subjects.geography
               }
            };
            shevchenko = new Teacher
            {
                LastName = "Шевченко",
                FirstName = "Раїса",
                Patronymic = "Романівна",
                ProfilePicture = "female_005.jpg",
                Subjects = new List<Subject>
               {
                   subjects.chemistry
               }
            };
            honcharuk = new Teacher
            {
                LastName = "Гончарук",
                FirstName = "Андрій",
                Patronymic = "Михайлович",
                ProfilePicture = "male_001.jpg",
                Subjects = new List<Subject>
               {
                   subjects.crafts
               }
            };
            moskalenko = new Teacher
            {
                LastName = "Москаленко",
                FirstName = "Наталія",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_006.jpg",
                Subjects = new List<Subject>
               {
                   subjects.health
               }
            };
            bulachok = new Teacher
            {
                LastName = "Булачок",
                FirstName = "Віта",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_007.jpg",
                Subjects = new List<Subject>
               {
                   subjects.history,
                   subjects.whistory,
                   subjects.uhistory,
                   subjects.jurisprudence,
                   subjects.civileduc
               }
            };
            smychnikova = new Teacher
            {
                LastName = "Смичнікова",
                FirstName = "Наталія",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_008.jpg",
                Subjects = new List<Subject>
               {
                   subjects.maths,
                   subjects.algebra,
                   subjects.geometry

               }
            };
            kholodiuk = new Teacher
            {
                LastName = "Холодюк",
                FirstName = "Тамара",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_009.jpg",
                Subjects = new List<Subject>
               {
                   subjects.it,
                   subjects.arts,
                   subjects.finearts
               }
            };
            zviahelskyi = new Teacher
            {
                LastName = "Звягельський",
                FirstName = "Олег",
                Patronymic = "Володимирович",
                ProfilePicture = "male_002.jpg",
                Subjects = new List<Subject>
               {
                   subjects.music
               }
            };
            verbova_vo = new Teacher
            {
                LastName = "Вербова",
                FirstName = "Валентина",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_010.jpg",
                Subjects = new List<Subject>
               {
                   subjects.physics,
                   subjects.astronomy
               }
            };
            kyrianov = new Teacher
            {
                LastName = "Кир'янов",
                FirstName = "Дмитро",
                Patronymic = "Михайлович",
                ProfilePicture = "male_003.jpg",
                Subjects = new List<Subject>
               {
                   subjects.it
               }
            };
            manko = new Teacher
            {
                LastName = "Манько",
                FirstName = "Наталія",
                Patronymic = "Павлівна",
                ProfilePicture = "female_011.jpg",
                Subjects = new List<Subject>
               {
                subjects.maths,
                subjects.algebra,
                subjects.geometry
               }
            };
            shulga = new Teacher
            {
                LastName = "Шульга",
                FirstName = "Ірина",
                Patronymic = "Петрівна",
                ProfilePicture = "female_012.jpg",
                Subjects = new List<Subject>
               {
                subjects.maths,
                subjects.algebra,
                subjects.geometry
               }
            };
            shafran = new Teacher
            {
                LastName = "Шафран",
                FirstName = "Світлана",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_013.jpg",
                Subjects = new List<Subject>
               {
                   subjects.it
               }
            };
            vasylieva = new Teacher
            {
                LastName = "Васильєва",
                FirstName = "Лідія",
                Patronymic = "Семенівна",
                ProfilePicture = "female_014.jpg",
                Subjects = new List<Subject>
               {
                   subjects.english
               }
            };
            kurach = new Teacher
            {
                LastName = "Курач",
                FirstName = "Ольга",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_015.jpg",
                Subjects = new List<Subject>
               {
                   subjects.english,
                   subjects.french
               }
            };
            martynenko = new Teacher
            {
                LastName = "Мартиненко",
                FirstName = "Галина",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_016.jpg",
                Subjects = new List<Subject>
               {
                   subjects.english,
                   subjects.french
               }
            };
            havro = new Teacher
            {
                LastName = "Гавро",
                FirstName = "Галина",
                Patronymic = "Василівна",
                ProfilePicture = "female_017.jpg",
                Subjects = new List<Subject>
               {
                   subjects.ukrainian,
                   subjects.ukrlit
               }
            };
            symonenko_op = new Teacher
            {
                LastName = "Симоненко",
                FirstName = "Ольга",
                Patronymic = "Павлівна",
                ProfilePicture = "female_018.jpg",
                Subjects = new List<Subject>
               {
                   subjects.ukrainian,
                   subjects.ukrlit
               }
            };
            kyrylusha = new Teacher
            {
                LastName = "Кирилуша",
                FirstName = "Світлана",
                Patronymic = "Валеріївна",
                ProfilePicture = "female_019.jpg",
                Subjects = new List<Subject>
               {
                   subjects.ukrainian,
                   subjects.ukrlit
               }
            };
            verbova_nv = new Teacher
            {
                LastName = "Вербова",
                FirstName = "Наталя",
                Patronymic = "Василівна",
                ProfilePicture = "female_020.jpg",
                Subjects = new List<Subject>
               {
                   subjects.ukrainian,
                   subjects.ukrlit
               }
            };
            synko = new Teacher
            {
                LastName = "Синько",
                FirstName = "Олена",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_021.jpg",
                Subjects = new List<Subject>
                {
                    subjects.wliterature
                }
            };
            melnychuk = new Teacher
            {
                LastName = "Мельничук",
                FirstName = "Євген",
                Patronymic = "Ігорович",
                ProfilePicture = "male_004.jpg",
                Subjects = new List<Subject>
               {
                   subjects.pt,
                   subjects.civildef
               }
            };
            slavov = new Teacher
            {
                LastName = "Славов",
                FirstName = "Володимир",
                Patronymic = "Георгійович",
                ProfilePicture = "male_005.jpg",
                Subjects = new List<Subject>
               {
                   subjects.pt,
                   subjects.civildef
               }
            };
            tverdokhlibova = new Teacher
            {
                LastName = "Твердохлібова",
                FirstName = "Тетяна",
                Patronymic = "Борисівна",
                ProfilePicture = "female_022.jpg",
                Subjects = new List<Subject>
               {
                   subjects.pt,
                   subjects.civildef
               }
            };
            bondarenko = new Teacher
            {
                LastName = "Бондаренко",
                FirstName = "Тетяна",
                Patronymic = "Володимирівна",
                ProfilePicture = "female_023.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
               }
            };
            vlasiuk = new Teacher
            {
                LastName = "Власюк",
                FirstName = "Таліна",
                Patronymic = "Сергіївна",
                ProfilePicture = "female_024.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            horlova = new Teacher
            {
                LastName = "Горлова",
                FirstName = "Ірина",
                Patronymic = "Кузьмівна",
                ProfilePicture = "female_025.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            yeroshkina = new Teacher
            {
                LastName = "Єрошкіна",
                FirstName = "Любов",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_026.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            zadorozhnia = new Teacher
            {
                LastName = "Задорожня",
                FirstName = "Наталія",
                Patronymic = "Іванівна",
                ProfilePicture = "female_027.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            hnots = new Teacher
            {
                LastName = "Гноць",
                FirstName = "Марія",
                Patronymic = "Петрівна",
                ProfilePicture = "female_028.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            lavrychenko = new Teacher
            {
                LastName = "Лавриченко",
                FirstName = "Олена",
                Patronymic = "Василівна",
                ProfilePicture = "female_029.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            lonska = new Teacher
            {
                LastName = "Лонська",
                FirstName = "Раїса",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_030.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            mandro = new Teacher
            {
                LastName = "Мандро",
                FirstName = "Ольга",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_031.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            nanivska = new Teacher
            {
                LastName = "Нанівська",
                FirstName = "Зеновія",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_032.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            nimchenko = new Teacher
            {
                LastName = "Німченко",
                FirstName = "Наталія",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_033.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            plotnik = new Teacher
            {
                LastName = "Плотнік",
                FirstName = "Руслана",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_034.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            symonenko_ov = new Teacher
            {
                LastName = "Симоненко",
                FirstName = "Ольга",
                Patronymic = "Василівна",
                ProfilePicture = "female_035.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            sovenko = new Teacher
            {
                LastName = "Совенко",
                FirstName = "Наталія",
                Patronymic = "Іванівна",
                ProfilePicture = "female_036.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            sulyma = new Teacher
            {
                LastName = "Сулима",
                FirstName = "Ганна",
                Patronymic = "Іванівна",
                ProfilePicture = "female_037.jpg",
                Subjects = new List<Subject>
               {
                   subjects.design,
                   subjects.individual,
                   subjects.litreading,
                   subjects.maths_primary,
                   subjects.literacy,
                   subjects.finearts_primary,
                   subjects.health_primary,
                   subjects.writing,
                   subjects.nature_primary,
                   subjects.crafts_primary,
                   subjects.ukrainian_primary,
                   subjects.iexplore,
                   subjects.iandworld,
                   subjects.reading
            }
            };
            #endregion
            #region Add teachers
            data = new List<Teacher>();
            data.Add(lisichkina);
            data.Add(vasylieva);
            data.Add(kurach);
            data.Add(martynenko);
            data.Add(boyarska);
            data.Add(dybka);
            data.Add(ponomarenko);
            data.Add(synko);
            data.Add(kholodiuk);
            data.Add(kyrianov);
            data.Add(shafran);
            data.Add(bulachok);
            data.Add(smychnikova);
            data.Add(manko);
            data.Add(shulga);
            data.Add(zviahelskyi);
            data.Add(havro);
            data.Add(symonenko_op);
            data.Add(kyrylusha);
            data.Add(verbova_nv);
            data.Add(verbova_vo);
            data.Add(melnychuk);
            data.Add(slavov);
            data.Add(tverdokhlibova);
            data.Add(shevchenko);
            data.Add(honcharuk);
            data.Add(moskalenko);
            data.Add(bondarenko);
            data.Add(vlasiuk);
            data.Add(horlova);
            data.Add(yeroshkina);
            data.Add(zadorozhnia);
            data.Add(hnots);
            data.Add(lavrychenko);
            data.Add(lonska);
            data.Add(mandro);
            data.Add(nanivska);
            data.Add(nimchenko);
            data.Add(plotnik);
            data.Add(symonenko_ov);
            data.Add(sovenko);
            data.Add(sulyma);
            #endregion
        }
    }
}
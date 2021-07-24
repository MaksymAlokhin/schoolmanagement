using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using static sms.Data.SubjectsSeedData;

namespace sms.Data
{
    public static class TeachersSeedData
    {
        #region Create teachers
        public static Teacher boyarska = new Teacher
        {
            LastName = "Боярська",
            FirstName = "Олена",
            Patronymic = "Романівна",
            Subjects = new List<Subject>
               {
                biology,
                nature
               }
        };

        public static Teacher dybka = new Teacher
        {
            LastName = "Дибка",
            FirstName = "Оксана",
            Patronymic = "Євгеніїна",
            Subjects = new List<Subject>
            {
                biology,
                nature
               }
        };

        public static Teacher ponomarenko = new Teacher
        {
            LastName = "Пономаренко",
            FirstName = "Ольга",
            Patronymic = "Миколаївна",
            Subjects = new List<Subject>
               {
                   geography
               }
        };
        public static Teacher shevchenko = new Teacher
        {
            LastName = "Шевченко",
            FirstName = "Раїса",
            Patronymic = "Романівна",
            Subjects = new List<Subject>
               {
                   chemistry
               }
        };
        public static Teacher honcharuk = new Teacher
        {
            LastName = "Гончарук",
            FirstName = "Андрій",
            Patronymic = "Михайлович",
            Subjects = new List<Subject>
               {
                   crafts
               }
        };
        public static Teacher moskalenko = new Teacher
        {
            LastName = "Москаленко",
            FirstName = "Наталія",
            Patronymic = "Олександрівна",
            Subjects = new List<Subject>
               {
                   health
               }
        };
        public static Teacher bulachok = new Teacher
        {
            LastName = "Булачок",
            FirstName = "Віта",
            Patronymic = "Олександрівна",
            Subjects = new List<Subject>
               {
                   history,
                   whistory,
                   uhistory,
                   jurisprudence
               }
        };
        public static Teacher smychnikova = new Teacher
        {
            LastName = "Смичнікова",
            FirstName = "Наталія",
            Patronymic = "Миколаївна",
            Subjects = new List<Subject>
               {
                   maths,
                   algebra,
                   geometry

               }
        };
        public static Teacher kholodiuk = new Teacher
        {
            LastName = "Холодюк",
            FirstName = "Тамара",
            Patronymic = "Вікторівна",
            Subjects = new List<Subject>
               {
                   it,
                   arts
               }
        };
        public static Teacher zviahelskyi = new Teacher
        {
            LastName = "Звягельський",
            FirstName = "Олег",
            Patronymic = "Володимирович",
            Subjects = new List<Subject>
               {
                   music
               }
        };
        public static Teacher verbova_p = new Teacher
        {
            LastName = "Вербова",
            FirstName = "Валентина",
            Patronymic = "Олександрівна",
            Subjects = new List<Subject>
               {
                   physics
               }
        };
        public static Teacher kyrianov = new Teacher
        {
            LastName = "Кир'янов",
            FirstName = "Дмитро",
            Patronymic = "Михайлович",
            Subjects = new List<Subject>
               {
                   it
               }
        };
        public static Teacher manko = new Teacher
        {
            LastName = "Манько",
            FirstName = "Наталія",
            Patronymic = "Павлівна",
            Subjects = new List<Subject>
               {
                maths,
                algebra,
                geometry
               }
        };
        public static Teacher shulga = new Teacher
        {
            LastName = "Шульга",
            FirstName = "Ірина",
            Patronymic = "Петрівна",
            Subjects = new List<Subject>
               {
                maths,
                algebra,
                geometry
               }
        };
        public static Teacher shafran = new Teacher
        {
            LastName = "Шафран",
            FirstName = "Світлана",
            Patronymic = "Миколаївна",
            Subjects = new List<Subject>
               {
                   it
               }
        };
        public static Teacher vasylieva = new Teacher
        {
            LastName = "Васильєва",
            FirstName = "Лідія",
            Patronymic = "Семенівна",
            Subjects = new List<Subject>
               {
                   english
               }
        };
        public static Teacher kurach = new Teacher
        {
            LastName = "Курач",
            FirstName = "Ольга",
            Patronymic = "Олександрівна",
            Subjects = new List<Subject>
               {
                   english,
                   french
               }
        };
        public static Teacher martynenko = new Teacher
        {
            LastName = "Мартиненко",
            FirstName = "Галина",
            Patronymic = "Михайлівна",
            Subjects = new List<Subject>
               {
                   english,
                   french
               }
        };
        public static Teacher havro = new Teacher
        {
            LastName = "Гавро",
            FirstName = "Галина",
            Patronymic = "Василівна",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher symonenko_u = new Teacher
        {
            LastName = "Симоненко",
            FirstName = "Ольга",
            Patronymic = "Павлівна",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher kyrylusha = new Teacher
        {
            LastName = "Кирилуша",
            FirstName = "Світлана",
            Patronymic = "Валеріївна",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher verbova_u = new Teacher
        {
            LastName = "Вербова",
            FirstName = "Наталя",
            Patronymic = "Василівна",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher synko = new Teacher
        {
            LastName = "Синько",
            FirstName = "Олена",
            Patronymic = "Миколаївна",
            Subjects = new List<Subject>
                {
                    wliterature
                }
        };
        public static Teacher melnychuk = new Teacher
        {
            LastName = "Мельничук",
            FirstName = "Євген",
            Patronymic = "Ігорович",
            Subjects = new List<Subject>
               {
                   pt
               }
        };
        public static Teacher slavov = new Teacher
        {
            LastName = "Славов",
            FirstName = "Володимир",
            Patronymic = "Георгійович",
            Subjects = new List<Subject>
               {
                   pt
               }
        };
        public static Teacher tverdokhlibova = new Teacher
        {
            LastName = "Твердохлібова",
            FirstName = "Тетяна",
            Patronymic = "Борисівна",
            Subjects = new List<Subject>
               {
                   pt
               }
        };
        public static Teacher bondarenko = new Teacher
        {
            LastName = "Бондаренко",
            FirstName = "Тетяна",
            Patronymic = "Володимирівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
               }
        };
        public static Teacher vlasiuk = new Teacher
        {
            LastName = "Власюк",
            FirstName = "Таліна",
            Patronymic = "Сергіївна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher horlova = new Teacher
        {
            LastName = "Горлова",
            FirstName = "Ірина",
            Patronymic = "Кузьмівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher yeroshkina = new Teacher
        {
            LastName = "Єрошкіна",
            FirstName = "Любов",
            Patronymic = "Вікторівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher zadorozhnia = new Teacher
        {
            LastName = "Задорожня",
            FirstName = "Наталія",
            Patronymic = "Іванівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher hnots = new Teacher
        {
            LastName = "Гноць",
            FirstName = "Марія",
            Patronymic = "Петрівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher lavrychenko = new Teacher
        {
            LastName = "Лавриченко",
            FirstName = "Олена",
            Patronymic = "Василівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher lonska = new Teacher
        {
            LastName = "Лонська",
            FirstName = "Раїса",
            Patronymic = "Михайлівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher mandro = new Teacher
        {
            LastName = "Мандро",
            FirstName = "Ольга",
            Patronymic = "Олександрівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher nanivska = new Teacher
        {
            LastName = "Нанівська",
            FirstName = "Зеновія",
            Patronymic = "Михайлівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher nimchenko = new Teacher
        {
            LastName = "Німченко",
            FirstName = "Наталія",
            Patronymic = "Миколаївна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher plotnik = new Teacher
        {
            LastName = "Плотнік",
            FirstName = "Руслана",
            Patronymic = "Вікторівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher symonenko_p = new Teacher
        {
            LastName = "Симоненко",
            FirstName = "Ольга",
            Patronymic = "Василівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher sovenko = new Teacher
        {
            LastName = "Совенко",
            FirstName = "Наталія",
            Patronymic = "Іванівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        public static Teacher sulyma = new Teacher
        {
            LastName = "Сулима",
            FirstName = "Ганна",
            Patronymic = "Іванівна",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   arts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld
            }
        };
        #endregion
        public static List<Teacher> data;
        static TeachersSeedData()
        {
            data = new List<Teacher>();
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
            data.Add(symonenko_u);
            data.Add(kyrylusha);
            data.Add(verbova_u);
            data.Add(verbova_p);
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
            data.Add(symonenko_p);
            data.Add(sovenko);
            data.Add(sulyma);
        }
    }
}
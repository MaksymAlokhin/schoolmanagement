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
        public static Teacher lisichkina = new Teacher
        {
            LastName = "Лісічкіна",
            FirstName = "Світлана",
            Patronymic = "Миколаївна",            ProfilePicture = "female_001.jpg",
            Subjects = new List<Subject>
               {
                english
               }
        };

        public static Teacher boyarska = new Teacher
        {
            LastName = "Боярська",
            FirstName = "Олена",
            Patronymic = "Романівна",            ProfilePicture = "female_002.jpg",
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
            Patronymic = "Євгеніїна",            ProfilePicture = "female_003.jpg",
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
            Patronymic = "Миколаївна",            ProfilePicture = "female_004.jpg",
            Subjects = new List<Subject>
               {
                   geography
               }
        };
        public static Teacher shevchenko = new Teacher
        {
            LastName = "Шевченко",
            FirstName = "Раїса",
            Patronymic = "Романівна",            ProfilePicture = "female_005.jpg",
            Subjects = new List<Subject>
               {
                   chemistry
               }
        };
        public static Teacher honcharuk = new Teacher
        {
            LastName = "Гончарук",
            FirstName = "Андрій",
            Patronymic = "Михайлович",            ProfilePicture = "male_001.jpg",
            Subjects = new List<Subject>
               {
                   crafts
               }
        };
        public static Teacher moskalenko = new Teacher
        {
            LastName = "Москаленко",
            FirstName = "Наталія",
            Patronymic = "Олександрівна",            ProfilePicture = "female_006.jpg",
            Subjects = new List<Subject>
               {
                   health
               }
        };
        public static Teacher bulachok = new Teacher
        {
            LastName = "Булачок",
            FirstName = "Віта",
            Patronymic = "Олександрівна",            ProfilePicture = "female_007.jpg",
            Subjects = new List<Subject>
               {
                   history,
                   whistory,
                   uhistory,
                   jurisprudence,
                   civileduc
               }
        };
        public static Teacher smychnikova = new Teacher
        {
            LastName = "Смичнікова",
            FirstName = "Наталія",
            Patronymic = "Миколаївна",            ProfilePicture = "female_008.jpg",
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
            Patronymic = "Вікторівна",            ProfilePicture = "female_009.jpg",
            Subjects = new List<Subject>
               {
                   it,
                   arts,
                   finearts
               }
        };
        public static Teacher zviahelskyi = new Teacher
        {
            LastName = "Звягельський",
            FirstName = "Олег",
            Patronymic = "Володимирович",            ProfilePicture = "male_002.jpg",
            Subjects = new List<Subject>
               {
                   music
               }
        };
        public static Teacher verbova_vo = new Teacher
        {
            LastName = "Вербова",
            FirstName = "Валентина",
            Patronymic = "Олександрівна",            ProfilePicture = "female_010.jpg",
            Subjects = new List<Subject>
               {
                   physics,
                   astronomy
               }
        };
        public static Teacher kyrianov = new Teacher
        {
            LastName = "Кир'янов",
            FirstName = "Дмитро",
            Patronymic = "Михайлович",            ProfilePicture = "male_003.jpg",
            Subjects = new List<Subject>
               {
                   it
               }
        };
        public static Teacher manko = new Teacher
        {
            LastName = "Манько",
            FirstName = "Наталія",
            Patronymic = "Павлівна",            ProfilePicture = "female_011.jpg",
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
            Patronymic = "Петрівна",            ProfilePicture = "female_012.jpg",
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
            Patronymic = "Миколаївна",            ProfilePicture = "female_013.jpg",
            Subjects = new List<Subject>
               {
                   it
               }
        };
        public static Teacher vasylieva = new Teacher
        {
            LastName = "Васильєва",
            FirstName = "Лідія",
            Patronymic = "Семенівна",            ProfilePicture = "female_014.jpg",
            Subjects = new List<Subject>
               {
                   english
               }
        };
        public static Teacher kurach = new Teacher
        {
            LastName = "Курач",
            FirstName = "Ольга",
            Patronymic = "Олександрівна",            ProfilePicture = "female_015.jpg",
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
            Patronymic = "Михайлівна",            ProfilePicture = "female_016.jpg",
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
            Patronymic = "Василівна",            ProfilePicture = "female_017.jpg",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher symonenko_op = new Teacher
        {
            LastName = "Симоненко",
            FirstName = "Ольга",
            Patronymic = "Павлівна",            ProfilePicture = "female_018.jpg",
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
            Patronymic = "Валеріївна",            ProfilePicture = "female_019.jpg",
            Subjects = new List<Subject>
               {
                   ukrainian,
                   ukrlit
               }
        };
        public static Teacher verbova_nv = new Teacher
        {
            LastName = "Вербова",
            FirstName = "Наталя",
            Patronymic = "Василівна",            ProfilePicture = "female_020.jpg",
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
            Patronymic = "Миколаївна",            ProfilePicture = "female_021.jpg",
            Subjects = new List<Subject>
                {
                    wliterature
                }
        };
        public static Teacher melnychuk = new Teacher
        {
            LastName = "Мельничук",
            FirstName = "Євген",
            Patronymic = "Ігорович",            ProfilePicture = "male_004.jpg",
            Subjects = new List<Subject>
               {
                   pt,
                   civildef
               }
        };
        public static Teacher slavov = new Teacher
        {
            LastName = "Славов",
            FirstName = "Володимир",
            Patronymic = "Георгійович",            ProfilePicture = "male_005.jpg",
            Subjects = new List<Subject>
               {
                   pt,
                   civildef
               }
        };
        public static Teacher tverdokhlibova = new Teacher
        {
            LastName = "Твердохлібова",
            FirstName = "Тетяна",
            Patronymic = "Борисівна",            ProfilePicture = "female_022.jpg",
            Subjects = new List<Subject>
               {
                   pt,
                   civildef
               }
        };
        public static Teacher bondarenko = new Teacher
        {
            LastName = "Бондаренко",
            FirstName = "Тетяна",
            Patronymic = "Володимирівна",            ProfilePicture = "female_023.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
               }
        };
        public static Teacher vlasiuk = new Teacher
        {
            LastName = "Власюк",
            FirstName = "Таліна",
            Patronymic = "Сергіївна",            ProfilePicture = "female_024.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher horlova = new Teacher
        {
            LastName = "Горлова",
            FirstName = "Ірина",
            Patronymic = "Кузьмівна",            ProfilePicture = "female_025.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher yeroshkina = new Teacher
        {
            LastName = "Єрошкіна",
            FirstName = "Любов",
            Patronymic = "Вікторівна",            ProfilePicture = "female_026.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher zadorozhnia = new Teacher
        {
            LastName = "Задорожня",
            FirstName = "Наталія",
            Patronymic = "Іванівна",            ProfilePicture = "female_027.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher hnots = new Teacher
        {
            LastName = "Гноць",
            FirstName = "Марія",
            Patronymic = "Петрівна",            ProfilePicture = "female_028.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher lavrychenko = new Teacher
        {
            LastName = "Лавриченко",
            FirstName = "Олена",
            Patronymic = "Василівна",            ProfilePicture = "female_029.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher lonska = new Teacher
        {
            LastName = "Лонська",
            FirstName = "Раїса",
            Patronymic = "Михайлівна",            ProfilePicture = "female_030.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher mandro = new Teacher
        {
            LastName = "Мандро",
            FirstName = "Ольга",
            Patronymic = "Олександрівна",            ProfilePicture = "female_031.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher nanivska = new Teacher
        {
            LastName = "Нанівська",
            FirstName = "Зеновія",
            Patronymic = "Михайлівна",            ProfilePicture = "female_032.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher nimchenko = new Teacher
        {
            LastName = "Німченко",
            FirstName = "Наталія",
            Patronymic = "Миколаївна",            ProfilePicture = "female_033.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher plotnik = new Teacher
        {
            LastName = "Плотнік",
            FirstName = "Руслана",
            Patronymic = "Вікторівна",            ProfilePicture = "female_034.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher symonenko_ov = new Teacher
        {
            LastName = "Симоненко",
            FirstName = "Ольга",
            Patronymic = "Василівна",            ProfilePicture = "female_035.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher sovenko = new Teacher
        {
            LastName = "Совенко",
            FirstName = "Наталія",
            Patronymic = "Іванівна",            ProfilePicture = "female_036.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        public static Teacher sulyma = new Teacher
        {
            LastName = "Сулима",
            FirstName = "Ганна",
            Patronymic = "Іванівна",            ProfilePicture = "female_037.jpg",
            Subjects = new List<Subject>
               {
                   design,
                   individual,
                   litreading,
                   maths_primary,
                   literacy,
                   finearts_primary,
                   health_primary,
                   writing,
                   nature_primary,
                   crafts_primary,
                   ukrainian_primary,
                   iexplore,
                   iandworld,
                   reading
            }
        };
        #endregion
        public static List<Teacher> data;
        static TeachersSeedData()
        {
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
        }
    }
}
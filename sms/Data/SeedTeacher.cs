using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sms.Models;
using sms.Data;

namespace sms.Data
{
    public class SeedTeacher
    {
        public List<Teacher> data;
        SeedSubject subjects;
        public SeedTeacher(SeedSubject _subjects)
        {
            subjects = _subjects;
            CreateTeachers();
        }
        void CreateTeachers()
        {
            #region Create Teachers
            Teacher lisichkina = new Teacher
            {
                LastName = "Лісічкіна",
                FirstName = "Світлана",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_001.jpg",
                Subjects = new List<Subject>
               {
                subjects.data.Find(f => f.Name == "Англійська мова")
               }
            };

            Teacher boyarska = new Teacher
            {
                LastName = "Боярська",
                FirstName = "Олена",
                Patronymic = "Романівна",
                ProfilePicture = "female_002.jpg",
                Subjects = new List<Subject>
               {
                subjects.data.Find(f => f.Name == "Біологія"),
                subjects.data.Find(f => f.Name == "Природознавство")
               }
            };

            Teacher dybka = new Teacher
            {
                LastName = "Дибка",
                FirstName = "Оксана",
                Patronymic = "Євгеніїна",
                ProfilePicture = "female_003.jpg",
                Subjects = new List<Subject>
            {
                subjects.data.Find(f => f.Name == "Біологія"),
                subjects.data.Find(f => f.Name == "Природознавство")
               }
            };

            Teacher ponomarenko = new Teacher
            {
                LastName = "Пономаренко",
                FirstName = "Ольга",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_004.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Географія")
               }
            };
            Teacher shevchenko = new Teacher
            {
                LastName = "Шевченко",
                FirstName = "Раїса",
                Patronymic = "Романівна",
                ProfilePicture = "female_005.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Хімія")
               }
            };
            Teacher honcharuk = new Teacher
            {
                LastName = "Гончарук",
                FirstName = "Андрій",
                Patronymic = "Михайлович",
                ProfilePicture = "male_001.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Труд. навч. / Технол.")
               }
            };
            Teacher moskalenko = new Teacher
            {
                LastName = "Москаленко",
                FirstName = "Наталія",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_006.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Основи здоров'я")
               }
            };
            Teacher bulachok = new Teacher
            {
                LastName = "Булачок",
                FirstName = "Віта",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_007.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Історія"),
                   subjects.data.Find(f => f.Name == "Всесвітня Історія"),
                   subjects.data.Find(f => f.Name == "Історія України"),
                   subjects.data.Find(f => f.Name == "Правознавство"),
                   subjects.data.Find(f => f.Name == "Громадянська освіта")
               }
            };
            Teacher smychnikova = new Teacher
            {
                LastName = "Смичнікова",
                FirstName = "Наталія",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_008.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Математика"),
                   subjects.data.Find(f => f.Name == "Алгебра"),
                   subjects.data.Find(f => f.Name == "Геометрія")

               }
            };
            Teacher kholodiuk = new Teacher
            {
                LastName = "Холодюк",
                FirstName = "Тамара",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_009.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Інформатика"),
                   subjects.data.Find(f => f.Name == "Мистецтво"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво")
               }
            };
            Teacher zviahelskyi = new Teacher
            {
                LastName = "Звягельський",
                FirstName = "Олег",
                Patronymic = "Володимирович",
                ProfilePicture = "male_002.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Музичне мистецтво")
               }
            };
            Teacher verbova_vo = new Teacher
            {
                LastName = "Вербова",
                FirstName = "Валентина",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_010.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Фізика"),
                   subjects.data.Find(f => f.Name == "Астрономія")
               }
            };
            Teacher kyrianov = new Teacher
            {
                LastName = "Кир'янов",
                FirstName = "Дмитро",
                Patronymic = "Михайлович",
                ProfilePicture = "male_003.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Інформатика")
               }
            };
            Teacher manko = new Teacher
            {
                LastName = "Манько",
                FirstName = "Наталія",
                Patronymic = "Павлівна",
                ProfilePicture = "female_011.jpg",
                Subjects = new List<Subject>
               {
                subjects.data.Find(f => f.Name == "Математика"),
                subjects.data.Find(f => f.Name == "Алгебра"),
                subjects.data.Find(f => f.Name == "Геометрія")
               }
            };
            Teacher shulga = new Teacher
            {
                LastName = "Шульга",
                FirstName = "Ірина",
                Patronymic = "Петрівна",
                ProfilePicture = "female_012.jpg",
                Subjects = new List<Subject>
               {
                subjects.data.Find(f => f.Name == "Математика"),
                subjects.data.Find(f => f.Name == "Алгебра"),
                subjects.data.Find(f => f.Name == "Геометрія")
               }
            };
            Teacher shafran = new Teacher
            {
                LastName = "Шафран",
                FirstName = "Світлана",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_013.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Інформатика")
               }
            };
            Teacher vasylieva = new Teacher
            {
                LastName = "Васильєва",
                FirstName = "Лідія",
                Patronymic = "Семенівна",
                ProfilePicture = "female_014.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Англійська мова")
               }
            };
            Teacher kurach = new Teacher
            {
                LastName = "Курач",
                FirstName = "Ольга",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_015.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Англійська мова"),
                   subjects.data.Find(f => f.Name == "Французька мова")
               }
            };
            Teacher martynenko = new Teacher
            {
                LastName = "Мартиненко",
                FirstName = "Галина",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_016.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Англійська мова"),
                   subjects.data.Find(f => f.Name == "Французька мова")
               }
            };
            Teacher havro = new Teacher
            {
                LastName = "Гавро",
                FirstName = "Галина",
                Patronymic = "Василівна",
                ProfilePicture = "female_017.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Українська мова"),
                   subjects.data.Find(f => f.Name == "Українська література")
               }
            };
            Teacher symonenko_op = new Teacher
            {
                LastName = "Симоненко",
                FirstName = "Ольга",
                Patronymic = "Павлівна",
                ProfilePicture = "female_018.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Українська мова"),
                   subjects.data.Find(f => f.Name == "Українська література")
               }
            };
            Teacher kyrylusha = new Teacher
            {
                LastName = "Кирилуша",
                FirstName = "Світлана",
                Patronymic = "Валеріївна",
                ProfilePicture = "female_019.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Українська мова"),
                   subjects.data.Find(f => f.Name == "Українська література")
               }
            };
            Teacher verbova_nv = new Teacher
            {
                LastName = "Вербова",
                FirstName = "Наталя",
                Patronymic = "Василівна",
                ProfilePicture = "female_020.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Українська мова"),
                   subjects.data.Find(f => f.Name == "Українська література")
               }
            };
            Teacher synko = new Teacher
            {
                LastName = "Синько",
                FirstName = "Олена",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_021.jpg",
                Subjects = new List<Subject>
                {
                    subjects.data.Find(f => f.Name == "Зарубіжна література")
                }
            };
            Teacher melnychuk = new Teacher
            {
                LastName = "Мельничук",
                FirstName = "Євген",
                Patronymic = "Ігорович",
                ProfilePicture = "male_004.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Фізична культура"),
                   subjects.data.Find(f => f.Name == "Захист України")
               }
            };
            Teacher slavov = new Teacher
            {
                LastName = "Славов",
                FirstName = "Володимир",
                Patronymic = "Георгійович",
                ProfilePicture = "male_005.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Фізична культура"),
                   subjects.data.Find(f => f.Name == "Захист України")
               }
            };
            Teacher tverdokhlibova = new Teacher
            {
                LastName = "Твердохлібова",
                FirstName = "Тетяна",
                Patronymic = "Борисівна",
                ProfilePicture = "female_022.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Фізична культура"),
                   subjects.data.Find(f => f.Name == "Захист України")
               }
            };
            Teacher bondarenko = new Teacher
            {
                LastName = "Бондаренко",
                FirstName = "Тетяна",
                Patronymic = "Володимирівна",
                ProfilePicture = "female_023.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
               }
            };
            Teacher vlasiuk = new Teacher
            {
                LastName = "Власюк",
                FirstName = "Таліна",
                Patronymic = "Сергіївна",
                ProfilePicture = "female_024.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher horlova = new Teacher
            {
                LastName = "Горлова",
                FirstName = "Ірина",
                Patronymic = "Кузьмівна",
                ProfilePicture = "female_025.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher yeroshkina = new Teacher
            {
                LastName = "Єрошкіна",
                FirstName = "Любов",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_026.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher zadorozhnia = new Teacher
            {
                LastName = "Задорожня",
                FirstName = "Наталія",
                Patronymic = "Іванівна",
                ProfilePicture = "female_027.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher hnots = new Teacher
            {
                LastName = "Гноць",
                FirstName = "Марія",
                Patronymic = "Петрівна",
                ProfilePicture = "female_028.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher lavrychenko = new Teacher
            {
                LastName = "Лавриченко",
                FirstName = "Олена",
                Patronymic = "Василівна",
                ProfilePicture = "female_029.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher lonska = new Teacher
            {
                LastName = "Лонська",
                FirstName = "Раїса",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_030.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher mandro = new Teacher
            {
                LastName = "Мандро",
                FirstName = "Ольга",
                Patronymic = "Олександрівна",
                ProfilePicture = "female_031.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher nanivska = new Teacher
            {
                LastName = "Нанівська",
                FirstName = "Зеновія",
                Patronymic = "Михайлівна",
                ProfilePicture = "female_032.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher nimchenko = new Teacher
            {
                LastName = "Німченко",
                FirstName = "Наталія",
                Patronymic = "Миколаївна",
                ProfilePicture = "female_033.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher plotnik = new Teacher
            {
                LastName = "Плотнік",
                FirstName = "Руслана",
                Patronymic = "Вікторівна",
                ProfilePicture = "female_034.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher symonenko_ov = new Teacher
            {
                LastName = "Симоненко",
                FirstName = "Ольга",
                Patronymic = "Василівна",
                ProfilePicture = "female_035.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher sovenko = new Teacher
            {
                LastName = "Совенко",
                FirstName = "Наталія",
                Patronymic = "Іванівна",
                ProfilePicture = "female_036.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            Teacher sulyma = new Teacher
            {
                LastName = "Сулима",
                FirstName = "Ганна",
                Patronymic = "Іванівна",
                ProfilePicture = "female_037.jpg",
                Subjects = new List<Subject>
               {
                   subjects.data.Find(f => f.Name == "Дизайн і технології"),
                   subjects.data.Find(f => f.Name == "Індивідуальні заняття"),
                   subjects.data.Find(f => f.Name == "Літературне читання"),
                   subjects.data.Find(f => f.Name == "Математика (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Навчання грамоти"),
                   subjects.data.Find(f => f.Name == "Образотворче мистецтво (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Основи здоров'я (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Письмо"),
                   subjects.data.Find(f => f.Name == "Природознавство (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Трудове навчання (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Українська мова (поч.шк.)"),
                   subjects.data.Find(f => f.Name == "Я досліджую світ"),
                   subjects.data.Find(f => f.Name == "Я у світі"),
                   subjects.data.Find(f => f.Name == "Читання")
                }
            };
            #endregion
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

using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Data
{
    public class SeedInventory
    {
        public List<Inventory> data;
        public SeedInventory()
        {
            CreateInventories();
        }
        void CreateInventories()
        {
            #region Create inventories
            data = new List<Inventory>
            {
                 new Inventory
                {
                    Name = "Аксесуари та витратні матеріали до дошок: губка для витирання",
                    InventoryNumber = 97060980,
                    Quantity = 19,
                    Price = 2471.68m,
                    InventoryDate = new DateTime(2014, 5, 5)
                },
                new Inventory
                {
                    Name = "Аксесуари та витратні матеріали до дошок: засіб для чищення дошки",
                    InventoryNumber = 80947626,
                    Quantity = 32,
                    Price = 691.32m,
                    InventoryDate = new DateTime(2013, 10, 5)
                },
                new Inventory
                {
                    Name = "Аксесуари та витратні матеріали до дошок: набір кольорової крейди",
                    InventoryNumber = 94473861,
                    Quantity = 36,
                    Price = 2036.65m,
                    InventoryDate = new DateTime(2014, 10, 11)
                },
                new Inventory
                {
                    Name = "Аксесуари та витратні матеріали до дошок: набір магнітів",
                    InventoryNumber = 65685000,
                    Quantity = 29,
                    Price = 2448.69m,
                    InventoryDate = new DateTime(2019, 11, 27)
                },
                new Inventory
                {
                    Name = "Аксесуари та витратні матеріали до дошок: набір маркерів з тримачем",
                    InventoryNumber = 22582213,
                    Quantity = 36,
                    Price = 2735.71m,
                    InventoryDate = new DateTime(2016, 8, 27)
                },
                new Inventory
                {
                    Name = "Акустична система",
                    InventoryNumber = 98482301,
                    Quantity = 50,
                    Price = 448.10m,
                    InventoryDate = new DateTime(2017, 11, 1)
                },
                new Inventory
                {
                    Name = "Аптечка медична",
                    InventoryNumber = 72797451,
                    Quantity = 39,
                    Price = 1709.49m,
                    InventoryDate = new DateTime(2015, 2, 27)
                },
                new Inventory
                {
                    Name = "Атласи",
                    InventoryNumber = 39846299,
                    Quantity = 50,
                    Price = 1992.70m,
                    InventoryDate = new DateTime(2016, 5, 22)
                },
                new Inventory
                {
                    Name = "Багатофункціональний пристрій (БФП) у складі принтера, сканера, копіра",
                    InventoryNumber = 39598838,
                    Quantity = 41,
                    Price = 925.81m,
                    InventoryDate = new DateTime(2018, 5, 2)
                },
                new Inventory
                {
                    Name = "Банка з кришкою-лупою",
                    InventoryNumber = 81112775,
                    Quantity = 12,
                    Price = 1527.63m,
                    InventoryDate = new DateTime(2020, 3, 19)
                },
                new Inventory
                {
                    Name = "Бар’єр легкоатлетичний",
                    InventoryNumber = 33873230,
                    Quantity = 14,
                    Price = 2873.77m,
                    InventoryDate = new DateTime(2013, 3, 23)
                },
                new Inventory
                {
                    Name = "Бібліотечка дитячої літератури (дитяча художня література, дитячі енциклопедії, довідники, журнали, газети тощо)",
                    InventoryNumber = 15010643,
                    Quantity = 17,
                    Price = 2437.00m,
                    InventoryDate = new DateTime(2018, 8, 2)
                },
                new Inventory
                {
                    Name = "Бруси гімнастичні паралельні",
                    InventoryNumber = 83673390,
                    Quantity = 9,
                    Price = 1350.99m,
                    InventoryDate = new DateTime(2020, 6, 26)
                },
                new Inventory
                {
                    Name = "Бруси гімнастичні різновисокі",
                    InventoryNumber = 37099923,
                    Quantity = 31,
                    Price = 941.86m,
                    InventoryDate = new DateTime(2012, 3, 25)
                },
                new Inventory
                {
                    Name = "Ваги для зважування (механічні, електронні)",
                    InventoryNumber = 69920900,
                    Quantity = 15,
                    Price = 1842.39m,
                    InventoryDate = new DateTime(2011, 10, 19)
                },
                new Inventory
                {
                    Name = "Витратні матеріали для БФП: набір чорнила (кольорове)",
                    InventoryNumber = 57498889,
                    Quantity = 42,
                    Price = 1731.00m,
                    InventoryDate = new DateTime(2020, 3, 25)
                },
                new Inventory
                {
                    Name = "Витратні матеріали для БФП: набір чорнила (чорне)",
                    InventoryNumber = 97751219,
                    Quantity = 4,
                    Price = 2385.17m,
                    InventoryDate = new DateTime(2020, 6, 3)
                },
                new Inventory
                {
                    Name = "Витратні матеріали для різних видів творчості (наприклад, глина, фарби, альбоми для малювання, кінетичний пісок тощо)",
                    InventoryNumber = 95085950,
                    Quantity = 34,
                    Price = 688.05m,
                    InventoryDate = new DateTime(2013, 11, 7)
                },
                new Inventory
                {
                    Name = "Відкриті шафи для зберігання засобів навчання",
                    InventoryNumber = 64910108,
                    Quantity = 46,
                    Price = 2417.46m,
                    InventoryDate = new DateTime(2017, 7, 17)
                },
                new Inventory
                {
                    Name = "Віяло з зображеннями дорожніх знаків",
                    InventoryNumber = 45384672,
                    Quantity = 5,
                    Price = 332.41m,
                    InventoryDate = new DateTime(2012, 8, 26)
                },
                new Inventory
                {
                    Name = "Волан для бадмінтону",
                    InventoryNumber = 28230619,
                    Quantity = 49,
                    Price = 1533.49m,
                    InventoryDate = new DateTime(2012, 2, 22)
                },
                new Inventory
                {
                    Name = "Ворота для футболу",
                    InventoryNumber = 54723206,
                    Quantity = 47,
                    Price = 2926.64m,
                    InventoryDate = new DateTime(2017, 11, 10)
                },
                new Inventory
                {
                    Name = "Гантелі поролонові",
                    InventoryNumber = 20841620,
                    Quantity = 22,
                    Price = 443.40m,
                    InventoryDate = new DateTime(2013, 3, 15)
                },
                new Inventory
                {
                    Name = "Гантелі розбірні від 1 до 24 кг",
                    InventoryNumber = 69666906,
                    Quantity = 22,
                    Price = 1339.14m,
                    InventoryDate = new DateTime(2015, 6, 26)
                },
                new Inventory
                {
                    Name = "Гербарії: бур’яни",
                    InventoryNumber = 88873316,
                    Quantity = 47,
                    Price = 798.21m,
                    InventoryDate = new DateTime(2022, 6, 3)
                },
                new Inventory
                {
                    Name = "Гербарії: дикорослі, культурні рослини",
                    InventoryNumber = 81524025,
                    Quantity = 44,
                    Price = 1462.48m,
                    InventoryDate = new DateTime(2020, 8, 15)
                },
                new Inventory
                {
                    Name = "Гербарії: лікарські, отруйні рослини",
                    InventoryNumber = 64281942,
                    Quantity = 41,
                    Price = 1651.57m,
                    InventoryDate = new DateTime(2015, 9, 27)
                },
                new Inventory
                {
                    Name = "Гербарії: рослини природних зон України",
                    InventoryNumber = 33373572,
                    Quantity = 3,
                    Price = 113.87m,
                    InventoryDate = new DateTime(2015, 6, 5)
                },
                new Inventory
                {
                    Name = "Гирі від 8 до 32 кг",
                    InventoryNumber = 54051376,
                    Quantity = 10,
                    Price = 2664.23m,
                    InventoryDate = new DateTime(2017, 6, 5)
                },
                new Inventory
                {
                    Name = "Глобуси: будова Землі",
                    InventoryNumber = 53327505,
                    Quantity = 41,
                    Price = 1498.58m,
                    InventoryDate = new DateTime(2017, 4, 6)
                },
                new Inventory
                {
                    Name = "Глобуси: політичний",
                    InventoryNumber = 58921837,
                    Quantity = 27,
                    Price = 1386.60m,
                    InventoryDate = new DateTime(2020, 10, 1)
                },
                new Inventory
                {
                    Name = "Глобуси: фізичний",
                    InventoryNumber = 89929677,
                    Quantity = 12,
                    Price = 2322.82m,
                    InventoryDate = new DateTime(2017, 8, 12)
                },
                new Inventory
                {
                    Name = "Годинник шаховий",
                    InventoryNumber = 99170260,
                    Quantity = 12,
                    Price = 2097.58m,
                    InventoryDate = new DateTime(2016, 2, 13)
                },
                new Inventory
                {
                    Name = "Голка для накачування м’ячів",
                    InventoryNumber = 92392890,
                    Quantity = 22,
                    Price = 1380.86m,
                    InventoryDate = new DateTime(2012, 6, 9)
                },
                new Inventory
                {
                    Name = "Гриф для штанги різної ваги",
                    InventoryNumber = 29740638,
                    Quantity = 12,
                    Price = 1386.33m,
                    InventoryDate = new DateTime(2014, 5, 24)
                },
                new Inventory
                {
                    Name = "Дидактичний матеріал для моделювання алгоритмів",
                    InventoryNumber = 14725810,
                    Quantity = 2,
                    Price = 1711.58m,
                    InventoryDate = new DateTime(2014, 11, 6)
                },
                new Inventory
                {
                    Name = "Диск «Здоров’я»",
                    InventoryNumber = 54559658,
                    Quantity = 19,
                    Price = 909.71m,
                    InventoryDate = new DateTime(2022, 7, 8)
                },
                new Inventory
                {
                    Name = "Диски для штанги різної ваги",
                    InventoryNumber = 44959352,
                    Quantity = 45,
                    Price = 1805.54m,
                    InventoryDate = new DateTime(2016, 7, 6)
                },
                new Inventory
                {
                    Name = "Дитяча художня література іноземною мовою, що вивчається",
                    InventoryNumber = 53529020,
                    Quantity = 50,
                    Price = 2105.98m,
                    InventoryDate = new DateTime(2011, 8, 24)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: акордеон",
                    InventoryNumber = 78941125,
                    Quantity = 23,
                    Price = 250.43m,
                    InventoryDate = new DateTime(2012, 9, 15)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: барабанчик",
                    InventoryNumber = 62729066,
                    Quantity = 30,
                    Price = 2457.33m,
                    InventoryDate = new DateTime(2022, 7, 17)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: баян",
                    InventoryNumber = 86226324,
                    Quantity = 34,
                    Price = 1110.19m,
                    InventoryDate = new DateTime(2016, 1, 22)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: бубен",
                    InventoryNumber = 24695197,
                    Quantity = 47,
                    Price = 2641.39m,
                    InventoryDate = new DateTime(2012, 9, 17)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: дерев’яні ложки",
                    InventoryNumber = 74903519,
                    Quantity = 37,
                    Price = 2054.34m,
                    InventoryDate = new DateTime(2013, 10, 13)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: дзвіночки",
                    InventoryNumber = 25155401,
                    Quantity = 50,
                    Price = 1150.90m,
                    InventoryDate = new DateTime(2019, 7, 13)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: дитячий клавішний синтезатор",
                    InventoryNumber = 25287750,
                    Quantity = 18,
                    Price = 2124.86m,
                    InventoryDate = new DateTime(2019, 5, 28)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: дитячі музичні пластикові трубки",
                    InventoryNumber = 51002767,
                    Quantity = 24,
                    Price = 1065.06m,
                    InventoryDate = new DateTime(2011, 8, 26)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: діатонічні дзвіночки",
                    InventoryNumber = 86954851,
                    Quantity = 50,
                    Price = 2924.76m,
                    InventoryDate = new DateTime(2022, 11, 21)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: ксилофон",
                    InventoryNumber = 95423515,
                    Quantity = 30,
                    Price = 2221.94m,
                    InventoryDate = new DateTime(2016, 6, 27)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: маракаси",
                    InventoryNumber = 87141094,
                    Quantity = 17,
                    Price = 2293.31m,
                    InventoryDate = new DateTime(2015, 10, 16)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: металофон",
                    InventoryNumber = 30150922,
                    Quantity = 6,
                    Price = 370.37m,
                    InventoryDate = new DateTime(2020, 4, 19)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: свистульки",
                    InventoryNumber = 16216578,
                    Quantity = 21,
                    Price = 1648.84m,
                    InventoryDate = new DateTime(2020, 9, 7)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: сопілка",
                    InventoryNumber = 33997181,
                    Quantity = 36,
                    Price = 354.38m,
                    InventoryDate = new DateTime(2019, 5, 24)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: трикутник",
                    InventoryNumber = 51704853,
                    Quantity = 12,
                    Price = 369.73m,
                    InventoryDate = new DateTime(2017, 10, 28)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: трищітки",
                    InventoryNumber = 74237943,
                    Quantity = 35,
                    Price = 2799.07m,
                    InventoryDate = new DateTime(2019, 11, 2)
                },
                new Inventory
                {
                    Name = "Дитячі музичні інструменти: фортепіано",
                    InventoryNumber = 30369913,
                    Quantity = 4,
                    Price = 2145.20m,
                    InventoryDate = new DateTime(2019, 10, 15)
                },
                new Inventory
                {
                    Name = "Документ-камера цифрова",
                    InventoryNumber = 83124564,
                    Quantity = 48,
                    Price = 2077.13m,
                    InventoryDate = new DateTime(2014, 11, 14)
                },
                new Inventory
                {
                    Name = "Доріжка акробатична гумова",
                    InventoryNumber = 28240145,
                    Quantity = 3,
                    Price = 2570.30m,
                    InventoryDate = new DateTime(2016, 3, 20)
                },
                new Inventory
                {
                    Name = "Доріжка бігова",
                    InventoryNumber = 87331138,
                    Quantity = 5,
                    Price = 2854.96m,
                    InventoryDate = new DateTime(2022, 12, 16)
                },
                new Inventory
                {
                    Name = "Дошка аудиторна магнітно-крейдова стаціонарна або магнітно-маркерна стаціонарна/портативна",
                    InventoryNumber = 53011320,
                    Quantity = 29,
                    Price = 1062.34m,
                    InventoryDate = new DateTime(2012, 3, 18)
                },
                new Inventory
                {
                    Name = "Дошка з нотним станом (магнітна)",
                    InventoryNumber = 75502549,
                    Quantity = 16,
                    Price = 1573.88m,
                    InventoryDate = new DateTime(2016, 9, 19)
                },
                new Inventory
                {
                    Name = "Дошка коркова",
                    InventoryNumber = 59415711,
                    Quantity = 25,
                    Price = 2735.46m,
                    InventoryDate = new DateTime(2017, 12, 13)
                },
                new Inventory
                {
                    Name = "Драбина еластична для тренувань",
                    InventoryNumber = 24007769,
                    Quantity = 7,
                    Price = 1095.65m,
                    InventoryDate = new DateTime(2017, 6, 21)
                },
                new Inventory
                {
                    Name = "Електронні освітні ресурси",
                    InventoryNumber = 22869459,
                    Quantity = 12,
                    Price = 1531.74m,
                    InventoryDate = new DateTime(2013, 11, 23)
                },
                new Inventory
                {
                    Name = "Еліптичний ергометр",
                    InventoryNumber = 20987227,
                    Quantity = 15,
                    Price = 509.42m,
                    InventoryDate = new DateTime(2012, 4, 7)
                },
                new Inventory
                {
                    Name = "Еспандер гумовий",
                    InventoryNumber = 28211787,
                    Quantity = 36,
                    Price = 2276.45m,
                    InventoryDate = new DateTime(2011, 8, 17)
                },
                new Inventory
                {
                    Name = "Еспандер для бігу",
                    InventoryNumber = 98784315,
                    Quantity = 36,
                    Price = 1139.48m,
                    InventoryDate = new DateTime(2013, 12, 21)
                },
                new Inventory
                {
                    Name = "Еспандер для ніг",
                    InventoryNumber = 82693793,
                    Quantity = 15,
                    Price = 460.85m,
                    InventoryDate = new DateTime(2016, 10, 23)
                },
                new Inventory
                {
                    Name = "Еспандер для рук",
                    InventoryNumber = 28311463,
                    Quantity = 44,
                    Price = 493.56m,
                    InventoryDate = new DateTime(2017, 12, 28)
                },
                new Inventory
                {
                    Name = "Естафетні палички",
                    InventoryNumber = 22347621,
                    Quantity = 26,
                    Price = 1285.65m,
                    InventoryDate = new DateTime(2018, 5, 12)
                },
                new Inventory
                {
                    Name = "Жердина (різного номіналу)",
                    InventoryNumber = 57637237,
                    Quantity = 19,
                    Price = 656.99m,
                    InventoryDate = new DateTime(2018, 5, 8)
                },
                new Inventory
                {
                    Name = "Жердини для брусів (паралельні, різновисокі)",
                    InventoryNumber = 72573886,
                    Quantity = 5,
                    Price = 1675.32m,
                    InventoryDate = new DateTime(2019, 8, 21)
                },
                new Inventory
                {
                    Name = "Замки для закріплення дисків на грифі штанги",
                    InventoryNumber = 44778421,
                    Quantity = 48,
                    Price = 933.85m,
                    InventoryDate = new DateTime(2019, 5, 17)
                },
                new Inventory
                {
                    Name = "Зображення символів держави",
                    InventoryNumber = 72034214,
                    Quantity = 31,
                    Price = 1558.21m,
                    InventoryDate = new DateTime(2014, 12, 12)
                },
                new Inventory
                {
                    Name = "Ігрові набори для конструювання з різними способами з’єднання деталей",
                    InventoryNumber = 18491509,
                    Quantity = 30,
                    Price = 2200.15m,
                    InventoryDate = new DateTime(2019, 12, 3)
                },
                new Inventory
                {
                    Name = "Календар природи",
                    InventoryNumber = 25810410,
                    Quantity = 15,
                    Price = 1137.70m,
                    InventoryDate = new DateTime(2022, 8, 16)
                },
                new Inventory
                {
                    Name = "Камертон",
                    InventoryNumber = 57601136,
                    Quantity = 6,
                    Price = 2776.31m,
                    InventoryDate = new DateTime(2020, 10, 20)
                },
                new Inventory
                {
                    Name = "Канат гімнастичний для лазіння",
                    InventoryNumber = 32844784,
                    Quantity = 22,
                    Price = 856.30m,
                    InventoryDate = new DateTime(2015, 3, 1)
                },
                new Inventory
                {
                    Name = "Канат для перетягування",
                    InventoryNumber = 71698302,
                    Quantity = 18,
                    Price = 379.70m,
                    InventoryDate = new DateTime(2019, 1, 22)
                },
                new Inventory
                {
                    Name = "Карти настінні: політична світу, адміністративно-територіальна України",
                    InventoryNumber = 90815243,
                    Quantity = 9,
                    Price = 1260.32m,
                    InventoryDate = new DateTime(2019, 8, 22)
                },
                new Inventory
                {
                    Name = "Карти настінні: тематичні (природні зони, корисні копалини, рослинний та тваринний світ, природо-заповідний фонд, історико-етнографічна, народні промисли) карти України",
                    InventoryNumber = 58680880,
                    Quantity = 46,
                    Price = 529.74m,
                    InventoryDate = new DateTime(2016, 8, 10)
                },
                new Inventory
                {
                    Name = "Карти настінні: фізичні (світу, півкуль, України, регіону)",
                    InventoryNumber = 43586957,
                    Quantity = 21,
                    Price = 915.61m,
                    InventoryDate = new DateTime(2018, 4, 9)
                },
                new Inventory
                {
                    Name = "Карти: географічна карта Європи",
                    InventoryNumber = 71441154,
                    Quantity = 42,
                    Price = 2380.84m,
                    InventoryDate = new DateTime(2019, 2, 16)
                },
                new Inventory
                {
                    Name = "Карти: географічна карта країни, мова якої вивчається",
                    InventoryNumber = 25626334,
                    Quantity = 34,
                    Price = 1207.38m,
                    InventoryDate = new DateTime(2018, 2, 17)
                },
                new Inventory
                {
                    Name = "Каса букв та буквосполучень",
                    InventoryNumber = 99138611,
                    Quantity = 18,
                    Price = 897.13m,
                    InventoryDate = new DateTime(2017, 1, 14)
                },
                new Inventory
                {
                    Name = "Каса цифр і лічильного матеріалу на магнітному кріпленні (предметні картинки, геометричні фігури тощо)",
                    InventoryNumber = 25731765,
                    Quantity = 38,
                    Price = 1573.94m,
                    InventoryDate = new DateTime(2012, 4, 26)
                },
                new Inventory
                {
                    Name = "Квадрат сотенний (математичний куб)",
                    InventoryNumber = 60244605,
                    Quantity = 40,
                    Price = 2479.86m,
                    InventoryDate = new DateTime(2022, 1, 23)
                },
                new Inventory
                {
                    Name = "Кеглі",
                    InventoryNumber = 77825768,
                    Quantity = 48,
                    Price = 367.32m,
                    InventoryDate = new DateTime(2019, 2, 6)
                },
                new Inventory
                {
                    Name = "Килим з дорожньою розміткою",
                    InventoryNumber = 97538938,
                    Quantity = 5,
                    Price = 276.89m,
                    InventoryDate = new DateTime(2020, 8, 27)
                },
                new Inventory
                {
                    Name = "Килимок (дитячий каремат) або килимок-конструктор з пазлів для занять на вулиці",
                    InventoryNumber = 45912510,
                    Quantity = 43,
                    Price = 2450.01m,
                    InventoryDate = new DateTime(2017, 6, 7)
                },
                new Inventory
                {
                    Name = "Кільце баскетбольне",
                    InventoryNumber = 15497949,
                    Quantity = 39,
                    Price = 1136.90m,
                    InventoryDate = new DateTime(2019, 7, 15)
                },
                new Inventory
                {
                    Name = "Кінь гімнастичний маховий",
                    InventoryNumber = 81138164,
                    Quantity = 27,
                    Price = 1522.10m,
                    InventoryDate = new DateTime(2020, 3, 9)
                },
                new Inventory
                {
                    Name = "Козел для опорних стрибків",
                    InventoryNumber = 75988809,
                    Quantity = 12,
                    Price = 1907.64m,
                    InventoryDate = new DateTime(2017, 12, 4)
                },
                new Inventory
                {
                    Name = "Колекції: види паперу",
                    InventoryNumber = 55135769,
                    Quantity = 10,
                    Price = 765.68m,
                    InventoryDate = new DateTime(2011, 8, 28)
                },
                new Inventory
                {
                    Name = "Колекції: види тканин та ниток, зразки сировини для їх виготовлення",
                    InventoryNumber = 49587397,
                    Quantity = 16,
                    Price = 536.02m,
                    InventoryDate = new DateTime(2017, 10, 14)
                },
                new Inventory
                {
                    Name = "Колекції: витинанки",
                    InventoryNumber = 19656035,
                    Quantity = 50,
                    Price = 1033.52m,
                    InventoryDate = new DateTime(2017, 11, 8)
                },
                new Inventory
                {
                    Name = "Колекції: гірські породи",
                    InventoryNumber = 50090063,
                    Quantity = 49,
                    Price = 1260.58m,
                    InventoryDate = new DateTime(2017, 1, 17)
                },
                new Inventory
                {
                    Name = "Колекції: ґрунти",
                    InventoryNumber = 73542433,
                    Quantity = 5,
                    Price = 2552.35m,
                    InventoryDate = new DateTime(2019, 2, 11)
                },
                new Inventory
                {
                    Name = "Колекції: кора дерев",
                    InventoryNumber = 38949874,
                    Quantity = 41,
                    Price = 2712.60m,
                    InventoryDate = new DateTime(2018, 1, 8)
                },
                new Inventory
                {
                    Name = "Колекції: корисні копалини та продукти їх переробки",
                    InventoryNumber = 12542519,
                    Quantity = 49,
                    Price = 504.93m,
                    InventoryDate = new DateTime(2015, 5, 7)
                },
                new Inventory
                {
                    Name = "Колекції: морське дно",
                    InventoryNumber = 42241918,
                    Quantity = 11,
                    Price = 2336.60m,
                    InventoryDate = new DateTime(2011, 10, 8)
                },
                new Inventory
                {
                    Name = "Колекції: насіння та плоди (овочевих, зернових, прядивних, плодово-ягідних, квітково-декоративних культур)",
                    InventoryNumber = 99911688,
                    Quantity = 8,
                    Price = 1084.59m,
                    InventoryDate = new DateTime(2014, 2, 28)
                },
                new Inventory
                {
                    Name = "Колекції: писанки тощо",
                    InventoryNumber = 76967789,
                    Quantity = 46,
                    Price = 614.27m,
                    InventoryDate = new DateTime(2017, 5, 15)
                },
                new Inventory
                {
                    Name = "Колекції: породи деревини",
                    InventoryNumber = 21942123,
                    Quantity = 35,
                    Price = 666.00m,
                    InventoryDate = new DateTime(2019, 4, 27)
                },
                new Inventory
                {
                    Name = "Колекції: розвиток комах",
                    InventoryNumber = 63223943,
                    Quantity = 22,
                    Price = 2787.04m,
                    InventoryDate = new DateTime(2011, 7, 26)
                },
                new Inventory
                {
                    Name = "Колода гімнастична",
                    InventoryNumber = 23663107,
                    Quantity = 3,
                    Price = 1864.97m,
                    InventoryDate = new DateTime(2012, 3, 23)
                },
                new Inventory
                {
                    Name = "Комп’ютерний стіл / стіл для принтера",
                    InventoryNumber = 84719268,
                    Quantity = 35,
                    Price = 994.37m,
                    InventoryDate = new DateTime(2017, 9, 28)
                },
                new Inventory
                {
                    Name = "Компас шкільний",
                    InventoryNumber = 14528044,
                    Quantity = 49,
                    Price = 2009.49m,
                    InventoryDate = new DateTime(2022, 12, 5)
                },
                new Inventory
                {
                    Name = "Комплект для гри в настільний теніс",
                    InventoryNumber = 19901298,
                    Quantity = 20,
                    Price = 1803.52m,
                    InventoryDate = new DateTime(2017, 4, 19)
                },
                new Inventory
                {
                    Name = "Комплект навчально-наочних засобів для навчання грамоти/письма (на магнітах): вимоги до правильної постави під час письма та користування письмовим приладдям",
                    InventoryNumber = 15413242,
                    Quantity = 29,
                    Price = 2876.75m,
                    InventoryDate = new DateTime(2020, 6, 10)
                },
                new Inventory
                {
                    Name = "Комплект навчально-наочних засобів для навчання грамоти/письма (на магнітах): зразки з’єднань букв (нижнього, середнього, верхнього)",
                    InventoryNumber = 40493605,
                    Quantity = 48,
                    Price = 1828.36m,
                    InventoryDate = new DateTime(2015, 3, 3)
                },
                new Inventory
                {
                    Name = "Комплект навчально-наочних засобів для навчання грамоти/письма (на магнітах): зразки каліграфічного письма букв (великих та малих) та їх з’єднань українського алфавіту та мов корінних народів, національних меншин",
                    InventoryNumber = 44009264,
                    Quantity = 30,
                    Price = 2020.64m,
                    InventoryDate = new DateTime(2015, 10, 20)
                },
                new Inventory
                {
                    Name = "Комплект навчально-наочних засобів для навчання грамоти/письма (на магнітах): український алфавіт (друковані й рукописні літери, великі і малі)",
                    InventoryNumber = 31200561,
                    Quantity = 27,
                    Price = 2859.92m,
                    InventoryDate = new DateTime(2013, 9, 9)
                },
                new Inventory
                {
                    Name = "Комплект навчально-наочних засобів для навчання грамоти/письма (на магнітах): флеш-картки",
                    InventoryNumber = 37227276,
                    Quantity = 34,
                    Price = 1545.65m,
                    InventoryDate = new DateTime(2019, 12, 5)
                },
                new Inventory
                {
                    Name = "Комплекти для рольових ігор відповідно до тем навчальної програми",
                    InventoryNumber = 40674238,
                    Quantity = 27,
                    Price = 2362.68m,
                    InventoryDate = new DateTime(2022, 2, 19)
                },
                new Inventory
                {
                    Name = "Комплекти лічильного матеріалу роздаткові для: вивчення складу числа",
                    InventoryNumber = 85691113,
                    Quantity = 1,
                    Price = 918.37m,
                    InventoryDate = new DateTime(2022, 4, 23)
                },
                new Inventory
                {
                    Name = "Комплекти лічильного матеріалу роздаткові для: лічби від 0 до 1000",
                    InventoryNumber = 43897945,
                    Quantity = 31,
                    Price = 2331.34m,
                    InventoryDate = new DateTime(2017, 7, 10)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: безпека життєдіяльності",
                    InventoryNumber = 55510190,
                    Quantity = 36,
                    Price = 1792.95m,
                    InventoryDate = new DateTime(2020, 5, 21)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: безпека на дорозі",
                    InventoryNumber = 74227949,
                    Quantity = 41,
                    Price = 2547.20m,
                    InventoryDate = new DateTime(2018, 7, 22)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: будова тіла людини",
                    InventoryNumber = 87423584,
                    Quantity = 29,
                    Price = 118.96m,
                    InventoryDate = new DateTime(2015, 2, 19)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: екологічна культура, дбайливе ставлення до довкілля",
                    InventoryNumber = 39430792,
                    Quantity = 22,
                    Price = 1480.47m,
                    InventoryDate = new DateTime(2022, 7, 23)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: емоції людини",
                    InventoryNumber = 46529394,
                    Quantity = 14,
                    Price = 898.56m,
                    InventoryDate = new DateTime(2012, 11, 4)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: жива природа",
                    InventoryNumber = 57193513,
                    Quantity = 37,
                    Price = 424.84m,
                    InventoryDate = new DateTime(2012, 4, 7)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: здоров’я людини",
                    InventoryNumber = 63486420,
                    Quantity = 22,
                    Price = 554.65m,
                    InventoryDate = new DateTime(2011, 3, 9)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: здоровий спосіб життя",
                    InventoryNumber = 83973220,
                    Quantity = 9,
                    Price = 1503.36m,
                    InventoryDate = new DateTime(2016, 2, 20)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: Земля",
                    InventoryNumber = 80552271,
                    Quantity = 48,
                    Price = 1642.83m,
                    InventoryDate = new DateTime(2012, 3, 4)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: корисні і шкідливі звички",
                    InventoryNumber = 88274469,
                    Quantity = 26,
                    Price = 611.26m,
                    InventoryDate = new DateTime(2019, 7, 3)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: надання домедичної допомоги",
                    InventoryNumber = 51957451,
                    Quantity = 28,
                    Price = 2874.10m,
                    InventoryDate = new DateTime(2019, 2, 23)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: небезпечні тварини",
                    InventoryNumber = 68074845,
                    Quantity = 36,
                    Price = 971.36m,
                    InventoryDate = new DateTime(2019, 11, 19)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: нежива природа",
                    InventoryNumber = 56311650,
                    Quantity = 14,
                    Price = 640.76m,
                    InventoryDate = new DateTime(2013, 3, 11)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: особиста гігієна школяра",
                    InventoryNumber = 38586471,
                    Quantity = 44,
                    Price = 627.06m,
                    InventoryDate = new DateTime(2017, 5, 26)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: охорона природи",
                    InventoryNumber = 62934578,
                    Quantity = 21,
                    Price = 1530.19m,
                    InventoryDate = new DateTime(2022, 4, 22)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: пори року",
                    InventoryNumber = 15770219,
                    Quantity = 40,
                    Price = 2760.75m,
                    InventoryDate = new DateTime(2011, 8, 20)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: правила поведінки в природному, техногенному та соціальному оточенні",
                    InventoryNumber = 40762679,
                    Quantity = 5,
                    Price = 152.67m,
                    InventoryDate = new DateTime(2018, 11, 11)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: правила пожежної безпеки",
                    InventoryNumber = 45931469,
                    Quantity = 1,
                    Price = 425.08m,
                    InventoryDate = new DateTime(2020, 8, 28)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: правильне харчування",
                    InventoryNumber = 94875925,
                    Quantity = 35,
                    Price = 1033.01m,
                    InventoryDate = new DateTime(2019, 6, 18)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: праця людей",
                    InventoryNumber = 93142140,
                    Quantity = 44,
                    Price = 573.82m,
                    InventoryDate = new DateTime(2011, 2, 21)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: система органів тіла людини",
                    InventoryNumber = 37584224,
                    Quantity = 33,
                    Price = 1311.70m,
                    InventoryDate = new DateTime(2016, 9, 1)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: соціальна складова здоров’я",
                    InventoryNumber = 77209399,
                    Quantity = 23,
                    Price = 2093.53m,
                    InventoryDate = new DateTime(2016, 11, 3)
                },
                new Inventory
                {
                    Name = "Комплекти плакатів: фізична складова здоров’я",
                    InventoryNumber = 42599149,
                    Quantity = 31,
                    Price = 2943.79m,
                    InventoryDate = new DateTime(2019, 3, 11)
                },
                new Inventory
                {
                    Name = "Конструктори для вивчення різних конструкцій та механізмів",
                    InventoryNumber = 82535336,
                    Quantity = 36,
                    Price = 2474.06m,
                    InventoryDate = new DateTime(2016, 1, 17)
                },
                new Inventory
                {
                    Name = "Контейнери для роздаткового матеріалу / конструкторів",
                    InventoryNumber = 50471865,
                    Quantity = 13,
                    Price = 1018.72m,
                    InventoryDate = new DateTime(2014, 2, 20)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: ваги математичні (математичний баланс)",
                    InventoryNumber = 57980657,
                    Quantity = 15,
                    Price = 2840.62m,
                    InventoryDate = new DateTime(2014, 5, 7)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: лінійка (не менше 15 см)",
                    InventoryNumber = 97414955,
                    Quantity = 43,
                    Price = 906.12m,
                    InventoryDate = new DateTime(2011, 2, 4)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: метр з сантиметровим діленням",
                    InventoryNumber = 36030985,
                    Quantity = 23,
                    Price = 2506.85m,
                    InventoryDate = new DateTime(2013, 6, 25)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: метр навчальний з кольоровою шкалою",
                    InventoryNumber = 69651603,
                    Quantity = 7,
                    Price = 2086.27m,
                    InventoryDate = new DateTime(2019, 3, 13)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: рулетка (на менше 1 м)",
                    InventoryNumber = 92737359,
                    Quantity = 39,
                    Price = 1888.76m,
                    InventoryDate = new DateTime(2019, 2, 14)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: трикутники (45°, 30°-60°)",
                    InventoryNumber = 74978092,
                    Quantity = 24,
                    Price = 1048.27m,
                    InventoryDate = new DateTime(2022, 12, 16)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні інструменти: циркуль",
                    InventoryNumber = 23833649,
                    Quantity = 4,
                    Price = 741.10m,
                    InventoryDate = new DateTime(2019, 10, 10)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: набір годинників пісочних (не менше 3-х від 1 до 5 хв.)",
                    InventoryNumber = 20122155,
                    Quantity = 37,
                    Price = 1795.95m,
                    InventoryDate = new DateTime(2018, 3, 17)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: набір мірного посуду (з не крихкого матеріалу) об’ємом від 50 до 500 мл",
                    InventoryNumber = 79922271,
                    Quantity = 11,
                    Price = 2416.73m,
                    InventoryDate = new DateTime(2015, 8, 28)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: спідометр",
                    InventoryNumber = 13293337,
                    Quantity = 38,
                    Price = 259.99m,
                    InventoryDate = new DateTime(2016, 5, 18)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: терези демонстраційні з набором важків",
                    InventoryNumber = 65691747,
                    Quantity = 8,
                    Price = 2311.75m,
                    InventoryDate = new DateTime(2019, 5, 19)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: терези з набором важків",
                    InventoryNumber = 83317799,
                    Quantity = 16,
                    Price = 1486.30m,
                    InventoryDate = new DateTime(2013, 2, 11)
                },
                new Inventory
                {
                    Name = "Контрольно-вимірювальні прилади: термометр",
                    InventoryNumber = 68392915,
                    Quantity = 46,
                    Price = 992.52m,
                    InventoryDate = new DateTime(2014, 9, 15)
                },
                new Inventory
                {
                    Name = "Конус поролоновий",
                    InventoryNumber = 86569280,
                    Quantity = 12,
                    Price = 1629.38m,
                    InventoryDate = new DateTime(2011, 1, 25)
                },
                new Inventory
                {
                    Name = "Корзина для м’ячів",
                    InventoryNumber = 71379116,
                    Quantity = 14,
                    Price = 2552.19m,
                    InventoryDate = new DateTime(2014, 12, 7)
                },
                new Inventory
                {
                    Name = "Корзина для тенісних м’ячів",
                    InventoryNumber = 55955397,
                    Quantity = 32,
                    Price = 2159.24m,
                    InventoryDate = new DateTime(2017, 2, 19)
                },
                new Inventory
                {
                    Name = "Лабораторний набір для дослідження властивостей води, різних речовин та тіл",
                    InventoryNumber = 62041667,
                    Quantity = 16,
                    Price = 1168.49m,
                    InventoryDate = new DateTime(2022, 11, 27)
                },
                new Inventory
                {
                    Name = "Лабораторний набір з вивчення елементарних фізичних явищ (сила, рух, швидкість тощо)",
                    InventoryNumber = 21444191,
                    Quantity = 26,
                    Price = 444.57m,
                    InventoryDate = new DateTime(2015, 10, 20)
                },
                new Inventory
                {
                    Name = "Лабораторний набір з вивчення явища магнетизму",
                    InventoryNumber = 72597170,
                    Quantity = 34,
                    Price = 275.69m,
                    InventoryDate = new DateTime(2016, 8, 4)
                },
                new Inventory
                {
                    Name = "Ламінатор",
                    InventoryNumber = 19582823,
                    Quantity = 30,
                    Price = 440.85m,
                    InventoryDate = new DateTime(2020, 2, 3)
                },
                new Inventory
                {
                    Name = "Лічильний матеріал (наприклад, набір Кюізенера, геометричні фігури тощо)",
                    InventoryNumber = 83681282,
                    Quantity = 25,
                    Price = 1112.08m,
                    InventoryDate = new DateTime(2013, 10, 13)
                },
                new Inventory
                {
                    Name = "Лупа ручна шкільна",
                    InventoryNumber = 70360565,
                    Quantity = 3,
                    Price = 2341.90m,
                    InventoryDate = new DateTime(2018, 10, 11)
                },
                new Inventory
                {
                    Name = "М’яке крісло-мішок",
                    InventoryNumber = 23757321,
                    Quantity = 47,
                    Price = 1178.72m,
                    InventoryDate = new DateTime(2017, 11, 16)
                },
                new Inventory
                {
                    Name = "М’яч волейбольний",
                    InventoryNumber = 79116293,
                    Quantity = 13,
                    Price = 1434.87m,
                    InventoryDate = new DateTime(2012, 8, 8)
                },
                new Inventory
                {
                    Name = "М’яч для метань тренувальний різної ваги гумовий",
                    InventoryNumber = 25750420,
                    Quantity = 49,
                    Price = 2911.20m,
                    InventoryDate = new DateTime(2017, 7, 16)
                },
                new Inventory
                {
                    Name = "М’яч для тенісу настільного",
                    InventoryNumber = 59767372,
                    Quantity = 35,
                    Price = 613.94m,
                    InventoryDate = new DateTime(2014, 2, 11)
                },
                new Inventory
                {
                    Name = "М’яч тенісний",
                    InventoryNumber = 63880971,
                    Quantity = 44,
                    Price = 2240.38m,
                    InventoryDate = new DateTime(2018, 10, 22)
                },
                new Inventory
                {
                    Name = "М’ячі баскетбольні різного діаметра",
                    InventoryNumber = 94474885,
                    Quantity = 3,
                    Price = 2706.98m,
                    InventoryDate = new DateTime(2018, 5, 21)
                },
                new Inventory
                {
                    Name = "М’ячі гумові різного діаметра",
                    InventoryNumber = 77954737,
                    Quantity = 26,
                    Price = 2087.13m,
                    InventoryDate = new DateTime(2017, 2, 25)
                },
                new Inventory
                {
                    Name = "М’ячі футбольні різного діаметра",
                    InventoryNumber = 67181710,
                    Quantity = 35,
                    Price = 2562.19m,
                    InventoryDate = new DateTime(2011, 2, 23)
                },
                new Inventory
                {
                    Name = "Магніт смуговий лабораторний",
                    InventoryNumber = 54599960,
                    Quantity = 5,
                    Price = 1674.55m,
                    InventoryDate = new DateTime(2013, 2, 3)
                },
                new Inventory
                {
                    Name = "Магнітна дошка фліпчарт / магнітна дошка-мольберт",
                    InventoryNumber = 29347034,
                    Quantity = 44,
                    Price = 2477.11m,
                    InventoryDate = new DateTime(2022, 12, 2)
                },
                new Inventory
                {
                    Name = "Манометр (для вимірювання тиску в м’ячах)",
                    InventoryNumber = 82019559,
                    Quantity = 6,
                    Price = 1550.29m,
                    InventoryDate = new DateTime(2018, 3, 17)
                },
                new Inventory
                {
                    Name = "Масажні килимки, доріжки",
                    InventoryNumber = 44815397,
                    Quantity = 25,
                    Price = 1717.79m,
                    InventoryDate = new DateTime(2013, 11, 28)
                },
                new Inventory
                {
                    Name = "Мат гімнастичний різного розміру",
                    InventoryNumber = 87468665,
                    Quantity = 49,
                    Price = 1783.26m,
                    InventoryDate = new DateTime(2014, 8, 12)
                },
                new Inventory
                {
                    Name = "Математичне віяло (від 1 до 20)",
                    InventoryNumber = 58502224,
                    Quantity = 27,
                    Price = 2348.70m,
                    InventoryDate = new DateTime(2022, 3, 19)
                },
                new Inventory
                {
                    Name = "Математичне дзеркало",
                    InventoryNumber = 30481103,
                    Quantity = 36,
                    Price = 2864.87m,
                    InventoryDate = new DateTime(2019, 6, 16)
                },
                new Inventory
                {
                    Name = "Математичний магнітно-маркерний планшет",
                    InventoryNumber = 92590053,
                    Quantity = 39,
                    Price = 1606.64m,
                    InventoryDate = new DateTime(2018, 10, 1)
                },
                new Inventory
                {
                    Name = "Метроном механічний",
                    InventoryNumber = 43750317,
                    Quantity = 47,
                    Price = 1506.26m,
                    InventoryDate = new DateTime(2013, 9, 17)
                },
                new Inventory
                {
                    Name = "Мікроскоп шкільний",
                    InventoryNumber = 33145096,
                    Quantity = 13,
                    Price = 814.29m,
                    InventoryDate = new DateTime(2017, 5, 4)
                },
                new Inventory
                {
                    Name = "Мікрофон",
                    InventoryNumber = 55706837,
                    Quantity = 45,
                    Price = 733.27m,
                    InventoryDate = new DateTime(2015, 6, 14)
                },
                new Inventory
                {
                    Name = "Місток для опорних стрибків",
                    InventoryNumber = 34878676,
                    Quantity = 44,
                    Price = 2808.40m,
                    InventoryDate = new DateTime(2020, 6, 14)
                },
                new Inventory
                {
                    Name = "Місце приземлення для стрибків у висоту (мати)",
                    InventoryNumber = 67423388,
                    Quantity = 29,
                    Price = 138.95m,
                    InventoryDate = new DateTime(2011, 4, 3)
                },
                new Inventory
                {
                    Name = "Мобільна метеостанція",
                    InventoryNumber = 53152312,
                    Quantity = 11,
                    Price = 626.64m,
                    InventoryDate = new DateTime(2017, 12, 21)
                },
                new Inventory
                {
                    Name = "Мобільний стелаж",
                    InventoryNumber = 94643085,
                    Quantity = 14,
                    Price = 2510.22m,
                    InventoryDate = new DateTime(2012, 9, 26)
                },
                new Inventory
                {
                    Name = "Моделі: Скелет людини",
                    InventoryNumber = 49238628,
                    Quantity = 34,
                    Price = 1083.69m,
                    InventoryDate = new DateTime(2020, 4, 17)
                },
                new Inventory
                {
                    Name = "Модель будови рослин",
                    InventoryNumber = 39457345,
                    Quantity = 27,
                    Price = 986.13m,
                    InventoryDate = new DateTime(2011, 5, 26)
                },
                new Inventory
                {
                    Name = "Модель демонстраційного механічного годинника (24 години, не менше 2-х стрілок)",
                    InventoryNumber = 17772082,
                    Quantity = 28,
                    Price = 1404.49m,
                    InventoryDate = new DateTime(2022, 8, 4)
                },
                new Inventory
                {
                    Name = "Модель механічного годинника (24 години, не менше 2-х стрілок)",
                    InventoryNumber = 63391372,
                    Quantity = 12,
                    Price = 2825.39m,
                    InventoryDate = new DateTime(2012, 1, 5)
                },
                new Inventory
                {
                    Name = "Модель світлофора, набір дорожніх знаків",
                    InventoryNumber = 95398668,
                    Quantity = 47,
                    Price = 2862.21m,
                    InventoryDate = new DateTime(2016, 6, 6)
                },
                new Inventory
                {
                    Name = "Модель тіла людини, розбірна",
                    InventoryNumber = 67746319,
                    Quantity = 5,
                    Price = 624.77m,
                    InventoryDate = new DateTime(2011, 5, 23)
                },
                new Inventory
                {
                    Name = "Модель, що відображає кругообіг води в природі",
                    InventoryNumber = 24321219,
                    Quantity = 41,
                    Price = 816.97m,
                    InventoryDate = new DateTime(2015, 9, 23)
                },
                new Inventory
                {
                    Name = "Модель, що відображує гігієну зубів",
                    InventoryNumber = 79232647,
                    Quantity = 22,
                    Price = 2540.57m,
                    InventoryDate = new DateTime(2013, 6, 12)
                },
                new Inventory
                {
                    Name = "Модель-аплікація «Числова пряма»",
                    InventoryNumber = 34700067,
                    Quantity = 48,
                    Price = 1963.07m,
                    InventoryDate = new DateTime(2018, 8, 13)
                },
                new Inventory
                {
                    Name = "Модель-фартух, що відображає внутрішню будову тіла людини",
                    InventoryNumber = 97773162,
                    Quantity = 13,
                    Price = 1810.91m,
                    InventoryDate = new DateTime(2013, 11, 11)
                },
                new Inventory
                {
                    Name = "Мольберти",
                    InventoryNumber = 66697023,
                    Quantity = 41,
                    Price = 292.25m,
                    InventoryDate = new DateTime(2012, 5, 8)
                },
                new Inventory
                {
                    Name = "Мультимедійний проєктор",
                    InventoryNumber = 76682791,
                    Quantity = 3,
                    Price = 524.60m,
                    InventoryDate = new DateTime(2017, 11, 23)
                },
                new Inventory
                {
                    Name = "Набір букв на магнітах (англійська, німецька, французька, іспанська тощо)",
                    InventoryNumber = 89520288,
                    Quantity = 8,
                    Price = 1624.21m,
                    InventoryDate = new DateTime(2012, 5, 19)
                },
                new Inventory
                {
                    Name = "Набір геометричних тіл та фігур",
                    InventoryNumber = 38811391,
                    Quantity = 35,
                    Price = 1357.15m,
                    InventoryDate = new DateTime(2017, 3, 15)
                },
                new Inventory
                {
                    Name = "Набір для вивчення часток і дробів",
                    InventoryNumber = 59392422,
                    Quantity = 47,
                    Price = 1572.85m,
                    InventoryDate = new DateTime(2018, 1, 4)
                },
                new Inventory
                {
                    Name = "Набір для розвитку алгоритмічного мислення",
                    InventoryNumber = 31031152,
                    Quantity = 49,
                    Price = 2810.36m,
                    InventoryDate = new DateTime(2020, 10, 25)
                },
                new Inventory
                {
                    Name = "Набір для спостереження за розвитком і ростом рослин",
                    InventoryNumber = 75868280,
                    Quantity = 33,
                    Price = 121.93m,
                    InventoryDate = new DateTime(2017, 7, 13)
                },
                new Inventory
                {
                    Name = "Набір іграшок: літературні персонажі",
                    InventoryNumber = 33688155,
                    Quantity = 32,
                    Price = 373.01m,
                    InventoryDate = new DateTime(2020, 10, 13)
                },
                new Inventory
                {
                    Name = "Набір іграшок: тварини дикі та домашні (реалістичні)",
                    InventoryNumber = 93916618,
                    Quantity = 42,
                    Price = 2554.97m,
                    InventoryDate = new DateTime(2022, 11, 6)
                },
                new Inventory
                {
                    Name = "Набір інструментів, приладів та пристосувань для догляду за кімнатними рослинами",
                    InventoryNumber = 95687615,
                    Quantity = 4,
                    Price = 1776.01m,
                    InventoryDate = new DateTime(2017, 7, 14)
                },
                new Inventory
                {
                    Name = "Набір лабораторний",
                    InventoryNumber = 79875262,
                    Quantity = 1,
                    Price = 133.34m,
                    InventoryDate = new DateTime(2011, 5, 25)
                },
                new Inventory
                {
                    Name = "Набір лабораторний демонстраційний",
                    InventoryNumber = 89693400,
                    Quantity = 1,
                    Price = 1092.63m,
                    InventoryDate = new DateTime(2018, 5, 22)
                },
                new Inventory
                {
                    Name = "Набір ляльок, фігур та декорацій для лялькового театру: в національному одязі (різнонаціональна)",
                    InventoryNumber = 68732113,
                    Quantity = 38,
                    Price = 563.97m,
                    InventoryDate = new DateTime(2022, 4, 18)
                },
                new Inventory
                {
                    Name = "Набір ляльок, фігур та декорацій для лялькового театру: літературні та казкові персонажі",
                    InventoryNumber = 48313806,
                    Quantity = 36,
                    Price = 435.52m,
                    InventoryDate = new DateTime(2011, 10, 6)
                },
                new Inventory
                {
                    Name = "Набір ляльок, фігур та декорацій для лялькового театру: ляльки-рукавички для лялькового театру",
                    InventoryNumber = 37317898,
                    Quantity = 15,
                    Price = 355.91m,
                    InventoryDate = new DateTime(2019, 11, 21)
                },
                new Inventory
                {
                    Name = "Набір ляльок, фігур та декорацій для лялькового театру: маски казкових героїв та тварин",
                    InventoryNumber = 38492141,
                    Quantity = 9,
                    Price = 301.89m,
                    InventoryDate = new DateTime(2016, 10, 15)
                },
                new Inventory
                {
                    Name = "Набір магнітних нотних знаків",
                    InventoryNumber = 49279347,
                    Quantity = 13,
                    Price = 732.10m,
                    InventoryDate = new DateTime(2013, 12, 23)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: головоломки тощо",
                    InventoryNumber = 19185873,
                    Quantity = 15,
                    Price = 1299.18m,
                    InventoryDate = new DateTime(2011, 4, 4)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: кубики для настільної гри з піктограмами тощо",
                    InventoryNumber = 13784375,
                    Quantity = 48,
                    Price = 2347.99m,
                    InventoryDate = new DateTime(2022, 2, 25)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: літературне лото, доміно",
                    InventoryNumber = 43382992,
                    Quantity = 35,
                    Price = 742.76m,
                    InventoryDate = new DateTime(2019, 9, 4)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: маршрутні ігри",
                    InventoryNumber = 82011623,
                    Quantity = 7,
                    Price = 416.38m,
                    InventoryDate = new DateTime(2017, 4, 7)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: мовне лото, доміно",
                    InventoryNumber = 72621132,
                    Quantity = 6,
                    Price = 2898.58m,
                    InventoryDate = new DateTime(2018, 7, 2)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: ребуси, головоломки",
                    InventoryNumber = 45796035,
                    Quantity = 11,
                    Price = 2361.00m,
                    InventoryDate = new DateTime(2014, 12, 15)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: розрізні пазли / картинки",
                    InventoryNumber = 82290174,
                    Quantity = 11,
                    Price = 111.59m,
                    InventoryDate = new DateTime(2022, 9, 27)
                },
                new Inventory
                {
                    Name = "Набір настільних розвивальних ігор: шахи, шашки",
                    InventoryNumber = 96607636,
                    Quantity = 17,
                    Price = 215.44m,
                    InventoryDate = new DateTime(2013, 2, 3)
                },
                new Inventory
                {
                    Name = "Набір посуду для сервірування",
                    InventoryNumber = 36867760,
                    Quantity = 32,
                    Price = 1662.32m,
                    InventoryDate = new DateTime(2012, 5, 23)
                },
                new Inventory
                {
                    Name = "Набір таблиць",
                    InventoryNumber = 72508470,
                    Quantity = 25,
                    Price = 2885.04m,
                    InventoryDate = new DateTime(2012, 5, 5)
                },
                new Inventory
                {
                    Name = "Набір таблиць (для мов, що вивчаються) на магнітах: алфавіт",
                    InventoryNumber = 25139120,
                    Quantity = 20,
                    Price = 1247.41m,
                    InventoryDate = new DateTime(2018, 7, 26)
                },
                new Inventory
                {
                    Name = "Набір таблиць (для мов, що вивчаються) на магнітах: граматичні, до розділів граматичного матеріалу, передбаченого навчальною програмою",
                    InventoryNumber = 18022672,
                    Quantity = 3,
                    Price = 2173.31m,
                    InventoryDate = new DateTime(2018, 12, 15)
                },
                new Inventory
                {
                    Name = "Набір таблиць (для мов, що вивчаються) на магнітах: календар",
                    InventoryNumber = 21575653,
                    Quantity = 42,
                    Price = 1332.62m,
                    InventoryDate = new DateTime(2012, 8, 28)
                },
                new Inventory
                {
                    Name = "Набір таблиць (для мов, що вивчаються) на магнітах: транскрипційні знаки",
                    InventoryNumber = 29044980,
                    Quantity = 24,
                    Price = 2865.68m,
                    InventoryDate = new DateTime(2020, 5, 27)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): величини та їх одиниці",
                    InventoryNumber = 56481256,
                    Quantity = 15,
                    Price = 2418.91m,
                    InventoryDate = new DateTime(2022, 8, 14)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): геометричні фігури, геометричні тіла та їх властивості",
                    InventoryNumber = 59105575,
                    Quantity = 32,
                    Price = 2469.12m,
                    InventoryDate = new DateTime(2020, 10, 10)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): дії над числами, взаємозв’язок дій над числами",
                    InventoryNumber = 60553581,
                    Quantity = 12,
                    Price = 2300.28m,
                    InventoryDate = new DateTime(2012, 2, 4)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): задачі, типові задачі, опорні схеми",
                    InventoryNumber = 44241966,
                    Quantity = 29,
                    Price = 1943.57m,
                    InventoryDate = new DateTime(2011, 12, 17)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): закони та властивості арифметичних дій",
                    InventoryNumber = 44460561,
                    Quantity = 27,
                    Price = 2542.12m,
                    InventoryDate = new DateTime(2022, 12, 26)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): зразки каліграфічного письма цифр і знаків",
                    InventoryNumber = 30028615,
                    Quantity = 15,
                    Price = 165.72m,
                    InventoryDate = new DateTime(2016, 3, 8)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): лічба (кількісна, порядкова)",
                    InventoryNumber = 22240311,
                    Quantity = 5,
                    Price = 1323.84m,
                    InventoryDate = new DateTime(2013, 3, 11)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): математичні вирази",
                    InventoryNumber = 71856964,
                    Quantity = 15,
                    Price = 171.46m,
                    InventoryDate = new DateTime(2012, 8, 12)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): набір / таблиця, що відображає частину цілого в крузі",
                    InventoryNumber = 31963854,
                    Quantity = 5,
                    Price = 1101.46m,
                    InventoryDate = new DateTime(2020, 7, 23)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): набір для вивчення розряду числа, таблиця розрядів",
                    InventoryNumber = 37363139,
                    Quantity = 24,
                    Price = 1014.79m,
                    InventoryDate = new DateTime(2013, 8, 3)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): нумерація чисел, склад числа",
                    InventoryNumber = 69443627,
                    Quantity = 29,
                    Price = 2010.01m,
                    InventoryDate = new DateTime(2020, 8, 15)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): ознаки, властивості, відношення предметів",
                    InventoryNumber = 38695142,
                    Quantity = 5,
                    Price = 158.58m,
                    InventoryDate = new DateTime(2016, 12, 2)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): рівняння",
                    InventoryNumber = 73027264,
                    Quantity = 8,
                    Price = 1222.34m,
                    InventoryDate = new DateTime(2013, 5, 20)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): розташування у просторі й на площині",
                    InventoryNumber = 60334800,
                    Quantity = 15,
                    Price = 2804.33m,
                    InventoryDate = new DateTime(2015, 9, 25)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): таблиці до тем навчальної програми",
                    InventoryNumber = 61585747,
                    Quantity = 19,
                    Price = 2349.81m,
                    InventoryDate = new DateTime(2013, 3, 21)
                },
                new Inventory
                {
                    Name = "Набір таблиць (у т. ч. магнітні, пазли): таблиця множення",
                    InventoryNumber = 97346520,
                    Quantity = 46,
                    Price = 1532.81m,
                    InventoryDate = new DateTime(2014, 7, 18)
                },
                new Inventory
                {
                    Name = "Набір таблиць до основних розділів граматичного матеріалу",
                    InventoryNumber = 74134845,
                    Quantity = 39,
                    Price = 2001.12m,
                    InventoryDate = new DateTime(2016, 10, 15)
                },
                new Inventory
                {
                    Name = "Набір таблиць: вправи для збільшення кута зору, поля читання",
                    InventoryNumber = 45549648,
                    Quantity = 39,
                    Price = 381.31m,
                    InventoryDate = new DateTime(2014, 2, 10)
                },
                new Inventory
                {
                    Name = "Набір таблиць: вправи для формування навичок читання",
                    InventoryNumber = 46968069,
                    Quantity = 2,
                    Price = 439.31m,
                    InventoryDate = new DateTime(2017, 9, 9)
                },
                new Inventory
                {
                    Name = "Набір технологічних карт",
                    InventoryNumber = 25255413,
                    Quantity = 12,
                    Price = 2537.25m,
                    InventoryDate = new DateTime(2019, 5, 7)
                },
                new Inventory
                {
                    Name = "Набір цифр і математичних знаків на дошці (математичний планшет або геоборд)",
                    InventoryNumber = 77897193,
                    Quantity = 4,
                    Price = 2774.79m,
                    InventoryDate = new DateTime(2014, 7, 3)
                },
                new Inventory
                {
                    Name = "Набірне/магнітне полотно",
                    InventoryNumber = 59294050,
                    Quantity = 19,
                    Price = 1827.81m,
                    InventoryDate = new DateTime(2019, 7, 17)
                },
                new Inventory
                {
                    Name = "Набори (комплекти) сюжетних та предметних малюнків (для розвитку мовлення, словникові слова та їх написання, до казок) (по класах)",
                    InventoryNumber = 14908803,
                    Quantity = 3,
                    Price = 1554.01m,
                    InventoryDate = new DateTime(2015, 1, 28)
                },
                new Inventory
                {
                    Name = "Набори для колективної творчості (різні види, в т. ч. для в’язання гачком, вишивання/ квілінгу/аплікації/писанкарства тощо)",
                    InventoryNumber = 81014276,
                    Quantity = 13,
                    Price = 793.56m,
                    InventoryDate = new DateTime(2015, 10, 4)
                },
                new Inventory
                {
                    Name = "Набори для навчання грамоти та читання: каса букв та складів",
                    InventoryNumber = 66808094,
                    Quantity = 18,
                    Price = 785.96m,
                    InventoryDate = new DateTime(2012, 3, 10)
                },
                new Inventory
                {
                    Name = "Набори для навчання грамоти та читання: набір карток з графічним позначенням мовних одиниць (звуки, склади, слова)",
                    InventoryNumber = 79385496,
                    Quantity = 47,
                    Price = 1386.71m,
                    InventoryDate = new DateTime(2015, 9, 20)
                },
                new Inventory
                {
                    Name = "Набори канцелярського приладдя",
                    InventoryNumber = 63290870,
                    Quantity = 6,
                    Price = 849.65m,
                    InventoryDate = new DateTime(2011, 10, 22)
                },
                new Inventory
                {
                    Name = "Набори карток (у т. ч. на магнітах): для лічби та усного рахунку від 0 до 100",
                    InventoryNumber = 78018757,
                    Quantity = 32,
                    Price = 1457.81m,
                    InventoryDate = new DateTime(2016, 7, 18)
                },
                new Inventory
                {
                    Name = "Набори карток (у т. ч. на магнітах): для математичних диктантів",
                    InventoryNumber = 83977265,
                    Quantity = 37,
                    Price = 606.69m,
                    InventoryDate = new DateTime(2020, 12, 3)
                },
                new Inventory
                {
                    Name = "Набори карток (у т. ч. на магнітах): ілюстрації до типових задач",
                    InventoryNumber = 11804652,
                    Quantity = 17,
                    Price = 822.68m,
                    InventoryDate = new DateTime(2019, 8, 5)
                },
                new Inventory
                {
                    Name = "Набори карток (у т. ч. на магнітах): склад числа",
                    InventoryNumber = 86600032,
                    Quantity = 19,
                    Price = 665.37m,
                    InventoryDate = new DateTime(2013, 1, 18)
                },
                new Inventory
                {
                    Name = "Набори плакатів",
                    InventoryNumber = 22817461,
                    Quantity = 32,
                    Price = 999.32m,
                    InventoryDate = new DateTime(2019, 11, 27)
                },
                new Inventory
                {
                    Name = "Набори тематичних, сюжетних, предметних малюнків (картинок) відповідно до тем навчальної програми",
                    InventoryNumber = 74443149,
                    Quantity = 39,
                    Price = 1525.34m,
                    InventoryDate = new DateTime(2016, 9, 6)
                },
                new Inventory
                {
                    Name = "Навчальний набір грошових знаків країн, мови яких вивчаються",
                    InventoryNumber = 71004367,
                    Quantity = 5,
                    Price = 2357.79m,
                    InventoryDate = new DateTime(2017, 5, 13)
                },
                new Inventory
                {
                    Name = "Навчальний набір грошових знаків України",
                    InventoryNumber = 25676012,
                    Quantity = 45,
                    Price = 2840.52m,
                    InventoryDate = new DateTime(2015, 5, 12)
                },
                new Inventory
                {
                    Name = "Навчально-наочні засоби (наприклад, блоки Дьєнеша, творчі ігри для вивчення цифр, арифметичні/ числові/математичні штанги тощо)",
                    InventoryNumber = 51508765,
                    Quantity = 41,
                    Price = 1436.36m,
                    InventoryDate = new DateTime(2012, 2, 12)
                },
                new Inventory
                {
                    Name = "Насос універсальний для накачування спортивних м’ячів",
                    InventoryNumber = 62436107,
                    Quantity = 25,
                    Price = 1882.00m,
                    InventoryDate = new DateTime(2020, 5, 27)
                },
                new Inventory
                {
                    Name = "Настільні логіко-розвивальні ігри",
                    InventoryNumber = 37873363,
                    Quantity = 2,
                    Price = 2709.47m,
                    InventoryDate = new DateTime(2013, 2, 6)
                },
                new Inventory
                {
                    Name = "Настільні розвиваючі ігри (лото, доміно, кубики) мовою, що вивчається",
                    InventoryNumber = 63181594,
                    Quantity = 28,
                    Price = 1983.48m,
                    InventoryDate = new DateTime(2011, 2, 16)
                },
                new Inventory
                {
                    Name = "Об’єкти народних ремесел",
                    InventoryNumber = 44127874,
                    Quantity = 12,
                    Price = 146.16m,
                    InventoryDate = new DateTime(2019, 2, 4)
                },
                new Inventory
                {
                    Name = "Обручі різних розмірів",
                    InventoryNumber = 71576937,
                    Quantity = 39,
                    Price = 776.65m,
                    InventoryDate = new DateTime(2020, 5, 1)
                },
                new Inventory
                {
                    Name = "Огородження (бортики) для тенісу настільного",
                    InventoryNumber = 53369023,
                    Quantity = 31,
                    Price = 1878.36m,
                    InventoryDate = new DateTime(2012, 11, 6)
                },
                new Inventory
                {
                    Name = "Опадомір",
                    InventoryNumber = 63510109,
                    Quantity = 42,
                    Price = 2057.66m,
                    InventoryDate = new DateTime(2020, 4, 10)
                },
                new Inventory
                {
                    Name = "Орбітрек",
                    InventoryNumber = 58707629,
                    Quantity = 47,
                    Price = 2250.87m,
                    InventoryDate = new DateTime(2019, 10, 25)
                },
                new Inventory
                {
                    Name = "Палиця гімнастична",
                    InventoryNumber = 79789189,
                    Quantity = 21,
                    Price = 2130.46m,
                    InventoryDate = new DateTime(2020, 9, 27)
                },
                new Inventory
                {
                    Name = "Палітри та пензлики",
                    InventoryNumber = 45076375,
                    Quantity = 41,
                    Price = 1266.17m,
                    InventoryDate = new DateTime(2016, 2, 19)
                },
                new Inventory
                {
                    Name = "Папір А3",
                    InventoryNumber = 73954418,
                    Quantity = 21,
                    Price = 2068.51m,
                    InventoryDate = new DateTime(2020, 10, 16)
                },
                new Inventory
                {
                    Name = "Папір багатофункціональний офісний А4",
                    InventoryNumber = 64477861,
                    Quantity = 25,
                    Price = 1989.68m,
                    InventoryDate = new DateTime(2016, 6, 8)
                },
                new Inventory
                {
                    Name = "Папір для дошки фліпчарта або дошки-мольберта",
                    InventoryNumber = 90221076,
                    Quantity = 27,
                    Price = 2708.90m,
                    InventoryDate = new DateTime(2018, 3, 5)
                },
                new Inventory
                {
                    Name = "Папки-реєстратори",
                    InventoryNumber = 44007913,
                    Quantity = 48,
                    Price = 2955.59m,
                    InventoryDate = new DateTime(2015, 2, 27)
                },
                new Inventory
                {
                    Name = "Парта-конторка",
                    InventoryNumber = 40381671,
                    Quantity = 29,
                    Price = 2614.01m,
                    InventoryDate = new DateTime(2018, 9, 3)
                },
                new Inventory
                {
                    Name = "Перекладина гімнастична",
                    InventoryNumber = 80174327,
                    Quantity = 5,
                    Price = 2037.52m,
                    InventoryDate = new DateTime(2011, 2, 26)
                },
                new Inventory
                {
                    Name = "Планка (брусок, дошка) відштовхування для стрибків у довжину",
                    InventoryNumber = 69099445,
                    Quantity = 34,
                    Price = 570.50m,
                    InventoryDate = new DateTime(2013, 2, 9)
                },
                new Inventory
                {
                    Name = "Планка для бар’єра легкоатлетичного",
                    InventoryNumber = 29616054,
                    Quantity = 16,
                    Price = 2865.17m,
                    InventoryDate = new DateTime(2015, 1, 6)
                },
                new Inventory
                {
                    Name = "Планка для стрибка у висоту",
                    InventoryNumber = 14528773,
                    Quantity = 35,
                    Price = 1821.20m,
                    InventoryDate = new DateTime(2013, 2, 6)
                },
                new Inventory
                {
                    Name = "Плівка для ламінування",
                    InventoryNumber = 69772262,
                    Quantity = 17,
                    Price = 963.31m,
                    InventoryDate = new DateTime(2019, 7, 6)
                },
                new Inventory
                {
                    Name = "Покриття спортивне синтетичне (у рулонах)",
                    InventoryNumber = 72096790,
                    Quantity = 47,
                    Price = 2364.78m,
                    InventoryDate = new DateTime(2017, 9, 11)
                },
                new Inventory
                {
                    Name = "Поле для гри Твістер",
                    InventoryNumber = 65118790,
                    Quantity = 43,
                    Price = 1265.68m,
                    InventoryDate = new DateTime(2022, 1, 16)
                },
                new Inventory
                {
                    Name = "Поміст",
                    InventoryNumber = 11624480,
                    Quantity = 10,
                    Price = 2471.66m,
                    InventoryDate = new DateTime(2018, 2, 23)
                },
                new Inventory
                {
                    Name = "Прапорець зі стійкою (різного кольору)",
                    InventoryNumber = 98265481,
                    Quantity = 46,
                    Price = 1764.15m,
                    InventoryDate = new DateTime(2018, 8, 1)
                },
                new Inventory
                {
                    Name = "Прапорець сигнальний, стартовий та фінішний",
                    InventoryNumber = 53612511,
                    Quantity = 28,
                    Price = 2867.04m,
                    InventoryDate = new DateTime(2015, 5, 23)
                },
                new Inventory
                {
                    Name = "Прапорець суддівський (різного кольору)",
                    InventoryNumber = 65645729,
                    Quantity = 46,
                    Price = 459.65m,
                    InventoryDate = new DateTime(2022, 7, 6)
                },
                new Inventory
                {
                    Name = "Предмети символіки українського народу",
                    InventoryNumber = 56206734,
                    Quantity = 32,
                    Price = 1865.56m,
                    InventoryDate = new DateTime(2017, 10, 5)
                },
                new Inventory
                {
                    Name = "Прилад для вимірювання висоти",
                    InventoryNumber = 82392193,
                    Quantity = 3,
                    Price = 2028.42m,
                    InventoryDate = new DateTime(2011, 3, 27)
                },
                new Inventory
                {
                    Name = "Ракетка для бадмінтону",
                    InventoryNumber = 46317387,
                    Quantity = 49,
                    Price = 587.49m,
                    InventoryDate = new DateTime(2016, 10, 18)
                },
                new Inventory
                {
                    Name = "Ракетка тенісна тренувальна",
                    InventoryNumber = 65300768,
                    Quantity = 2,
                    Price = 936.66m,
                    InventoryDate = new DateTime(2019, 2, 5)
                },
                new Inventory
                {
                    Name = "Ракетки для бадмінтону",
                    InventoryNumber = 47983345,
                    Quantity = 8,
                    Price = 1518.30m,
                    InventoryDate = new DateTime(2017, 5, 4)
                },
                new Inventory
                {
                    Name = "Ракетки пластикові",
                    InventoryNumber = 49786812,
                    Quantity = 2,
                    Price = 2068.50m,
                    InventoryDate = new DateTime(2017, 3, 16)
                },
                new Inventory
                {
                    Name = "Рама з кільцями гімнастична",
                    InventoryNumber = 29273022,
                    Quantity = 20,
                    Price = 355.09m,
                    InventoryDate = new DateTime(2015, 11, 17)
                },
                new Inventory
                {
                    Name = "Рахівниця / абакус навчальний",
                    InventoryNumber = 42136149,
                    Quantity = 23,
                    Price = 1012.10m,
                    InventoryDate = new DateTime(2011, 1, 12)
                },
                new Inventory
                {
                    Name = "Робототехнічний набір для здійснення програмованого руху",
                    InventoryNumber = 67083784,
                    Quantity = 7,
                    Price = 515.42m,
                    InventoryDate = new DateTime(2016, 5, 14)
                },
                new Inventory
                {
                    Name = "Ростомір",
                    InventoryNumber = 92649587,
                    Quantity = 38,
                    Price = 1626.61m,
                    InventoryDate = new DateTime(2016, 3, 19)
                },
                new Inventory
                {
                    Name = "Рулетка для вимірів",
                    InventoryNumber = 69525172,
                    Quantity = 10,
                    Price = 2057.90m,
                    InventoryDate = new DateTime(2016, 8, 6)
                },
                new Inventory
                {
                    Name = "Рулетка, шнур мірний",
                    InventoryNumber = 35327651,
                    Quantity = 40,
                    Price = 2345.94m,
                    InventoryDate = new DateTime(2017, 4, 11)
                },
                new Inventory
                {
                    Name = "Свисток",
                    InventoryNumber = 59846910,
                    Quantity = 10,
                    Price = 569.63m,
                    InventoryDate = new DateTime(2018, 6, 19)
                },
                new Inventory
                {
                    Name = "Світловідбивні жилети для дітей",
                    InventoryNumber = 85427232,
                    Quantity = 21,
                    Price = 376.09m,
                    InventoryDate = new DateTime(2011, 12, 7)
                },
                new Inventory
                {
                    Name = "Секундомір",
                    InventoryNumber = 98361912,
                    Quantity = 48,
                    Price = 2007.85m,
                    InventoryDate = new DateTime(2013, 9, 13)
                },
                new Inventory
                {
                    Name = "Силовий тренажер",
                    InventoryNumber = 12063074,
                    Quantity = 38,
                    Price = 756.03m,
                    InventoryDate = new DateTime(2015, 10, 19)
                },
                new Inventory
                {
                    Name = "Сітка бадмінтонна",
                    InventoryNumber = 92136533,
                    Quantity = 41,
                    Price = 2548.89m,
                    InventoryDate = new DateTime(2012, 9, 8)
                },
                new Inventory
                {
                    Name = "Сітка баскетбольна",
                    InventoryNumber = 67332631,
                    Quantity = 50,
                    Price = 2561.29m,
                    InventoryDate = new DateTime(2019, 12, 6)
                },
                new Inventory
                {
                    Name = "Сітка безпеки",
                    InventoryNumber = 39342345,
                    Quantity = 11,
                    Price = 1035.09m,
                    InventoryDate = new DateTime(2020, 8, 22)
                },
                new Inventory
                {
                    Name = "Сітка волейбольна",
                    InventoryNumber = 61627643,
                    Quantity = 29,
                    Price = 747.50m,
                    InventoryDate = new DateTime(2015, 7, 19)
                },
                new Inventory
                {
                    Name = "Сітка для тенісу настільного",
                    InventoryNumber = 59417180,
                    Quantity = 4,
                    Price = 359.18m,
                    InventoryDate = new DateTime(2014, 8, 15)
                },
                new Inventory
                {
                    Name = "Сітка для футбольних воріт",
                    InventoryNumber = 23747136,
                    Quantity = 7,
                    Price = 1293.52m,
                    InventoryDate = new DateTime(2016, 10, 18)
                },
                new Inventory
                {
                    Name = "Сітка тенісна",
                    InventoryNumber = 83433297,
                    Quantity = 37,
                    Price = 2076.07m,
                    InventoryDate = new DateTime(2020, 6, 28)
                },
                new Inventory
                {
                    Name = "Скакалка",
                    InventoryNumber = 46419428,
                    Quantity = 11,
                    Price = 122.68m,
                    InventoryDate = new DateTime(2016, 11, 14)
                },
                new Inventory
                {
                    Name = "Словники з української мови та мов корінних народів, національних меншин, у тому числі ілюстровані та/або комбіновані: антонімів",
                    InventoryNumber = 22334092,
                    Quantity = 8,
                    Price = 459.30m,
                    InventoryDate = new DateTime(2016, 11, 6)
                },
                new Inventory
                {
                    Name = "Словники з української мови та мов корінних народів, національних меншин, у тому числі ілюстровані та/або комбіновані: орфографічний",
                    InventoryNumber = 50230444,
                    Quantity = 25,
                    Price = 825.85m,
                    InventoryDate = new DateTime(2013, 7, 19)
                },
                new Inventory
                {
                    Name = "Словники з української мови та мов корінних народів, національних меншин, у тому числі ілюстровані та/або комбіновані: перекладний",
                    InventoryNumber = 27530421,
                    Quantity = 16,
                    Price = 1197.51m,
                    InventoryDate = new DateTime(2014, 8, 23)
                },
                new Inventory
                {
                    Name = "Словники з української мови та мов корінних народів, національних меншин, у тому числі ілюстровані та/або комбіновані: синонімів",
                    InventoryNumber = 80049394,
                    Quantity = 41,
                    Price = 1333.05m,
                    InventoryDate = new DateTime(2018, 1, 26)
                },
                new Inventory
                {
                    Name = "Словники з української мови та мов корінних народів, національних меншин, у тому числі ілюстровані та/або комбіновані: тлумачний",
                    InventoryNumber = 17905565,
                    Quantity = 38,
                    Price = 463.72m,
                    InventoryDate = new DateTime(2013, 1, 10)
                },
                new Inventory
                {
                    Name = "Словники перекладні, в тому числі ілюстровані",
                    InventoryNumber = 68369187,
                    Quantity = 4,
                    Price = 655.47m,
                    InventoryDate = new DateTime(2017, 3, 14)
                },
                new Inventory
                {
                    Name = "Спортивна мішень",
                    InventoryNumber = 47578361,
                    Quantity = 34,
                    Price = 876.31m,
                    InventoryDate = new DateTime(2013, 1, 9)
                },
                new Inventory
                {
                    Name = "Спортивний інвентар: гімнастичні палиці",
                    InventoryNumber = 43000160,
                    Quantity = 32,
                    Price = 544.02m,
                    InventoryDate = new DateTime(2011, 8, 5)
                },
                new Inventory
                {
                    Name = "Спортивний інвентар: м’яч",
                    InventoryNumber = 64204750,
                    Quantity = 5,
                    Price = 1764.53m,
                    InventoryDate = new DateTime(2013, 9, 2)
                },
                new Inventory
                {
                    Name = "Спортивний інвентар: обруч",
                    InventoryNumber = 15913348,
                    Quantity = 21,
                    Price = 354.16m,
                    InventoryDate = new DateTime(2013, 5, 4)
                },
                new Inventory
                {
                    Name = "Спортивний інвентар: скакалка",
                    InventoryNumber = 17332883,
                    Quantity = 10,
                    Price = 1406.03m,
                    InventoryDate = new DateTime(2020, 7, 14)
                },
                new Inventory
                {
                    Name = "Станок хореографічний",
                    InventoryNumber = 52511721,
                    Quantity = 29,
                    Price = 410.99m,
                    InventoryDate = new DateTime(2020, 11, 27)
                },
                new Inventory
                {
                    Name = "Стартовий блок",
                    InventoryNumber = 59820405,
                    Quantity = 28,
                    Price = 2305.58m,
                    InventoryDate = new DateTime(2012, 5, 13)
                },
                new Inventory
                {
                    Name = "Стійка для виконання вправ з м’ячем",
                    InventoryNumber = 77441127,
                    Quantity = 3,
                    Price = 421.32m,
                    InventoryDate = new DateTime(2022, 8, 27)
                },
                new Inventory
                {
                    Name = "Стійка для гантелей розбірних",
                    InventoryNumber = 80258724,
                    Quantity = 23,
                    Price = 1194.66m,
                    InventoryDate = new DateTime(2012, 7, 23)
                },
                new Inventory
                {
                    Name = "Стійка для стрибків у висоту",
                    InventoryNumber = 45800821,
                    Quantity = 10,
                    Price = 917.33m,
                    InventoryDate = new DateTime(2012, 2, 25)
                },
                new Inventory
                {
                    Name = "Стійка з набором гантелей хромованих від 0,5 до 10 кг",
                    InventoryNumber = 87342089,
                    Quantity = 24,
                    Price = 311.22m,
                    InventoryDate = new DateTime(2018, 7, 2)
                },
                new Inventory
                {
                    Name = "Стійка під диски",
                    InventoryNumber = 14279926,
                    Quantity = 35,
                    Price = 617.19m,
                    InventoryDate = new DateTime(2017, 8, 4)
                },
                new Inventory
                {
                    Name = "Стійка під штанги для присідання зі штангою",
                    InventoryNumber = 37962042,
                    Quantity = 47,
                    Price = 268.81m,
                    InventoryDate = new DateTime(2018, 6, 10)
                },
                new Inventory
                {
                    Name = "Стійки бадмінтонні переносні",
                    InventoryNumber = 99834506,
                    Quantity = 5,
                    Price = 1672.82m,
                    InventoryDate = new DateTime(2016, 2, 3)
                },
                new Inventory
                {
                    Name = "Стійки тенісні",
                    InventoryNumber = 21742814,
                    Quantity = 17,
                    Price = 153.44m,
                    InventoryDate = new DateTime(2014, 7, 21)
                },
                new Inventory
                {
                    Name = "Стіл (парта) учнівський(а)",
                    InventoryNumber = 71298101,
                    Quantity = 20,
                    Price = 1298.47m,
                    InventoryDate = new DateTime(2020, 4, 26)
                },
                new Inventory
                {
                    Name = "Стіл для малювання піском",
                    InventoryNumber = 43176111,
                    Quantity = 5,
                    Price = 1532.57m,
                    InventoryDate = new DateTime(2011, 12, 27)
                },
                new Inventory
                {
                    Name = "Стіл для роботи з конструктором(ами)",
                    InventoryNumber = 79643458,
                    Quantity = 9,
                    Price = 2442.72m,
                    InventoryDate = new DateTime(2013, 10, 18)
                },
                new Inventory
                {
                    Name = "Стіл для тенісу настільного",
                    InventoryNumber = 75860385,
                    Quantity = 37,
                    Price = 2151.22m,
                    InventoryDate = new DateTime(2022, 2, 2)
                },
                new Inventory
                {
                    Name = "Стіл учительський",
                    InventoryNumber = 39871878,
                    Quantity = 18,
                    Price = 1085.56m,
                    InventoryDate = new DateTime(2022, 7, 7)
                },
                new Inventory
                {
                    Name = "Стілець для вчителя",
                    InventoryNumber = 14969632,
                    Quantity = 36,
                    Price = 640.75m,
                    InventoryDate = new DateTime(2016, 12, 8)
                },
                new Inventory
                {
                    Name = "Стілець учнівський",
                    InventoryNumber = 75336257,
                    Quantity = 21,
                    Price = 2063.75m,
                    InventoryDate = new DateTime(2012, 4, 11)
                },
                new Inventory
                {
                    Name = "Стінка гімнастична",
                    InventoryNumber = 86276997,
                    Quantity = 48,
                    Price = 507.68m,
                    InventoryDate = new DateTime(2017, 9, 27)
                },
                new Inventory
                {
                    Name = "Струни для ракетки",
                    InventoryNumber = 36753667,
                    Quantity = 44,
                    Price = 1578.95m,
                    InventoryDate = new DateTime(2015, 8, 22)
                },
                new Inventory
                {
                    Name = "Сумка для м’ячів",
                    InventoryNumber = 12116528,
                    Quantity = 37,
                    Price = 762.98m,
                    InventoryDate = new DateTime(2014, 7, 26)
                },
                new Inventory
                {
                    Name = "Схеми/таблиці/картки про будову комп’ютера",
                    InventoryNumber = 60396250,
                    Quantity = 20,
                    Price = 1705.87m,
                    InventoryDate = new DateTime(2013, 1, 7)
                },
                new Inventory
                {
                    Name = "Таблиці загальних тем (організація робочого місця, правила безпеки на уроці, правила користування окремими інструментами, економне ставлення до використання матеріалів)",
                    InventoryNumber = 79288844,
                    Quantity = 16,
                    Price = 752.34m,
                    InventoryDate = new DateTime(2017, 7, 12)
                },
                new Inventory
                {
                    Name = "Таблиці, плакати, календарі до пам’ятних дат (подій) держави, традицій і свят українського народу",
                    InventoryNumber = 94861190,
                    Quantity = 29,
                    Price = 1384.24m,
                    InventoryDate = new DateTime(2014, 2, 6)
                },
                new Inventory
                {
                    Name = "Таблиці, плакати, календарі ілюстрації історичних пам’ятників, архітектурних споруд, пам’яток культури, об’єктів культурно-історичної спадщини рідного краю, України",
                    InventoryNumber = 92720785,
                    Quantity = 37,
                    Price = 1916.95m,
                    InventoryDate = new DateTime(2015, 9, 19)
                },
                new Inventory
                {
                    Name = "Таблиці, плакати, календарі ілюстрації предметів народно-ужиткового побуту",
                    InventoryNumber = 74358120,
                    Quantity = 33,
                    Price = 456.36m,
                    InventoryDate = new DateTime(2015, 6, 6)
                },
                new Inventory
                {
                    Name = "Таблиці, плакати, календарі охорони природи і довкілля",
                    InventoryNumber = 13451589,
                    Quantity = 19,
                    Price = 2525.45m,
                    InventoryDate = new DateTime(2019, 8, 26)
                },
                new Inventory
                {
                    Name = "Таблиці, плакати, календарі портрети історичних осіб, політичних діячів, визначних постатей",
                    InventoryNumber = 85283300,
                    Quantity = 29,
                    Price = 2836.49m,
                    InventoryDate = new DateTime(2020, 10, 12)
                },
                new Inventory
                {
                    Name = "Таблиці: з кольорознавства",
                    InventoryNumber = 76237705,
                    Quantity = 37,
                    Price = 1140.52m,
                    InventoryDate = new DateTime(2011, 6, 1)
                },
                new Inventory
                {
                    Name = "Таблиці: з тем навчальної програми",
                    InventoryNumber = 40556998,
                    Quantity = 35,
                    Price = 1950.93m,
                    InventoryDate = new DateTime(2011, 6, 24)
                },
                new Inventory
                {
                    Name = "Таблиці: зразки різних видів мистецтва",
                    InventoryNumber = 35691565,
                    Quantity = 9,
                    Price = 2118.88m,
                    InventoryDate = new DateTime(2020, 7, 11)
                },
                new Inventory
                {
                    Name = "Таблиці: репродукції картин художників",
                    InventoryNumber = 20795729,
                    Quantity = 18,
                    Price = 2602.35m,
                    InventoryDate = new DateTime(2011, 7, 5)
                },
                new Inventory
                {
                    Name = "Танграм",
                    InventoryNumber = 62937853,
                    Quantity = 9,
                    Price = 2869.72m,
                    InventoryDate = new DateTime(2016, 6, 15)
                },
                new Inventory
                {
                    Name = "Телевізор Smart TV",
                    InventoryNumber = 34917812,
                    Quantity = 1,
                    Price = 2747.07m,
                    InventoryDate = new DateTime(2013, 8, 27)
                },
                new Inventory
                {
                    Name = "Телурій",
                    InventoryNumber = 37750477,
                    Quantity = 32,
                    Price = 643.53m,
                    InventoryDate = new DateTime(2012, 1, 22)
                },
                new Inventory
                {
                    Name = "Термометр (зовнішній, кімнатний)",
                    InventoryNumber = 61316202,
                    Quantity = 1,
                    Price = 2801.31m,
                    InventoryDate = new DateTime(2022, 6, 13)
                },
                new Inventory
                {
                    Name = "Тренажер для м’язів живота",
                    InventoryNumber = 30041892,
                    Quantity = 47,
                    Price = 135.36m,
                    InventoryDate = new DateTime(2017, 10, 14)
                },
                new Inventory
                {
                    Name = "Тренажер для м’язів ніг",
                    InventoryNumber = 60522844,
                    Quantity = 36,
                    Price = 706.17m,
                    InventoryDate = new DateTime(2013, 7, 9)
                },
                new Inventory
                {
                    Name = "Тренажер для м’язів рук",
                    InventoryNumber = 17561745,
                    Quantity = 40,
                    Price = 701.70m,
                    InventoryDate = new DateTime(2012, 9, 12)
                },
                new Inventory
                {
                    Name = "Тренажер для м’язів спини",
                    InventoryNumber = 93211035,
                    Quantity = 4,
                    Price = 1615.77m,
                    InventoryDate = new DateTime(2019, 8, 27)
                },
                new Inventory
                {
                    Name = "Тренажер для сідничних м’язів",
                    InventoryNumber = 26560826,
                    Quantity = 1,
                    Price = 893.29m,
                    InventoryDate = new DateTime(2012, 6, 15)
                },
                new Inventory
                {
                    Name = "Тренажер комбінований",
                    InventoryNumber = 30639718,
                    Quantity = 30,
                    Price = 2044.57m,
                    InventoryDate = new DateTime(2016, 4, 16)
                },
                new Inventory
                {
                    Name = "Тренажер лижний",
                    InventoryNumber = 56558668,
                    Quantity = 35,
                    Price = 707.76m,
                    InventoryDate = new DateTime(2015, 8, 27)
                },
                new Inventory
                {
                    Name = "Фігури людини і тварин з рухомими частинами",
                    InventoryNumber = 77193922,
                    Quantity = 5,
                    Price = 428.97m,
                    InventoryDate = new DateTime(2020, 1, 8)
                },
                new Inventory
                {
                    Name = "Фітнес-канат",
                    InventoryNumber = 59888027,
                    Quantity = 23,
                    Price = 853.46m,
                    InventoryDate = new DateTime(2016, 1, 13)
                },
                new Inventory
                {
                    Name = "Фішки",
                    InventoryNumber = 92403215,
                    Quantity = 24,
                    Price = 1096.49m,
                    InventoryDate = new DateTime(2011, 5, 23)
                },
                new Inventory
                {
                    Name = "Числова лінійка: від 0 до 100 з набором карток до неї (десятки, одиниці, чисті)",
                    InventoryNumber = 28328816,
                    Quantity = 23,
                    Price = 835.76m,
                    InventoryDate = new DateTime(2018, 12, 26)
                },
                new Inventory
                {
                    Name = "Числова лінійка: від 0 до 1000 з набором карток до неї (сотні, десятки, одиниці, чисті)",
                    InventoryNumber = 66067355,
                    Quantity = 28,
                    Price = 1482.81m,
                    InventoryDate = new DateTime(2018, 8, 2)
                },
                new Inventory
                {
                    Name = "Шафа для інвентарю",
                    InventoryNumber = 30447299,
                    Quantity = 24,
                    Price = 1308.90m,
                    InventoryDate = new DateTime(2017, 1, 15)
                },
                new Inventory
                {
                    Name = "Шафа/секція/стелаж для особистих речей педагогічного працівника",
                    InventoryNumber = 84582437,
                    Quantity = 14,
                    Price = 2974.04m,
                    InventoryDate = new DateTime(2022, 7, 1)
                },
                new Inventory
                {
                    Name = "Шафи/секції/стелажі для особистих речей дітей/ шафи для одягу / змінного взуття",
                    InventoryNumber = 34007809,
                    Quantity = 36,
                    Price = 1569.62m,
                    InventoryDate = new DateTime(2013, 8, 24)
                },
                new Inventory
                {
                    Name = "Ширма для лялькового театру",
                    InventoryNumber = 29057520,
                    Quantity = 22,
                    Price = 902.93m,
                    InventoryDate = new DateTime(2015, 4, 6)
                },
                new Inventory
                {
                    Name = "Штанга тренувальна",
                    InventoryNumber = 72004880,
                    Quantity = 3,
                    Price = 402.05m,
                    InventoryDate = new DateTime(2013, 4, 14)
                },
                new Inventory
                {
                    Name = "Штучне покриття корту (хард)",
                    InventoryNumber = 82817843,
                    Quantity = 45,
                    Price = 2554.97m,
                    InventoryDate = new DateTime(2013, 4, 17)
                },
                new Inventory
                {
                    Name = "Щит баскетбольний",
                    InventoryNumber = 12172509,
                    Quantity = 17,
                    Price = 1460.07m,
                    InventoryDate = new DateTime(2020, 3, 4)
                },
                new Inventory
                {
                    Name = "Ядро різної ваги",
                    InventoryNumber = 81780142,
                    Quantity = 11,
                    Price = 2684.80m,
                    InventoryDate = new DateTime(2013, 6, 8)
                }
            };
            #endregion
        }
    }
}

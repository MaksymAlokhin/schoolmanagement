using sms.Models;
using System;
using System.Collections.Generic;


namespace sms.Data
{
    public class SeedStudent
    {
        public List<Student> data;
        #region Student declarations
        public Student s001;
        public Student s002;
        public Student s003;
        public Student s004;
        public Student s005;
        public Student s006;
        public Student s007;
        public Student s008;
        public Student s009;
        public Student s010;
        public Student s011;
        public Student s012;
        public Student s013;
        public Student s014;
        public Student s015;
        public Student s016;
        public Student s017;
        public Student s018;
        public Student s019;
        public Student s020;
        public Student s021;
        public Student s022;
        public Student s023;
        public Student s024;
        public Student s025;
        public Student s026;
        public Student s027;
        public Student s028;
        public Student s029;
        public Student s030;
        public Student s031;
        public Student s032;
        public Student s033;
        public Student s034;
        public Student s035;
        public Student s036;
        public Student s037;
        public Student s038;
        public Student s039;
        public Student s040;
        public Student s041;
        public Student s042;
        public Student s043;
        public Student s044;
        public Student s045;
        public Student s046;
        public Student s047;
        public Student s048;
        public Student s049;
        public Student s050;
        public Student s051;
        public Student s052;
        public Student s053;
        public Student s054;
        public Student s055;
        public Student s056;
        public Student s057;
        public Student s058;
        public Student s059;
        public Student s060;
        public Student s061;
        public Student s062;
        public Student s063;
        public Student s064;
        public Student s065;
        public Student s066;
        public Student s067;
        public Student s068;
        public Student s069;
        public Student s070;
        public Student s071;
        public Student s072;
        public Student s073;
        public Student s074;
        public Student s075;
        public Student s076;
        public Student s077;
        public Student s078;
        public Student s079;
        public Student s080;
        public Student s081;
        public Student s082;
        public Student s083;
        public Student s084;
        public Student s085;
        public Student s086;
        public Student s087;
        public Student s088;
        public Student s089;
        public Student s090;
        public Student s091;
        public Student s092;
        public Student s093;
        public Student s094;
        public Student s095;
        public Student s096;
        public Student s097;
        public Student s098;
        public Student s099;
        public Student s100;
        public Student s101;
        public Student s102;
        public Student s103;
        public Student s104;
        public Student s105;
        public Student s106;
        public Student s107;
        public Student s108;
        public Student s109;
        public Student s110;
        public Student s111;
        public Student s112;
        public Student s113;
        public Student s114;
        public Student s115;
        public Student s116;
        public Student s117;
        public Student s118;
        public Student s119;
        public Student s120;
        public Student s121;
        public Student s122;
        public Student s123;
        public Student s124;
        public Student s125;
        public Student s126;
        public Student s127;
        public Student s128;
        public Student s129;
        public Student s130;
        public Student s131;
        public Student s132;

        #endregion
        public SeedStudent()
        {
            CreateStudents();
        }
        void CreateStudents()
        {
            #region Create students
            #region 1-A    
            s001 = new Student
            {
                LastName = "Белявський",
                FirstName = "Олег",
                Patronymic = "Владиславович",
                DateOfBirth = DateTime.Parse("2016-09-01"),
                Address = "вул. Абрикосова, буд. 15, кв. 51",
                Gender = "Чоловіча",
                ProfilePicture = "boy_001.jpg"
            };
            s002 = new Student
            {
                LastName = "Березникова",
                FirstName = "Мілена",
                Patronymic = "Сергіївна",
                DateOfBirth = DateTime.Parse("2016-10-13"),
                Address = "вул. Авіаційна, буд. 91, кв. 14",
                Gender = "Жіноча",
                ProfilePicture = "girl_001.jpg"
            };
            s003 = new Student
            {
                LastName = "Білоус",
                FirstName = "Владислав",
                Patronymic = "Данилович",
                DateOfBirth = DateTime.Parse("2016-01-09"),
                Address = "вул. Амосова, буд. 43, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_002.jpg"
            };
            s004 = new Student
            {
                LastName = "Вовк",
                FirstName = "Марія",
                Patronymic = "Станіславівна",
                DateOfBirth = DateTime.Parse("2016-10-09"),
                Address = "вул. Базова, буд. 55, кв. 41",
                Gender = "Жіноча",
                ProfilePicture = "girl_002.jpg"
            };
            s005 = new Student
            {
                LastName = "Гришаєнко",
                FirstName = "Юрій",
                Patronymic = "Максимович",
                DateOfBirth = DateTime.Parse("2016-09-01"),
                Address = "вул. Бандери, буд. 14, кв. 54",
                Gender = "Чоловіча",
                ProfilePicture = "boy_003.jpg"
            };
            s006 = new Student
            {
                LastName = "Губань",
                FirstName = "Єлизавета",
                Patronymic = "Павлівна",
                DateOfBirth = DateTime.Parse("2016-09-01"),
                Address = "вул. Батечка, буд. 26, кв. 67",
                Gender = "Жіноча",
                ProfilePicture = "girl_003.jpg"
            };
            #endregion
            #region 1-Б
            s007 = new Student
            {
                LastName = "Гуриненко",
                FirstName = "Даніїл",
                Patronymic = "Семенович",
                DateOfBirth = DateTime.Parse("2016-03-15"),
                Address = "вул. Батуринська, буд. 3, кв. 41",
                Gender = "Чоловіча",
                ProfilePicture = "boy_004.jpg"
            };
            s008 = new Student
            {
                LastName = "Дзюбенко",
                FirstName = "Олексій",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2016-09-21"),
                Address = "вул. Березнева, буд. 1, кв. 81",
                Gender = "Чоловіча",
                ProfilePicture = "boy_005.jpg"
            };
            s009 = new Student
            {
                LastName = "Довга",
                FirstName = "Діана",
                Patronymic = "Олексіївна",
                DateOfBirth = DateTime.Parse("2016-05-13"),
                Address = "вул. Березова, буд. 19, кв. 93",
                Gender = "Жіноча",
                ProfilePicture = "girl_004.jpg"
            };
            s010 = new Student
            {
                LastName = "Духно",
                FirstName = "Крістіна",
                Patronymic = "Власиславівна",
                DateOfBirth = DateTime.Parse("2016-02-25"),
                Address = "вул. Биківнянська, буд. 61, кв. 38",
                Gender = "Жіноча",
                ProfilePicture = "girl_005.jpg"
            };
            s011 = new Student
            {
                LastName = "Деченко",
                FirstName = "Злата",
                Patronymic = "Михайлівна",
                DateOfBirth = DateTime.Parse("2016-03-04"),
                Address = "вул. Білана, буд. 30, кв. 39",
                Gender = "Жіноча",
                ProfilePicture = "girl_006.jpg"
            };
            s012 = new Student
            {
                LastName = "Зеновський",
                FirstName = "Максим",
                Patronymic = "Юрійович",
                DateOfBirth = DateTime.Parse("2016-08-18"),
                Address = "вул. Білодібровна, буд. 26, кв. 95",
                Gender = "Чоловіча",
                ProfilePicture = "boy_006.jpg"
            };
            #endregion
            #region 2-А
            s013 = new Student
            {
                LastName = "Злобін",
                FirstName = "Данило",
                Patronymic = "Дем'янович",
                DateOfBirth = DateTime.Parse("2015-08-11"),
                Address = "вул. Білоконя, буд. 13, кв. 19",
                Gender = "Чоловіча",
                ProfilePicture = "boy_007.jpg"
            };
            s014 = new Student
            {
                LastName = "Івашко",
                FirstName = "Денис",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2015-07-07"),
                Address = "вул. Благодатна, буд. 74, кв. 26",
                Gender = "Чоловіча",
                ProfilePicture = "boy_008.jpg"
            };
            s015 = new Student
            {
                LastName = "Анжияк",
                FirstName = "Аліна",
                Patronymic = "Денисівна",
                DateOfBirth = DateTime.Parse("2015-09-16"),
                Address = "вул. Блока, буд. 63, кв. 38",
                Gender = "Жіноча",
                ProfilePicture = "girl_007.jpg"
            };
            s016 = new Student
            {
                LastName = "Глембоцький",
                FirstName = "Матвій",
                Patronymic = "Олегович",
                DateOfBirth = DateTime.Parse("2015-03-27"),
                Address = "вул. Боголюбова, буд. 93, кв. 25",
                Gender = "Чоловіча",
                ProfilePicture = "boy_009.jpg"
            };
            s017 = new Student
            {
                LastName = "Данилюк",
                FirstName = "Кіра",
                Patronymic = "Михайлівни",
                DateOfBirth = DateTime.Parse("2015-04-12"),
                Address = "вул. Богомольця, буд. 57, кв. 57",
                Gender = "Жіноча",
                ProfilePicture = "girl_008.jpg"
            };
            s018 = new Student
            {
                LastName = "Заболотна",
                FirstName = "Катерина",
                Patronymic = "Володимирівна",
                DateOfBirth = DateTime.Parse("2015-02-13"),
                Address = "вул. Богуна, буд. 64, кв. 18",
                Gender = "Жіноча",
                ProfilePicture = "girl_009.jpg"
            };
            #endregion
            #region 2-Б
            s019 = new Student
            {
                LastName = "Короп",
                FirstName = "Варвара",
                Patronymic = "Іванівна",
                DateOfBirth = DateTime.Parse("2015-05-30"),
                Address = "вул. Большеченка, буд. 18, кв. 18",
                Gender = "Жіноча",
                ProfilePicture = "girl_010.jpg"
            };
            s020 = new Student
            {
                LastName = "Косенко",
                FirstName = "Поліна",
                Patronymic = "Сергіївна",
                DateOfBirth = DateTime.Parse("2015-07-14"),
                Address = "вул. Бориспольця, буд. 31, кв. 72",
                Gender = "Жіноча",
                ProfilePicture = "girl_011.jpg"
            };
            s021 = new Student
            {
                LastName = "Кривошапка",
                FirstName = "Іван",
                Patronymic = "Станіславович",
                DateOfBirth = DateTime.Parse("2015-02-18"),
                Address = "вул. Броварська, буд. 21, кв. 83",
                Gender = "Чоловіча",
                ProfilePicture = "boy_010.jpg"
            };
            s022 = new Student
            {
                LastName = "Мартиновський",
                FirstName = "Глєб",
                Patronymic = "Валерійович",
                DateOfBirth = DateTime.Parse("2015-05-16"),
                Address = "вул. Будівельників, буд. 47, кв. 72",
                Gender = "Чоловіча",
                ProfilePicture = "boy_011.jpg"
            };
            s023 = new Student
            {
                LastName = "Марчук",
                FirstName = "Євгенія",
                Patronymic = "Борисівна",
                DateOfBirth = DateTime.Parse("2015-12-30"),
                Address = "вул. Бузкова, буд. 29, кв. 26",
                Gender = "Жіноча",
                ProfilePicture = "girl_012.jpg"
            };
            s024 = new Student
            {
                LastName = "Маслюченко",
                FirstName = "Іван",
                Patronymic = "Степанович",
                DateOfBirth = DateTime.Parse("2015-08-01"),
                Address = "вул. Вербицького, буд. 55, кв. 69",
                Gender = "Чоловіча",
                ProfilePicture = "boy_012.jpg"
            };
            #endregion
            #region 3-А
            s025 = new Student
            {
                LastName = "Мельникова",
                FirstName = "Аліса",
                Patronymic = "Володимирівна",
                DateOfBirth = DateTime.Parse("2014-01-12"),
                Address = "вул. Вербна, буд. 11, кв. 46",
                Gender = "Жіноча",
                ProfilePicture = "girl_013.jpg"
            };
            s026 = new Student
            {
                LastName = "Петруша",
                FirstName = "Іван",
                Patronymic = "Семенович",
                DateOfBirth = DateTime.Parse("2014-12-05"),
                Address = "вул. Вереснева, буд. 5, кв. 27",
                Gender = "Чоловіча",
                ProfilePicture = "boy_013.jpg"
            };
            s027 = new Student
            {
                LastName = "Сарикобак",
                FirstName = "Самір",
                Patronymic = "Данилович",
                DateOfBirth = DateTime.Parse("2014-04-11"),
                Address = "вул. Весняна, буд. 11, кв. 38",
                Gender = "Чоловіча",
                ProfilePicture = "boy_014.jpg"
            };
            s028 = new Student
            {
                LastName = "Тимченко",
                FirstName = "Ярослав",
                Patronymic = "Павлович",
                DateOfBirth = DateTime.Parse("2014-08-13"),
                Address = "вул. Виговського, буд. 16, кв. 72",
                Gender = "Чоловіча",
                ProfilePicture = "boy_015.jpg"
            };
            s029 = new Student
            {
                LastName = "Фощан",
                FirstName = "Даяна",
                Patronymic = "Свиридівна",
                DateOfBirth = DateTime.Parse("2014-04-01"),
                Address = "вул. Винниченка, буд. 40, кв. 52",
                Gender = "Жіноча",
                ProfilePicture = "girl_014.jpg"
            };
            s030 = new Student
            {
                LastName = "Шевчук",
                FirstName = "Олександра",
                Patronymic = "Максимівна",
                DateOfBirth = DateTime.Parse("2014-01-05"),
                Address = "вул. Виноградна, буд. 59, кв. 65",
                Gender = "Жіноча",
                ProfilePicture = "girl_015.jpg"
            };
            #endregion
            #region 3-Б
            s031 = new Student
            {
                LastName = "Байбара",
                FirstName = "Лука",
                Patronymic = "Степанович",
                DateOfBirth = DateTime.Parse("2014-02-13"),
                Address = "вул. Виробнича, буд. 44, кв. 37",
                Gender = "Чоловіча",
                ProfilePicture = "boy_016.jpg"
            };
            s032 = new Student
            {
                LastName = "Білан",
                FirstName = "Катерина",
                Patronymic = "Данилівна",
                DateOfBirth = DateTime.Parse("2014-07-14"),
                Address = "вул. Вишнева, буд. 34, кв. 38",
                Gender = "Жіноча",
                ProfilePicture = "girl_016.jpg"
            };
            s033 = new Student
            {
                LastName = "Гарус",
                FirstName = "Данило",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2014-01-18"),
                Address = "вул. Вокзальна, буд. 50, кв. 48",
                Gender = "Чоловіча",
                ProfilePicture = "boy_017.jpg"
            };
            s034 = new Student
            {
                LastName = "Городовицький",
                FirstName = "Михайло",
                Patronymic = "Сергійович",
                DateOfBirth = DateTime.Parse("2014-02-16"),
                Address = "вул. Волошкова, буд. 14, кв. 41",
                Gender = "Чоловіча",
                ProfilePicture = "boy_018.jpg"
            };
            s035 = new Student
            {
                LastName = "Дацька",
                FirstName = "Вікторія",
                Patronymic = "Денисівна",
                DateOfBirth = DateTime.Parse("2014-09-18"),
                Address = "вул. Воробйова, буд. 16, кв. 56",
                Gender = "Жіноча",
                ProfilePicture = "girl_017.jpg"
            };
            s036 = new Student
            {
                LastName = "Жугін",
                FirstName = "Ілля",
                Patronymic = "Дмитрович",
                DateOfBirth = DateTime.Parse("2014-03-30"),
                Address = "вул. Гагаріна, буд. 43, кв. 48",
                Gender = "Чоловіча",
                ProfilePicture = "boy_019.jpg"
            };
            #endregion
            #region 4-А
            s037 = new Student
            {
                LastName = "Іванова",
                FirstName = "Аліна",
                Patronymic = "Максимівна",
                DateOfBirth = DateTime.Parse("2013-04-10"),
                Address = "вул. Гайдамацька, буд. 13, кв. 52",
                Gender = "Жіноча",
                ProfilePicture = "girl_018.jpg"
            };
            s038 = new Student
            {
                LastName = "Ільницька",
                FirstName = "Дар'я",
                Patronymic = "Денисівна",
                DateOfBirth = DateTime.Parse("2013-11-05"),
                Address = "вул. Галагана, буд. 5, кв. 48",
                Gender = "Жіноча",
                ProfilePicture = "girl_019.jpg"
            };
            s039 = new Student
            {
                LastName = "Кас'ян",
                FirstName = "Ілля",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2013-06-11"),
                Address = "вул. Гамалія, буд. 1, кв. 27",
                Gender = "Чоловіча",
                ProfilePicture = "boy_020.jpg"
            };
            s040 = new Student
            {
                LastName = "Козлова",
                FirstName = "Злата",
                Patronymic = "Михайлівна",
                DateOfBirth = DateTime.Parse("2013-05-14"),
                Address = "вул. Геологів, буд. 12, кв. 36",
                Gender = "Жіноча",
                ProfilePicture = "girl_020.jpg"
            };
            s041 = new Student
            {
                LastName = "Колотущенко",
                FirstName = "Дмитро",
                Patronymic = "Володимирович",
                DateOfBirth = DateTime.Parse("2013-03-11"),
                Address = "вул. Героїв Крут, буд. 71, кв. 82",
                Gender = "Чоловіча",
                ProfilePicture = "boy_021.jpg"
            };
            s042 = new Student
            {
                LastName = "Ковальчук",
                FirstName = "Богдан",
                Patronymic = "Аврамович",
                DateOfBirth = DateTime.Parse("2013-11-12"),
                Address = "вул. Герцена, буд. 52, кв. 27",
                Gender = "Чоловіча",
                ProfilePicture = "boy_022.jpg"
            };
            #endregion
            #region 4-Б
            s043 = new Student
            {
                LastName = "Кошиченко",
                FirstName = "Ярослав",
                Patronymic = "Адамович",
                DateOfBirth = DateTime.Parse("2013-05-05"),
                Address = "вул. Гетьманська, буд. 4, кв. 73",
                Gender = "Чоловіча",
                ProfilePicture = "boy_023.jpg"
            };
            s044 = new Student
            {
                LastName = "Кравцов",
                FirstName = "Данило",
                Patronymic = "Олегович",
                DateOfBirth = DateTime.Parse("2013-10-13"),
                Address = "вул. Глинки, буд. 18, кв. 58",
                Gender = "Чоловіча",
                ProfilePicture = "boy_024.jpg"
            };
            s045 = new Student
            {
                LastName = "Крупицький",
                FirstName = "Олександр",
                Patronymic = "Сергійович",
                DateOfBirth = DateTime.Parse("2013-01-14"),
                Address = "вул. Глібова, буд. 27, кв. 37",
                Gender = "Чоловіча",
                ProfilePicture = "boy_025.jpg"
            };
            s046 = new Student
            {
                LastName = "Кученко",
                FirstName = "Данило",
                Patronymic = "Денисович",
                DateOfBirth = DateTime.Parse("2013-02-21"),
                Address = "вул. Гоголя, буд. 29, кв. 27",
                Gender = "Чоловіча",
                ProfilePicture = "boy_026.jpg"
            };
            s047 = new Student
            {
                LastName = "Башленко",
                FirstName = "Данило",
                Patronymic = "Володимирович",
                DateOfBirth = DateTime.Parse("2013-04-15"),
                Address = "вул. Гонти, буд. 30, кв. 62",
                Gender = "Чоловіча",
                ProfilePicture = "boy_027.jpg"
            };
            s048 = new Student
            {
                LastName = "Бездітний",
                FirstName = "Назар",
                Patronymic = "Павлович",
                DateOfBirth = DateTime.Parse("2013-10-08"),
                Address = "вул. Гончара, буд. 26, кв. 69",
                Gender = "Чоловіча",
                ProfilePicture = "boy_028.jpg"
            };
            #endregion
            #region 5-А
            s049 = new Student
            {
                LastName = "Белінська",
                FirstName = "Аріна",
                Patronymic = "Тимофіївна",
                DateOfBirth = DateTime.Parse("2012-01-03"),
                Address = "вул. Гончаренка, буд. 7, кв. 47",
                Gender = "Жіноча",
                ProfilePicture = "girl_021.jpg"
            };
            s050 = new Student
            {
                LastName = "Бурковська",
                FirstName = "Аліна",
                Patronymic = "Василівна",
                DateOfBirth = DateTime.Parse("2012-02-09"),
                Address = "вул. Гордієнка, буд. 13, кв. 27",
                Gender = "Жіноча",
                ProfilePicture = "girl_022.jpg"
            };
            s051 = new Student
            {
                LastName = "Волошин",
                FirstName = "Іван",
                Patronymic = "Борисович",
                DateOfBirth = DateTime.Parse("2012-04-05"),
                Address = "вул. Грінченка, буд. 15, кв. 74",
                Gender = "Чоловіча",
                ProfilePicture = "boy_029.jpg"
            };
            s052 = new Student
            {
                LastName = "Ворощук",
                FirstName = "Анастасія",
                Patronymic = "Зурабівна",
                DateOfBirth = DateTime.Parse("2012-12-05"),
                Address = "вул. Грушевського, буд. 27, кв. 33",
                Gender = "Жіноча",
                ProfilePicture = "girl_023.jpg"
            };
            s053 = new Student
            {
                LastName = "Гузій",
                FirstName = "Владеліна",
                Patronymic = "Миколаївна",
                DateOfBirth = DateTime.Parse("2012-03-11"),
                Address = "вул. Декабристів, буд. 14, кв. 61",
                Gender = "Жіноча",
                ProfilePicture = "girl_024.jpg"
            };
            s054 = new Student
            {
                LastName = "Друзь",
                FirstName = "Анастасія",
                Patronymic = "Данилівна",
                DateOfBirth = DateTime.Parse("2012-02-07"),
                Address = "вул. Дніпровська, буд. 20, кв. 74",
                Gender = "Жіноча",
                ProfilePicture = "girl_025.jpg"
            };
            #endregion
            #region 5-Б
            s055 = new Student
            {
                LastName = "Єгоров",
                FirstName = "Євген",
                Patronymic = "Сергійович",
                DateOfBirth = DateTime.Parse("2012-03-03"),
                Address = "вул. Довженка, буд. 4, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_030.jpg"
            };
            s056 = new Student
            {
                LastName = "Замирайло",
                FirstName = "Марк",
                Patronymic = "Едуардович",
                DateOfBirth = DateTime.Parse("2012-04-15"),
                Address = "вул. Дорошенка, буд. 10, кв. 54",
                Gender = "Чоловіча",
                ProfilePicture = "boy_031.jpg"
            };
            s057 = new Student
            {
                LastName = "Карпець",
                FirstName = "Дем'ян",
                Patronymic = "Олександрович",
                DateOfBirth = DateTime.Parse("2012-11-15"),
                Address = "вул. Драгоманова, буд. 18, кв. 13",
                Gender = "Чоловіча",
                ProfilePicture = "boy_032.jpg"
            };
            s058 = new Student
            {
                LastName = "Качапут",
                FirstName = "Дарина",
                Patronymic = "Петрівна",
                DateOfBirth = DateTime.Parse("2012-03-17"),
                Address = "вул. Дружби, буд. 42, кв. 53",
                Gender = "Жіноча",
                ProfilePicture = "girl_026.jpg"
            };
            s059 = new Student
            {
                LastName = "Махмудова",
                FirstName = "Ельвіра",
                Patronymic = "Андріївна",
                DateOfBirth = DateTime.Parse("2012-06-17"),
                Address = "вул. Електриків, буд. 15, кв. 98",
                Gender = "Жіноча",
                ProfilePicture = "girl_027.jpg"
            };
            s060 = new Student
            {
                LastName = "Мітрощенко",
                FirstName = "Олександра",
                Patronymic = "Костянтинівна",
                DateOfBirth = DateTime.Parse("2012-08-11"),
                Address = "вул. Єдності, буд. 14, кв. 84",
                Gender = "Жіноча",
                ProfilePicture = "girl_028.jpg"
            };
            #endregion
            #region 6-А
            s061 = new Student
            {
                LastName = "Мозоль",
                FirstName = "Максим",
                Patronymic = "Валерійович",
                DateOfBirth = DateTime.Parse("2011-11-13"),
                Address = "вул. Єсеніна, буд. 21, кв. 30",
                Gender = "Чоловіча",
                ProfilePicture = "boy_033.jpg"
            };
            s062 = new Student
            {
                LastName = "Наконечний",
                FirstName = "Олександр",
                Patronymic = "Петрович",
                DateOfBirth = DateTime.Parse("2011-05-14"),
                Address = "вул. Заводська, буд. 14, кв. 15",
                Gender = "Чоловіча",
                ProfilePicture = "boy_034.jpg"
            };
            s063 = new Student
            {
                LastName = "Лянга",
                FirstName = "Вадим",
                Patronymic = "Святославович",
                DateOfBirth = DateTime.Parse("2011-10-05"),
                Address = "вул. Залізнична, буд. 10, кв. 16",
                Gender = "Чоловіча",
                ProfilePicture = "boy_035.jpg"
            };
            s064 = new Student
            {
                LastName = "Ляхіна",
                FirstName = "Маргарита",
                Patronymic = "Василівна",
                DateOfBirth = DateTime.Parse("2011-05-18"),
                Address = "вул. Заньковецької, буд. 33, кв. 58",
                Gender = "Жіноча",
                ProfilePicture = "girl_029.jpg"
            };
            s065 = new Student
            {
                LastName = "Наталій",
                FirstName = "Милан",
                Patronymic = "Леонідович",
                DateOfBirth = DateTime.Parse("2011-11-10"),
                Address = "вул. Запорізька, буд. 51, кв. 10",
                Gender = "Чоловіча",
                ProfilePicture = "boy_036.jpg"
            };
            s066 = new Student
            {
                LastName = "Поканевич",
                FirstName = "Олексій",
                Patronymic = "Максимович",
                DateOfBirth = DateTime.Parse("2011-11-15"),
                Address = "вул. Затишна, буд. 13, кв. 21",
                Gender = "Чоловіча",
                ProfilePicture = "boy_037.jpg"
            };
            #endregion
            #region 6-Б
            s067 = new Student
            {
                LastName = "Рукавчук",
                FirstName = "Надія",
                Patronymic = "Тимофіївна",
                DateOfBirth = DateTime.Parse("2011-05-17"),
                Address = "вул. Зелена, буд. 15, кв. 20",
                Gender = "Жіноча",
                ProfilePicture = "girl_030.jpg"
            };
            s068 = new Student
            {
                LastName = "Свинченко",
                FirstName = "Катерина",
                Patronymic = "Василівна",
                DateOfBirth = DateTime.Parse("2011-04-21"),
                Address = "вул. Зіркова, буд. 17, кв. 33",
                Gender = "Жіноча",
                ProfilePicture = "girl_031.jpg"
            };
            s069 = new Student
            {
                LastName = "Сегеда",
                FirstName = "Ксенія",
                Patronymic = "Ярославівна",
                DateOfBirth = DateTime.Parse("2011-12-07"),
                Address = "вул. Злагоди, буд. 54, кв. 17",
                Gender = "Жіноча",
                ProfilePicture = "girl_032.jpg"
            };
            s070 = new Student
            {
                LastName = "Семенюта",
                FirstName = "Михайло",
                Patronymic = "Кирилович",
                DateOfBirth = DateTime.Parse("2011-11-15"),
                Address = "вул. Калинова, буд. 25, кв. 34",
                Gender = "Чоловіча",
                ProfilePicture = "boy_038.jpg"
            };
            s071 = new Student
            {
                LastName = "Скрипников",
                FirstName = "Платон",
                Patronymic = "Геннадійович",
                DateOfBirth = DateTime.Parse("2011-05-11"),
                Address = "вул. Калнишевського, буд. 41, кв. 44",
                Gender = "Чоловіча",
                ProfilePicture = "boy_039.jpg"
            };
            s072 = new Student
            {
                LastName = "Тіщенко",
                FirstName = "Таїсія",
                Patronymic = "Едуардівна",
                DateOfBirth = DateTime.Parse("2011-05-12"),
                Address = "вул. Кармелюка, буд. 44, кв. 15",
                Gender = "Жіноча",
                ProfilePicture = "girl_033.jpg"
            };
            #endregion
            #region 7-А
            s073 = new Student
            {
                LastName = "Трофименко",
                FirstName = "Кіра",
                Patronymic = "Романівна",
                DateOfBirth = DateTime.Parse("2010-10-30"),
                Address = "вул. Каштанова, буд. 27, кв. 13",
                Gender = "Жіноча",
                ProfilePicture = "girl_034.jpg"
            };
            s074 = new Student
            {
                LastName = "Фещенко",
                FirstName = "Анастасія",
                Patronymic = "Михайлівна",
                DateOfBirth = DateTime.Parse("2010-09-13"),
                Address = "вул. Квітнева, буд. 15, кв. 4",
                Gender = "Жіноча",
                ProfilePicture = "girl_035.jpg"
            };
            s075 = new Student
            {
                LastName = "Хамід",
                FirstName = "Рустам",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2010-05-10"),
                Address = "вул. Квятковського, буд. 17, кв. 15",
                Gender = "Чоловіча",
                ProfilePicture = "boy_040.jpg"
            };
            s076 = new Student
            {
                LastName = "Харсіка",
                FirstName = "Марія",
                Patronymic = "Борисівна",
                DateOfBirth = DateTime.Parse("2010-07-05"),
                Address = "вул. Київська, буд. 10, кв. 7",
                Gender = "Жіноча",
                ProfilePicture = "girl_036.jpg"
            };
            s077 = new Student
            {
                LastName = "Цесаренко",
                FirstName = "Дар'я",
                Patronymic = "Георгіївна",
                DateOfBirth = DateTime.Parse("2010-11-14"),
                Address = "вул. Кириченка, буд. 33, кв. 80",
                Gender = "Жіноча",
                ProfilePicture = "girl_037.jpg"
            };
            s078 = new Student
            {
                LastName = "Лойко",
                FirstName = "Олександр",
                Patronymic = "Степанович",
                DateOfBirth = DateTime.Parse("2010-07-07"),
                Address = "вул. Княжа, буд. 14, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_041.jpg"
            };
            #endregion
            #region 7-Б
            s079 = new Student
            {
                LastName = "Медвідь",
                FirstName = "Олександр",
                Patronymic = "Денисович",
                DateOfBirth = DateTime.Parse("2010-12-13"),
                Address = "вул. Кобзарська, буд. 37, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_042.jpg"
            };
            s080 = new Student
            {
                LastName = "Миронюк",
                FirstName = "Гліб",
                Patronymic = "Павлович",
                DateOfBirth = DateTime.Parse("2010-07-04"),
                Address = "вул. Кобилянської, буд. 39, кв. 19",
                Gender = "Чоловіча",
                ProfilePicture = "boy_043.jpg"
            };
            s081 = new Student
            {
                LastName = "Нещерет",
                FirstName = "Ілля",
                Patronymic = "Леонідович",
                DateOfBirth = DateTime.Parse("2010-05-18"),
                Address = "вул. Козацька, буд. 16, кв. 37",
                Gender = "Чоловіча",
                ProfilePicture = "boy_044.jpg"
            };
            s082 = new Student
            {
                LastName = "Роєнко",
                FirstName = "Олександр",
                Patronymic = "Романович",
                DateOfBirth = DateTime.Parse("2010-10-07"),
                Address = "вул. Коновальця, буд. 89, кв. 15",
                Gender = "Чоловіча",
                ProfilePicture = "boy_045.jpg"
            };
            s083 = new Student
            {
                LastName = "Свинченко",
                FirstName = "Анастасія",
                Patronymic = "Сергіївна",
                DateOfBirth = DateTime.Parse("2010-07-11"),
                Address = "вул. Конощенка, буд. 45, кв. 57",
                Gender = "Жіноча",
                ProfilePicture = "girl_038.jpg"
            };
            s084 = new Student
            {
                LastName = "Святовець",
                FirstName = "Катерина",
                Patronymic = "Тимофіївна",
                DateOfBirth = DateTime.Parse("2010-04-03"),
                Address = "вул. Кооперативна, буд. 18, кв. 23",
                Gender = "Жіноча",
                ProfilePicture = "girl_039.jpg"
            };
            #endregion
            #region 8-А
            s085 = new Student
            {
                LastName = "Сісєва",
                FirstName = "Софія",
                Patronymic = "Володимирівна",
                DateOfBirth = DateTime.Parse("2009-01-04"),
                Address = "вул. Короленка, буд. 14, кв. 15",
                Gender = "Жіноча",
                ProfilePicture = "girl_040.jpg"
            };
            s086 = new Student
            {
                LastName = "Смілянець",
                FirstName = "Платон",
                Patronymic = "Михайлович",
                DateOfBirth = DateTime.Parse("2009-05-08"),
                Address = "вул. Корсакова, буд. 10, кв. 14",
                Gender = "Чоловіча",
                ProfilePicture = "boy_046.jpg"
            };
            s087 = new Student
            {
                LastName = "Соловйова",
                FirstName = "Поліна",
                Patronymic = "Олександрівна",
                DateOfBirth = DateTime.Parse("2009-03-13"),
                Address = "вул. Космонавтів, буд. 5, кв. 1",
                Gender = "Жіноча",
                ProfilePicture = "girl_041.jpg"
            };
            s088 = new Student
            {
                LastName = "Тарасова",
                FirstName = "Софія",
                Patronymic = "Іванівна",
                DateOfBirth = DateTime.Parse("2009-12-10"),
                Address = "вул. Костомарова, буд. 18, кв. 22",
                Gender = "Жіноча",
                ProfilePicture = "girl_042.jpg"
            };
            s089 = new Student
            {
                LastName = "Хурцідзе",
                FirstName = "Ліа",
                Patronymic = "Денисівна",
                DateOfBirth = DateTime.Parse("2009-11-14"),
                Address = "вул. Коцюбинського, буд. 33, кв. 14",
                Gender = "Жіноча",
                ProfilePicture = "girl_043.jpg"
            };
            s090 = new Student
            {
                LastName = "Шарай",
                FirstName = "Матвій",
                Patronymic = "Романович",
                DateOfBirth = DateTime.Parse("2009-05-04"),
                Address = "вул. Красилівська, буд. 16, кв. 28",
                Gender = "Чоловіча",
                ProfilePicture = "boy_047.jpg"
            };
            #endregion
            #region 8-Б
            s091 = new Student
            {
                LastName = "Андронік",
                FirstName = "Юнія",
                Patronymic = "Ярославівна",
                DateOfBirth = DateTime.Parse("2009-03-05"),
                Address = "вул. Крушельницької, буд. 21, кв. 17",
                Gender = "Жіноча",
                ProfilePicture = "girl_044.jpg"
            };
            s092 = new Student
            {
                LastName = "Арендар",
                FirstName = "Іван",
                Patronymic = "Костянтинович",
                DateOfBirth = DateTime.Parse("2009-08-19"),
                Address = "вул. Куліша, буд. 24, кв. 10",
                Gender = "Чоловіча",
                ProfilePicture = "boy_048.jpg"
            };
            s093 = new Student
            {
                LastName = "Бистра",
                FirstName = "Анастасія",
                Patronymic = "Ярославівна",
                DateOfBirth = DateTime.Parse("2009-09-18"),
                Address = "вул. Лагунової, буд. 6, кв. 19",
                Gender = "Жіноча",
                ProfilePicture = "girl_045.jpg"
            };
            s094 = new Student
            {
                LastName = "Бондаренко",
                FirstName = "Олександра",
                Patronymic = "Семенівна",
                DateOfBirth = DateTime.Parse("2009-08-13"),
                Address = "вул. Левадівська, буд. 27, кв. 54",
                Gender = "Чоловіча",
                ProfilePicture = "boy_049.jpg"
            };
            s095 = new Student
            {
                LastName = "Бойко",
                FirstName = "Тимур",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2009-03-16"),
                Address = "вул. Леонтовича, буд. 18, кв. 9",
                Gender = "Чоловіча",
                ProfilePicture = "boy_050.jpg"
            };
            s096 = new Student
            {
                LastName = "Глізнуца",
                FirstName = "Даніл",
                Patronymic = "Єгорович",
                DateOfBirth = DateTime.Parse("2009-04-05"),
                Address = "вул. Лермонтова, буд. 4, кв. 16",
                Gender = "Чоловіча",
                ProfilePicture = "boy_051.jpg"
            };
            #endregion
            #region 9-А
            s097 = new Student
            {
                LastName = "Гончаренко",
                FirstName = "Дар'я",
                Patronymic = "Романівна",
                DateOfBirth = DateTime.Parse("2008-05-15"),
                Address = "вул. Лисенка, буд. 23, кв. 18",
                Gender = "Жіноча",
                ProfilePicture = "girl_046.jpg"
            };
            s098 = new Student
            {
                LastName = "Громак",
                FirstName = "Владислав",
                Patronymic = "Денисович",
                DateOfBirth = DateTime.Parse("2008-06-07"),
                Address = "вул. Лісова, буд. 14, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_052.jpg"
            };
            s099 = new Student
            {
                LastName = "Гуриненко",
                FirstName = "Іван",
                Patronymic = "Костянтинович",
                DateOfBirth = DateTime.Parse("2008-08-07"),
                Address = "вул. Ломоносова, буд. 54, кв. 36",
                Gender = "Чоловіча",
                ProfilePicture = "boy_053.jpg"
            };
            s100 = new Student
            {
                LastName = "Лясовий",
                FirstName = "Єгор",
                Patronymic = "Харитонович",
                DateOfBirth = DateTime.Parse("2008-03-05"),
                Address = "вул. Лугова, буд. 49, кв. 43",
                Gender = "Чоловіча",
                ProfilePicture = "boy_054.jpg"
            };
            s101 = new Student
            {
                LastName = "Маланяк",
                FirstName = "Вікторія",
                Patronymic = "Семенівна",
                DateOfBirth = DateTime.Parse("2008-04-19"),
                Address = "вул. Львівська, буд. 57, кв. 13",
                Gender = "Жіноча",
                ProfilePicture = "girl_047.jpg"
            };
            s102 = new Student
            {
                LastName = "Момонт",
                FirstName = "Артур",
                Patronymic = "Едуардович",
                DateOfBirth = DateTime.Parse("2008-08-23"),
                Address = "вул. Мазепи, буд. 49, кв. 17",
                Gender = "Чоловіча",
                ProfilePicture = "boy_055.jpg"
            };
            #endregion
            #region 9-Б
            s103 = new Student
            {
                LastName = "Мирончук",
                FirstName = "Уляна",
                Patronymic = "Дмитрівна",
                DateOfBirth = DateTime.Parse("2008-05-07"),
                Address = "вул. Майбороди, буд. 13, кв. 33",
                Gender = "Жіноча",
                ProfilePicture = "girl_048.jpg"
            };
            s104 = new Student
            {
                LastName = "Плюта",
                FirstName = "Марк",
                Patronymic = "Олексійович",
                DateOfBirth = DateTime.Parse("2008-08-04"),
                Address = "вул. Максимовича, буд. 16, кв. 33",
                Gender = "Чоловіча",
                ProfilePicture = "boy_056.jpg"
            };
            s105 = new Student
            {
                LastName = "Трухін",
                FirstName = "Артем",
                Patronymic = "Зіновійович",
                DateOfBirth = DateTime.Parse("2008-07-13"),
                Address = "вул. Малокиївська, буд. 47, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_057.jpg"
            };
            s106 = new Student
            {
                LastName = "Тертична",
                FirstName = "Анна",
                Patronymic = "Василівна",
                DateOfBirth = DateTime.Parse("2008-11-14"),
                Address = "вул. Мальовнича, буд. 22, кв. 39",
                Gender = "Жіноча",
                ProfilePicture = "girl_049.jpg"
            };
            s107 = new Student
            {
                LastName = "Степанчук",
                FirstName = "Матвій",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2008-06-13"),
                Address = "вул. Маяковського, буд. 19, кв. 18",
                Gender = "Чоловіча",
                ProfilePicture = "boy_058.jpg"
            };
            s108 = new Student
            {
                LastName = "Яковенко",
                FirstName = "Євгеній",
                Patronymic = "Володимирович",
                DateOfBirth = DateTime.Parse("2008-05-05"),
                Address = "вул. Мельника, буд. 46, кв. 71",
                Gender = "Чоловіча",
                ProfilePicture = "boy_059.jpg"
            };
            #endregion
            #region 10-А
            s109 = new Student
            {
                LastName = "Янковський",
                FirstName = "Денис",
                Patronymic = "Володимирович",
                DateOfBirth = DateTime.Parse("2007-04-03"),
                Address = "вул. Металургів, буд. 43, кв. 51",
                Gender = "Чоловіча",
                ProfilePicture = "boy_060.jpg"
            };
            s110 = new Student
            {
                LastName = "Яренко",
                FirstName = "Марк",
                Patronymic = "Володимирович",
                DateOfBirth = DateTime.Parse("2007-03-15"),
                Address = "вул. Миру, буд. 34, кв. 81",
                Gender = "Чоловіча",
                ProfilePicture = "boy_061.jpg"
            };
            s111 = new Student
            {
                LastName = "Бережнова",
                FirstName = "Надія",
                Patronymic = "Ростиславівна",
                DateOfBirth = DateTime.Parse("2007-05-09"),
                Address = "вул. Мічуріна, буд. 26, кв. 73",
                Gender = "Жіноча",
                ProfilePicture = "girl_050.jpg"
            };
            s112 = new Student
            {
                LastName = "Броницька",
                FirstName = "Яна",
                Patronymic = "Кирилівна",
                DateOfBirth = DateTime.Parse("2007-08-13"),
                Address = "вул. Молодіжна, буд. 41, кв. 19",
                Gender = "Жіноча",
                ProfilePicture = "girl_051.jpg"
            };
            s113 = new Student
            {
                LastName = "Дзюманенко",
                FirstName = "Юлія",
                Patronymic = "Борисівна",
                DateOfBirth = DateTime.Parse("2007-01-05"),
                Address = "вул. Москаленка, буд. 16, кв. 5",
                Gender = "Жіноча",
                ProfilePicture = "girl_052.jpg"
            };
            s114 = new Student
            {
                LastName = "Ільчук",
                FirstName = "Єгор",
                Patronymic = "Данилович",
                DateOfBirth = DateTime.Parse("2007-04-10"),
                Address = "вул. Некрасова, буд. 53, кв. 37",
                Gender = "Чоловіча",
                ProfilePicture = "boy_062.jpg"
            };
            #endregion
            #region 10-Б
            s115 = new Student
            {
                LastName = "Касьян",
                FirstName = "Ірина",
                Patronymic = "Олегівна",
                DateOfBirth = DateTime.Parse("2007-05-06"),
                Address = "вул. Оболонська, буд. 22, кв. 13",
                Gender = "Жіноча",
                ProfilePicture = "girl_053.jpg"
            };
            s116 = new Student
            {
                LastName = "Качинський",
                FirstName = "Валентин",
                Patronymic = "Романович",
                DateOfBirth = DateTime.Parse("2007-01-18"),
                Address = "вул. Огієнка, буд. 37, кв. 41",
                Gender = "Чоловіча",
                ProfilePicture = "boy_063.jpg"
            };
            s117 = new Student
            {
                LastName = "Клокун",
                FirstName = "Аліна",
                Patronymic = "Олегівна",
                DateOfBirth = DateTime.Parse("2007-10-15"),
                Address = "вул. Оксамитова, буд. 18, кв. 16",
                Gender = "Жіноча",
                ProfilePicture = "girl_054.jpg"
            };
            s118 = new Student
            {
                LastName = "Коломійцева",
                FirstName = "Інна",
                Patronymic = "Леонідівна",
                DateOfBirth = DateTime.Parse("2007-03-17"),
                Address = "вул. Олександровича, буд. 64, кв. 37",
                Gender = "Жіноча",
                ProfilePicture = "girl_055.jpg"
            };
            s119 = new Student
            {
                LastName = "Костюченко",
                FirstName = "Дар'я",
                Patronymic = "Василівна",
                DateOfBirth = DateTime.Parse("2007-11-14"),
                Address = "вул. Олійника, буд. 29, кв. 16",
                Gender = "Жіноча",
                ProfilePicture = "girl_056.jpg"
            };
            s120 = new Student
            {
                LastName = "Куделя",
                FirstName = "Арсеній",
                Patronymic = "Валентинович",
                DateOfBirth = DateTime.Parse("2007-05-09"),
                Address = "вул. Олімпійська, буд. 15, кв. 1",
                Gender = "Чоловіча",
                ProfilePicture = "boy_064.jpg"
            };
            #endregion
            #region 11-А
            s121 = new Student
            {
                LastName = "Моголівець",
                FirstName = "Вероніка",
                Patronymic = "Юріївна",
                DateOfBirth = DateTime.Parse("2006-03-13"),
                Address = "вул. Ольжича, буд. 14, кв. 21",
                Gender = "Жіноча",
                ProfilePicture = "girl_057.jpg"
            };
            s122 = new Student
            {
                LastName = "Оборська",
                FirstName = "Поліна",
                Patronymic = "Костянтинівна",
                DateOfBirth = DateTime.Parse("2006-04-22"),
                Address = "вул. Онікієнка, буд. 31, кв. 16",
                Gender = "Жіноча",
                ProfilePicture = "girl_058.jpg"
            };
            s123 = new Student
            {
                LastName = "Опанасенко",
                FirstName = "Ірина",
                Patronymic = "Гаврилівна",
                DateOfBirth = DateTime.Parse("2006-12-14"),
                Address = "вул. Орлика, буд. 61, кв. 19",
                Gender = "Жіноча",
                ProfilePicture = "girl_059.jpg"
            };
            s124 = new Student
            {
                LastName = "Помінчук",
                FirstName = "Дарина",
                Patronymic = "Сергіївна",
                DateOfBirth = DateTime.Parse("2006-06-03"),
                Address = "вул. Освіти, буд. 20, кв. 41",
                Gender = "Жіноча",
                ProfilePicture = "girl_060.jpg"
            };
            s125 = new Student
            {
                LastName = "Чепинога",
                FirstName = "Катерина",
                Patronymic = "Тимофіївна",
                DateOfBirth = DateTime.Parse("2006-08-26"),
                Address = "вул. Осьмака, буд. 13, кв. 17",
                Gender = "Жіноча",
                ProfilePicture = "girl_061.jpg"
            };
            s126 = new Student
            {
                LastName = "Єгорова",
                FirstName = "Єлизавета",
                Patronymic = "Романівна",
                DateOfBirth = DateTime.Parse("2006-09-22"),
                Address = "вул. Павлова, буд. 17, кв. 40",
                Gender = "Жіноча",
                ProfilePicture = "girl_062.jpg"
            };
            #endregion
            #region 11-Б
            s127 = new Student
            {
                LastName = "Огійко",
                FirstName = "Катерина",
                Patronymic = "Леонідівна",
                DateOfBirth = DateTime.Parse("2006-05-16"),
                Address = "вул. Перонна, буд. 10, кв. 16",
                Gender = "Жіноча",
                ProfilePicture = "girl_063.jpg"
            };
            s128 = new Student
            {
                LastName = "Онищук",
                FirstName = "Ілля",
                Patronymic = "Максимович",
                DateOfBirth = DateTime.Parse("2006-10-13"),
                Address = "вул. Петлюри, буд. 41, кв. 20",
                Gender = "Чоловіча",
                ProfilePicture = "boy_065.jpg"
            };
            s129 = new Student
            {
                LastName = "Пастушенко",
                FirstName = "Софія",
                Patronymic = "Валеріївна",
                DateOfBirth = DateTime.Parse("2006-05-18"),
                Address = "вул. Петропавлівська, буд. 14, кв. 17",
                Gender = "Жіноча",
                ProfilePicture = "girl_064.jpg"
            };
            s130 = new Student
            {
                LastName = "Пишняк",
                FirstName = "Максим",
                Patronymic = "Назарович",
                DateOfBirth = DateTime.Parse("2006-08-10"),
                Address = "вул. Підлісна, буд. 31, кв. 10",
                Gender = "Чоловіча",
                ProfilePicture = "boy_066.jpg"
            };
            s131 = new Student
            {
                LastName = "Полякова",
                FirstName = "Вікторія",
                Patronymic = "Олексіївна",
                DateOfBirth = DateTime.Parse("2006-04-30"),
                Address = "вул. Підприємницька, буд. 1, кв. 6",
                Gender = "Жіноча",
                ProfilePicture = "girl_065.jpg"
            };
            s132 = new Student
            {
                LastName = "Рибак",
                FirstName = "Роман",
                Patronymic = "Іванович",
                DateOfBirth = DateTime.Parse("2006-08-27"),
                Address = "вул. Пластунська, буд. 14, кв. 44",
                Gender = "Чоловіча",
                ProfilePicture = "boy_067.jpg"
            };
            #endregion
            #endregion
            #region Add students
            data = new List<Student>();
            data.Add(s001);
            data.Add(s002);
            data.Add(s003);
            data.Add(s004);
            data.Add(s005);
            data.Add(s006);
            data.Add(s007);
            data.Add(s008);
            data.Add(s009);
            data.Add(s010);
            data.Add(s011);
            data.Add(s012);
            data.Add(s013);
            data.Add(s014);
            data.Add(s015);
            data.Add(s016);
            data.Add(s017);
            data.Add(s018);
            data.Add(s019);
            data.Add(s020);
            data.Add(s021);
            data.Add(s022);
            data.Add(s023);
            data.Add(s024);
            data.Add(s025);
            data.Add(s026);
            data.Add(s027);
            data.Add(s028);
            data.Add(s029);
            data.Add(s030);
            data.Add(s031);
            data.Add(s032);
            data.Add(s033);
            data.Add(s034);
            data.Add(s035);
            data.Add(s036);
            data.Add(s037);
            data.Add(s038);
            data.Add(s039);
            data.Add(s040);
            data.Add(s041);
            data.Add(s042);
            data.Add(s043);
            data.Add(s044);
            data.Add(s045);
            data.Add(s046);
            data.Add(s047);
            data.Add(s048);
            data.Add(s049);
            data.Add(s050);
            data.Add(s051);
            data.Add(s052);
            data.Add(s053);
            data.Add(s054);
            data.Add(s055);
            data.Add(s056);
            data.Add(s057);
            data.Add(s058);
            data.Add(s059);
            data.Add(s060);
            data.Add(s061);
            data.Add(s062);
            data.Add(s063);
            data.Add(s064);
            data.Add(s065);
            data.Add(s066);
            data.Add(s067);
            data.Add(s068);
            data.Add(s069);
            data.Add(s070);
            data.Add(s071);
            data.Add(s072);
            data.Add(s073);
            data.Add(s074);
            data.Add(s075);
            data.Add(s076);
            data.Add(s077);
            data.Add(s078);
            data.Add(s079);
            data.Add(s080);
            data.Add(s081);
            data.Add(s082);
            data.Add(s083);
            data.Add(s084);
            data.Add(s085);
            data.Add(s086);
            data.Add(s087);
            data.Add(s088);
            data.Add(s089);
            data.Add(s090);
            data.Add(s091);
            data.Add(s092);
            data.Add(s093);
            data.Add(s094);
            data.Add(s095);
            data.Add(s096);
            data.Add(s097);
            data.Add(s098);
            data.Add(s099);
            data.Add(s100);
            data.Add(s101);
            data.Add(s102);
            data.Add(s103);
            data.Add(s104);
            data.Add(s105);
            data.Add(s106);
            data.Add(s107);
            data.Add(s108);
            data.Add(s109);
            data.Add(s110);
            data.Add(s111);
            data.Add(s112);
            data.Add(s113);
            data.Add(s114);
            data.Add(s115);
            data.Add(s116);
            data.Add(s117);
            data.Add(s118);
            data.Add(s119);
            data.Add(s120);
            data.Add(s121);
            data.Add(s122);
            data.Add(s123);
            data.Add(s124);
            data.Add(s125);
            data.Add(s126);
            data.Add(s127);
            data.Add(s128);
            data.Add(s129);
            data.Add(s130);
            data.Add(s131);
            data.Add(s132);

            #endregion
        }
    }
}
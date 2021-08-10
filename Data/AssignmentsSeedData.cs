using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static sms.Data.GradesSeedData;
using static sms.Data.SubjectsSeedData;
using static sms.Data.TeachersSeedData;

namespace sms.Data
{
    public class AssignmentsSeedData
    {
        public static List<Assignment> data = new List<Assignment>
        {
            new Assignment
            {
                DateOfPost = new DateTime(2021, 8, 9, 21, 51, 46),
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro,
                Post = @"<p style=""text-align: center"" align=""center""><span lang=""UK"" style=""font-size: 16pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Контрольна робота для 5 класу на тему: «Будова слова. Написання префіксів та суфіксів»</span></p>
<p style=""text-align: center"" align=""center""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">І варіант</span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>1.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Доберіть спільнокореневі слова до слова <strong>хмара</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>2.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Доберіть форми слова до слова <strong>ліс</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>3.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Розберіть за будовою слова <strong>високий, вночі, безхмарний</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>4.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>при-</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>5.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>прі-</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>6.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>пре-</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>7.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Вставте пропущені букви <strong>в_сна, з_мля, в_шневий</strong></span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>8.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова, які не змінюються</span></p>
<p style=""margin-left: 39.25pt; text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>9.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Складіть 2 речення, де є слова з суфіксами пестливості</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;</span></p>
<p style=""text-align: center"" align=""center""><span style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">II</span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""> варіант</span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>1.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Доберіть спільнокореневі слова до слова<strong> сад</strong></span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>2.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Доберіть форми слова до слова<strong> школа</strong></span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>3.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Розберіть за будовою слова <strong>ввечері, низький, присадибний</strong></span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>4.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>при-</strong></span></p>
<p style=""text-indent: -18pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>5.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>прі-</strong></span></p>
<p style=""text-indent: -18pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>6.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова з префіксом <strong>пре-</strong></span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>7.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Вставте пропущені букви <strong>ст_повий, с_ло, д_вина</strong></span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>8.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Запишіть 3 слова, які не змінюються</span></p>
<p style=""text-indent: -18pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""><span>9.<span style=""font: 7pt &quot;Times New Roman&quot;"">&nbsp;&nbsp;&nbsp;&nbsp; </span></span></span><span lang=""UK"" style=""font-size: 14pt; line-height: 107%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Складіть 2 речення, де є слова з суфіксами пестливості</span></p>"
            },
            new Assignment
            {
                DateOfPost = new DateTime(2021, 8, 9, 22, 36, 55),
                Grade = a5,
                Subject = ukrainian,
                Teacher = havro,
                Post = @"<p style=""text-align: center"" align=""center""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Квест «Подорож країною Лексикологією» 5 клас</span></strong></p>
<p><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Учитель: </span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Любі діти! Нам слід попрощатися з наукою Лексикологією, яку ми вивчали певний період. Але наука поставила нам умову: нам слід пройти квест і довести, що готові&nbsp; до вивчення іншої науки. Для цього клас ділимо на дві групи. Та група, яка пройде тест з більшою кількістю балів, отримає диплом «Кращий гід країни Лексикологія».</span></p>
<p><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Завдання 1</span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">. «Визнач і зміни».</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Усі слова мови ми вживаємо або в прямому, або в переносному значенні. Завдання першого квесту&nbsp; не є виключенням. Ви повинні визначити: виділене слово зі словосполучення вжито в прямому чи переносному. Якщо в прямому, то слід відшукати з-поміж додаткових&nbsp; слів таке, з яким&nbsp; виділене слово стане з переносним значенням,&nbsp; і&nbsp; навпаки. У першому завдання беруть участь 6 гравців, по 3 з кожної команди. Якщо гравці команди-суперника не погоджуються з думкою гравця, вони можуть висловити власну. Якщо&nbsp; думка правильна,&nbsp; то команда заробить додатковий бал. Максимальна кількість балів за завдання &nbsp;6.)</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">НАПРИКЛАД:&nbsp; <strong>пшеничне </strong>поле (слово пшеничне вжито в прямому значенні). Шукаємо серед додаткових слів таке, з яким виділене слово змінить значення. Це слово – <strong>волосся.</strong></span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Вишнева</span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""> сукня (слово вишнева вжито в переносному значенні). Шукаємо серед додаткових слів таке, з яким виділене слово змінить значення. Це слово – <strong>гілка.</strong></span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Словосполучення:</span></strong></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Світла </span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">голова, &nbsp;<strong>гострий</strong> ніж, &nbsp;<strong>глибокі</strong> ущелини,&nbsp; <strong>добра </strong>криниця,&nbsp; <strong>солодкі </strong>слова, <strong>золоті </strong>прикраси).</span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Додаткові слова :</span></strong></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Розум, &nbsp;людина, &nbsp;ягоди, &nbsp;&nbsp;знання, &nbsp;сукня.</span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Завдання 2</span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">. «Хто швидше»</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Кожній команді роздано </span><span lang=""RU"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">слова</span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">. Ваше завдання об’єднати їх у синонімічні ряди. Та команда, яка виконає швидко і правильно, отримує 6 балів. Інша половину. Але якщо команда виконала перша та припустилася помилки, то вона повертається&nbsp; до виконання завдання.</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Йти, джерельце, веселий, рухатись, потічок, пересуватись, драйвовий, ключ, марширувати, прямувати, радісний.</span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Завдання 3 </span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">«Дуель» </span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">У цьому конкурсі бере участь по п’ятеро учнів з кожної команди. За жеребкуванням визначається котра з команд почне. Учасник першої команди обирає собі суперника. Двоє дуелянтів підходять до столу. Перший обирає слово і зачитує його вголос. Другий повинен підібрати антонім до нього. Якщо правильно підібрав, отримав 2 бали. Якщо не зміг, має шанс знайти в довіднику. Знайшов – отримав один бал. Ні – не отримав жодного. Потім гравці міняються ролями.<strong> </strong>Максимальна кількість балів 20.</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;</span></p>
<p style=""text-indent: 14.2pt""><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Завдання 4 </span></strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">«Знайди пару»</span></p>
<p style=""text-indent: 14.2pt""><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Кожній команді даються малюнки слів-омонімів. Їхнє завдання – знайти пару й назвати слово завуальоване в малюнках. За кожну правильну пару – 2 бали. Максимальна кількість – 14 балів.</span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</span></p>
<p><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Завдання </span></strong><strong><span lang=""RU"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">5 </span></strong><span lang=""RU"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">« </span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Знайди помилку»</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Ваше завдання</span><span lang=""RU"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">: </span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;знайти </span><span lang=""RU"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">в</span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""> реченнях помилки й виправити</span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;""> </span><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">їх. &nbsp;За кожну правильно визначену помилку 1 бал. Якщо виправили слушно, то отримуєте додатковий бал. Речень - 5. Максимальна кількість балів 10.</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">1.Лікар призначив&nbsp; ефектні ліки. 2. Я люблю свій дружній клас. 3. На шкільній дільниці ми висадили квіти. 4. Ця дівчина освітлена – має два дипломи. 5. Мій брат дипломат міжнародного вокального конкурсу.</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Правильно:</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">1.Лікар призначив&nbsp; ефективні ліки. 2. Я люблю свій дружний клас. 3. На шкільній ділянці ми висадили квіти. 4. Ця дівчина освічена – має два дипломи. 5. Мій брат дипломант міжнародного вокального конкурсу.</span></p>
<p><strong><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">ПІДСУМОК:</span></strong></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">Оголошення результатів квесту й нагородження переможців.</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;</span></p>
<p><span lang=""UK"" style=""font-size: 14pt; line-height: 115%; font-family: &quot;Times New Roman&quot;, &quot;serif&quot;"">&nbsp;</span></p>"
            },
            new Assignment
            {
                DateOfPost = new DateTime(2021, 8, 9, 22, 39, 11),
                Grade = a5,
                Subject = english,
                Teacher = martynenko,
                Post = @"<h2 style=""margin: 1em 0 0.25em; padding: 0; overflow: hidden; border-bottom: 1px solid rgba(162, 169, 177, 1); font-weight: normal; font-family: &quot;Linux Libertine&quot;, Georgia, Times, serif; line-height: 1.3; background-color: rgba(255, 255, 255, 1)"">Запам'ятай правила транслітерації:</h2>
<table style=""font-size: 14px; background-color: rgba(248, 249, 250, 1); color: rgba(32, 33, 34, 1); margin: 1em 0; border: 1px solid rgba(162, 169, 177, 1); font-family: sans-serif"">
<tbody>
<tr>
<th style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em; background-color: rgba(234, 236, 240, 1); text-align: center""><strong>Українська</strong></th>
<th style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em; background-color: rgba(234, 236, 240, 1); text-align: center""><strong>Англійська</strong></th>
<th style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em; background-color: rgba(234, 236, 240, 1); text-align: center""><strong>Коментарі</strong></th>
<th style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em; background-color: rgba(234, 236, 240, 1); text-align: center""><strong>Приклад</strong></th>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">А</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">А</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Алушта&nbsp;— Alushta</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Б</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">B</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Борщагівка&nbsp;— Borshchahivka</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">В</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">V</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Вишгород&nbsp;— Vyshhorod</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Г</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">H</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Гадяч&nbsp;— Hadiach;Згорани&nbsp;— Zghorany</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ґ</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">G</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ґалаґан&nbsp;— Galagan</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Д</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">D</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Дон&nbsp;— Don</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Е</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">E</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Рівне&nbsp;— Rivne</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Є</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ye, ie</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ye&nbsp;— на початку слова, іе&nbsp;— в інших позиціях</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Єнакієве&nbsp;— Yenakiieve;Наєнко&nbsp;— Naienko</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ж</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Zh</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Житомир&nbsp;— Zhytomyr</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">З</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Z</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Закарпаття&nbsp;— Zakarpattia</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">И</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Y</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Медвин&nbsp;— Medvyn</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">І</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">I</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Іршава&nbsp;— Irshava</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ї</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Yi, i</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Yi&nbsp;— на початку слова, і&nbsp;— в інших позиціях</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Їжакевич&nbsp;— Yizhakevych;Кадіївка&nbsp;— Kadiivka</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Й</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Y, i</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Y&nbsp;— на початку слова, і&nbsp;— в інших позиціях</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Йосипівка&nbsp;— Yosypivka;Стрий&nbsp;— Stryi</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">К</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">K</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Київ&nbsp;— Kyiv</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Л</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">L</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Лебедин&nbsp;— Lebedyn</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">М</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">M</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Миколаїв&nbsp;— Mykolaiv</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Н</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">N</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ніжин&nbsp;— Nizhyn</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">О</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">O</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Одеса&nbsp;— Odesa</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">П</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">P</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Полтава&nbsp;— Poltava</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Р</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">R</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ромни&nbsp;— Romny</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">С</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">S</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Суми&nbsp;— Sumy</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Т</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">T</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Тетерів&nbsp;— Teteriv</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">У</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">U</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ужгород&nbsp;— Uzhhorod</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ф</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">F</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Фастів&nbsp;— Fastiv</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Х</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Kh</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Харків&nbsp;— Kharkiv</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ц</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ts</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Біла Церква&nbsp;— Bila Tserkva</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ч</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ch</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Чернівці&nbsp;— Chernivtsi</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ш</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Sh</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Шостка&nbsp;— Shostka</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Щ</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Shch</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">-</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Гоща -Hoshcha</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ю</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Yu, iu</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Yu&nbsp;— на початку слова, iu&nbsp;— в інших позиціях</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Юрій&nbsp;— Yurii;Крюківка&nbsp;— Kriukivka</td>
</tr>
<tr>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Я</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ya, ia</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Ya&nbsp;— на початку слова, іа&nbsp;— в інших позиціях</td>
<td style=""border: 1px solid rgba(162, 169, 177, 1); padding: 0.2em 0.4em"">Яготин&nbsp;— Yahotyn;Ічня&nbsp;— Ichnia</td>
</tr>
</tbody>
</table>
<p style=""margin: 0.5em 0; color: rgba(32, 33, 34, 1); font-family: sans-serif; font-size: 14px; background-color: rgba(255, 255, 255, 1)""><strong><big>Примітки</big>:</strong><br><strong>1.</strong>&nbsp;Буквосполучення «зг» відтворюється латиницею як «zgh» (наприклад, Згорани&nbsp;— Zghorany, Розгон&nbsp;— Rozghon) на відміну від «zh»&nbsp;— відповідника української літери «ж».<br><strong>2.</strong>&nbsp;М'який знак і апостроф латиницею не відтворюються.<br><strong>3.</strong>&nbsp;Транслітерація прізвищ та імен осіб і географічних назв здійснюється шляхом відтворення кожної літери латиницею.</p>"
            }
        };
    }
}

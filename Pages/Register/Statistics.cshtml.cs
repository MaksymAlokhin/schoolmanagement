using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор, Вчитель")]
    public class StatisticsModel : PageModel
    {
        public StatisticsModel(sms.Data.ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly sms.Data.ApplicationDbContext _context;
        public string NameSort { get; set; }
        public string MarkSort { get; set; }
        public string CurrentSort { get; set; }

        public List<SelectListItem> YearSL { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = $"{DateTime.Now.Year-2}", Text = $"{DateTime.Now.Year-2}" },
            new SelectListItem { Value = $"{DateTime.Now.Year-1}", Text = $"{DateTime.Now.Year-1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year}", Text = $"{DateTime.Now.Year}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+1}", Text = $"{DateTime.Now.Year+1}" },
            new SelectListItem { Value = $"{DateTime.Now.Year+2}", Text = $"{DateTime.Now.Year+2}" }
        };
        public List<SelectListItem> SemesterSL { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "1", Text = "І семестр" },
            new SelectListItem { Value = "2", Text = "ІІ семестр" }
        };
        public SelectList YearList;
        public List<Stats> grades;
        public List<Gradebook> gradebooks;
        public List<Curriculum> curricula;
        public int selectedYear;
        public int selectedSemester;

        public void OnGetAsync(string sortOrder, int year = 0, int semester = 1)
        {
            YearList = new SelectList(YearSL, "Value", "Text", $"{DateTime.Now.Year}");
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;
            selectedSemester = semester;

            //Select time period
            //Вибір часового проміжку
            DateTime startDate1 = new DateTime(selectedYear, 9, 1);
            DateTime startDate2 = new DateTime(selectedYear, 1, 1);
            DateTime endDate1 = new DateTime(selectedYear, 12, 31);
            DateTime endDate2 = new DateTime(selectedYear, 5, 31);
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            switch (selectedSemester)
            {
                case 1:
                    startDate = startDate1;
                    endDate = endDate1;
                    break;
                case 2:
                    startDate = startDate2;
                    endDate = endDate2;
                    break;
            }

            //Generate data for academic performance table
            //Генерація даних для таблиці успішності по класам
            var gradesIQ = _context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Mark != "0")
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new Stats
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                });

            var test = gradesIQ.ToList();

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            MarkSort = sortOrder == "mark" ? "mark_desc" : "mark";

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    gradesIQ = gradesIQ.OrderByDescending(s => s.Number).ThenByDescending(s => s.Letter);
                    break;
                case "mark":
                    gradesIQ = gradesIQ.OrderBy(s => s.Avg);
                    break;
                case "mark_desc":
                    gradesIQ = gradesIQ.OrderByDescending(s => s.Avg);
                    break;
                default:
                    gradesIQ = gradesIQ.OrderBy(s => s.Number).ThenBy(s => s.Number);
                    break;
            }

            grades = gradesIQ.ToList();
        }
        //Generate data for academic performance chart by grade
        //Генерація даних для діаграми успішності по класам
        public JsonResult OnPostData(int year, int semester)
        {
            //Select time period
            //Вибір часового проміжку
            DateTime startDate1 = new DateTime(year, 9, 1);
            DateTime startDate2 = new DateTime(year, 1, 1);
            DateTime endDate1 = new DateTime(year, 12, 31);
            DateTime endDate2 = new DateTime(year, 5, 31);
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;
            switch (semester)
            {
                case 1:
                    startDate = startDate1;
                    endDate = endDate1;
                    break;
                case 2:
                    startDate = startDate2;
                    endDate = endDate2;
                    break;
            }

            //Generate data for academic performance chart
            //Генерація даних для діаграми успішності по класам
            var grades = _context.Gradebooks
                .Include(s => s.Student)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Mark != "0")
                .Select(s => new
                {
                    Id = s.Student.GradeId,
                    Mark = s.Mark,
                    Name = s.Student.Grade.FullName,
                    Number = s.Student.Grade.Number,
                    Letter = s.Student.Grade.Letter
                })
                .ToList()
                .GroupBy(s => new { s.Name, s.Id, s.Letter, s.Number })
                .Select(g => new Stats
                {
                    Id = g.Key.Id,
                    Name = g.Key.Name,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1),
                    Number = g.Key.Number,
                    Letter = g.Key.Letter
                })
                .OrderBy(s => s.Number).ThenBy(s => s.Letter)
                .ToList();

            return new JsonResult(grades);
        }
    }
    //Data structure for academic performance chart and table
    //Структура даних для діагарми та таблиці успішності по класам
    public class Stats
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Letter { get; set; }
        public string Name { get; set; }
        public double Avg { get; set; }
    }
}

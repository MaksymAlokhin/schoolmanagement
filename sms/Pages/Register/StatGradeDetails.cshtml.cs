using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using sms.Data;
using sms.Models;

namespace sms.Pages.Register
{
    [Authorize(Roles = "Адміністратор")]
    public class StatGradeDetailsModel : PageModel
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly IConfiguration Configuration;

        public StatGradeDetailsModel(sms.Data.ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }
        public List<Gradebook> gradebooks;
        public int selectedYear;
        public int selectedGrade;
        public string gradeName;
        public int selectedSemester;
        public PaginatedList<StatGradeDetails> subjects;
        public string NameSort { get; set; }
        public string MarkSort { get; set; }
        public string CurrentSort { get; set; }

        public async Task<IActionResult> OnGetAsync(string sortOrder, int gradeId, int year = 0, int semester = 1, int? pageIndex = 1)
        {
            CurrentSort = sortOrder; 
            if (year == 0) selectedYear = DateTime.Now.Year;
            else selectedYear = year;
            selectedSemester = semester;
            selectedGrade = gradeId;
            gradeName = _context.Grades.Where(x => x.Id == gradeId).Select(x=>x.FullName).SingleOrDefault();

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

            //Generate data for academic performance table by grade
            //Генерація даних для таблиці успішності по класам
            var subjectsIQ = _context.Gradebooks
                .Include(s => s.Student)
                .Include(s => s.Subject)
                .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Student.GradeId == gradeId && s.Mark != "0")
                .GroupBy(s => s.Subject.Name)
                .Select(g => new StatGradeDetails
                {
                    Name = g.Key,
                    Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)),1)
                });

            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            MarkSort = sortOrder == "mark" ? "mark_desc" : "mark";

            //Sort order
            //Сортування
            switch (sortOrder)
            {
                case "name_desc":
                    subjectsIQ = subjectsIQ.OrderByDescending(s => s.Name);
                    break;
                case "mark":
                    subjectsIQ = subjectsIQ.OrderBy(s => s.Avg);
                    break;
                case "mark_desc":
                    subjectsIQ = subjectsIQ.OrderByDescending(s => s.Avg);
                    break;
                default:
                    subjectsIQ = subjectsIQ.OrderBy(s => s.Name);
                    break;
            }

            var pageSize = Configuration.GetValue("PageSize", 7);
            subjects = await PaginatedList<StatGradeDetails>.CreateAsync(
                subjectsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

            return Page();
        }

        //Generate data for subject average marks in a grade
        //Генерація даних для діаграми рейтингу предменів по класу
        public JsonResult OnPostData(int year, int semester, int gradeId)
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

            var subjects = _context.Gradebooks
                            .Include(s => s.Student)
                            .Include(s => s.Subject)
                            .Where(s => s.LessonDate >= startDate && s.LessonDate <= endDate && s.Student.GradeId == gradeId && s.Mark != "0")
                            .GroupBy(s => s.Subject.Name)
                            .Select(g => new StatGradeDetails
                            {
                                Name = g.Key,
                                Avg = Math.Round(g.Average(s => Convert.ToInt32(s.Mark)), 1)
                            })
                            .OrderBy(s => s.Name)
                            .AsNoTracking();

            return new JsonResult(subjects);
        }
    }

    public class StatGradeDetails
    {
        public string Name { get; set; }
        public double Avg { get; set; }
    }
}

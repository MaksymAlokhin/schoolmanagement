using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Data;
using sms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    public class Gene
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        Random random;
        public List<Curriculum> geneCurricula;
        public List<Lesson> geneLessons;
        public Grade geneGrade;

        public Gene(ApplicationDbContext context, ILogger<IndexModel> logger, int grade)
        {
            _context = context;
            _logger = logger;
            random = new Random();
            geneLessons = new List<Lesson>();
            geneGrade = _context.Grades.Find(grade);
            geneCurricula = _context.Curricula.Where(c => c.GradeId == grade).AsNoTracking().ToList();
            //Shuffle(geneCurricula);
            for (int slot = 1; slot <= 8; slot++)
            {
                for (int day = 1; day <= 5; day++)
                {
                    if (geneCurricula.Count == 0)
                        break;
                    int index = random.Next(geneCurricula.Count);
                    geneLessons.Add(
                            new Lesson
                            {
                                Day = ((Day)day).ToString(),
                                Slot = slot,
                                Room = geneGrade.Room == null ? "" : geneGrade.Room,
                                GradeId = grade,
                                SubjectId = geneCurricula[index].SubjectId,
                                TeacherId = geneCurricula[index].TeacherId
                            });
                    if (--geneCurricula[index].Quantity == 0)
                        geneCurricula.Remove(geneCurricula[index]);
                }
            }
        }
    }
}

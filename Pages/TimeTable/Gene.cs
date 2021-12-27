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
        //private readonly sms.Data.ApplicationDbContext _context;
        Random random;
        public List<Curriculum> geneCurricula;
        public List<Lesson> geneLessons;
        public Grade geneGrade;
        List<Curriculum> _cachedCurricula;
        List<Grade> _cachedGrades;


        public Gene(int grade, List<Curriculum> cachedCurricula, List<Grade> cachedGrades)
        {
            _cachedCurricula = cachedCurricula;
            _cachedGrades = cachedGrades;
            random = new Random();
            geneLessons = new List<Lesson>();
            geneGrade = _cachedGrades.Where(g => g.Id == grade).FirstOrDefault();
            geneCurricula = _cachedCurricula.Where(c => c.GradeId == grade).ToList();
            List<int> curriculaCounter = new List<int>();
            foreach (Curriculum curriculum in geneCurricula)
            {
                curriculaCounter.Add(curriculum.Quantity);
            }

            for (int slot = 1; slot < 9; slot++)
            {
                for (int day = 1; day < 6; day++)
                {
                    if (geneCurricula.Count == 0)
                        break;

                    int index = random.Next(geneCurricula.Count);
                    geneLessons.Add(
                            new Lesson
                            {
                                Day = day,
                                Slot = slot,
                                Room = geneGrade.Room == null ? "" : geneGrade.Room,
                                GradeId = grade,
                                SubjectId = geneCurricula[index].SubjectId,
                                TeacherId = geneCurricula[index].TeacherId
                            });
                    if (--curriculaCounter[index] == 0)
                    {
                        geneCurricula.Remove(geneCurricula[index]);
                        curriculaCounter.RemoveAt(index);
                    }
                }
            }
        }
        public Gene()
        {
            geneLessons = new List<Lesson>();
        }
    }
}

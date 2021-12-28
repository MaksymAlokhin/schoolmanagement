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
    //gene represents permutation of slots as timetable for a single student group(looks like {5,22,14,1,...} )
    //Ген представляє собою перестановку слотів розкладу для одного класу має вигляд {5,22,14,1,...}
    public class Gene
    {
        public int[] slotno;

        //Random random;

        public Gene(int i, List<Curriculum> cachedCurricula, List<Grade> cachedGrades, Random random)
        {
            //random = new Random();
            /*  generating an array of slot no corresponding to index of gene eg suppose index
             	is 2 then slotno will vary from 2*hours*days to 3*hours*days
                Генерація масиву слотів відповідно до індексу гену
                Наприклад, якщо індекс 2, то номери слотів будуть коливатись
                між 2*уроків*днів до 3*уроків*днів
             */
            slotno = new int[Table.totalGradeSlots[i]];
            int slotsStart = i * Table.totalSlots;
            for (int j = 0; j < Table.totalGradeSlots[i]; j++)
            {
                slotno[j] = slotsStart + j;
            }
            random.Shuffle(slotno);
        }
    }
}
























//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using sms.Data;
//using sms.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace sms.Pages.TimeTable
//{
//    public class Gene
//    {
//        //private readonly sms.Data.ApplicationDbContext _context;
//        Random random;
//        public List<Curriculum> geneCurricula;
//        public List<Lesson> geneLessons;
//        public Grade geneGrade;
//        List<Curriculum> _cachedCurricula;
//        List<Grade> _cachedGrades;


//        public Gene(int grade, List<Curriculum> cachedCurricula, List<Grade> cachedGrades)
//        {
//            _cachedCurricula = cachedCurricula;
//            _cachedGrades = cachedGrades;
//            random = new Random();
//            geneLessons = new List<Lesson>();
//            geneGrade = _cachedGrades.Where(g => g.Id == grade).FirstOrDefault();
//            geneCurricula = _cachedCurricula.Where(c => c.GradeId == grade).ToList();
//            List<int> curriculaCounter = new List<int>();
//            foreach (Curriculum curriculum in geneCurricula)
//            {
//                curriculaCounter.Add(curriculum.Quantity);
//            }

//            for (int slot = 1; slot < 9; slot++)
//            {
//                for (int day = 1; day < 6; day++)
//                {
//                    if (geneCurricula.Count == 0)
//                        break;

//                    int index = random.Next(geneCurricula.Count);
//                    geneLessons.Add(
//                            new Lesson
//                            {
//                                Day = day,
//                                Slot = slot,
//                                Room = geneGrade.Room == null ? "" : geneGrade.Room,
//                                GradeId = grade,
//                                SubjectId = geneCurricula[index].SubjectId,
//                                TeacherId = geneCurricula[index].TeacherId
//                            });
//                    if (--curriculaCounter[index] == 0)
//                    {
//                        geneCurricula.Remove(geneCurricula[index]);
//                        curriculaCounter.RemoveAt(index);
//                    }
//                }
//            }
//        }
//        public Gene()
//        {
//            geneLessons = new List<Lesson>();
//        }
//    }
//}

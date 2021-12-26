using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Models;
using sms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    public class Chromosome : IComparable
    {
        private readonly sms.Data.ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public static double crossoverrate = 1.0;
        public static double mutationrate = 0.1;
        public double fitness;
        int antiScore;
        public List<Gene> genes;
        public List<Lesson> lessons;

        public Chromosome(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            genes = new List<Gene>();
            lessons = new List<Lesson>();
            foreach (int i in _context.Grades.Select(g => g.Id))
            {
                genes.Add(new Gene(context, logger, i));
            }
            foreach (Gene gene in genes)
            {
                lessons.AddRange(gene.geneLessons);
            }
            fitness = GetFitness();
            //lessons.Clear();
        }
        public int CompareTo(object obj)
        {
            Chromosome Temp = (Chromosome)obj;
            if (fitness < Temp.fitness)
                return 1;
            if (fitness > Temp.fitness)
                return -1;
            else
                return 0;
        }
        public double GetFitness()
        {
            antiScore = 0;
            //Find teacher clashes
            //Знаходження співпадіння вчителів
            antiScore += lessons.GroupBy(g => new { g.Day, g.Slot, g.TeacherId })
                .Where(g => g.Count() > 1)
                .Select(g => g.Count() - 1).Sum(g => g);
            //Find grade clashes
            //Знаходження співпадіння класів
            antiScore += lessons.GroupBy(g => new { g.Day, g.Slot, g.GradeId })
                .Where(g => g.Count() > 1)
                .Select(g => g.Count() - 1).Sum(g => g);
            //Find gaps in timetable
            //Знаходження "вікон" у розкладі класів
            foreach (int grade in _context.Grades.Select(g => g.Id))
            {
                for (int day = 1; day <= 5; day++)
                {
                    for (int slot = 8; slot > 1; slot--)
                    {
                        if (lessons.Any(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot
                                && l.GradeId == grade))
                        {
                            for (int i = slot - 1; i > 0; i--)
                            {
                                if (!lessons.Any(l => l.Day == ((Day)day).ToString()
                                                      && l.Slot == slot
                                                      && l.GradeId == grade))
                                {
                                    antiScore++;
                                }
                            }
                            break;
                        }
                    }
                }
            }
            //Find teacher gaps
            //Знаходження вікон у розкладі вчителів
            foreach (int teacher in _context.Teachers.Select(g => g.Id))
            {
                for (int day = 1; day <= 5; day++)
                {
                    //Find first lesson on a given day
                    //Знаходження першого уроку вчителя у певний день
                    int firstLesson = 0;
                    for (int slot = 1; slot <= 8; slot++)
                    {
                        if (lessons.Any(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot
                                && l.TeacherId == teacher))
                        {
                            firstLesson = slot;
                            break;
                        }
                    }
                    //Find last lesson on a given day
                    //Знаходження останнього уроку вчителя у певний день
                    int lastLesson = 0;
                    for (int slot = 8; slot > 1; slot--)
                    {
                        if (lessons.Any(l => l.Day == ((Day)day).ToString()
                                && l.Slot == slot
                                && l.TeacherId == teacher))
                        {
                            lastLesson = slot;
                            break;
                        }
                    }
                    for (int slot = firstLesson + 1; slot < lastLesson; slot++)
                    {
                        if (!lessons.Any(l => l.Day == ((Day)day).ToString()
                                              && l.Slot == slot
                                              && l.TeacherId == teacher))
                        {
                            antiScore++;
                        }
                    }
                }
            }
            return 1 - (antiScore / _context.Curricula.Sum(c => c.Quantity));
        }
    }
}
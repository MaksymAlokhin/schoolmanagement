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
    public class Scheduler
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<Chromosome> firstlist;
        List<Chromosome> newlist;
        double firstlistfitness;
        double newlistfitness;
        int populationsize = 1000;
        int maxgenerations = 100;
        public static Chromosome finalson;
        Random random;

        public Scheduler(ApplicationDbContext context,
                          ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
            random = new Random();

            //initialising first generation of chromosomes and puting in first list
            //Ініціалізація першого покоління
            InitializePopulation();

            //generating newer generation of chromosomes using crossovers and mutation
            //Генерація нового покоління
            CreateNewGenerations();
        }
        //initialising first generation of population
        //Ініціалізація першого покоління
        public void InitializePopulation()
        {
            //_logger.LogInformation("Initializing population");
            firstlist = new List<Chromosome>();
            firstlistfitness = 0;

            for (int i = 0; i < populationsize; i++)
            {
                _logger.LogInformation($"Initializing population {i}");
                Chromosome c;
                firstlist.Add(c = new Chromosome(_context, _logger));
                firstlistfitness += c.fitness;
            }
            //firstlist = firstlist.OrderByDescending(l => l.fitness).ToList();
            firstlist.Sort();
        }
        public void CreateNewGenerations()
        {
            _logger.LogInformation("Creating new generations");
            Chromosome father = null;
            Chromosome mother = null;
            Chromosome son = null;

            int nogenerations = 0;

            //looping max no of generations times or until suitable chromosome found
            //Підбір хромосоми
            while (nogenerations < maxgenerations)
            {

                newlist = new List<Chromosome>();
                newlistfitness = 0;
                int i;

                //first 1/10 chromosomes added as it is- Elitism
                //Відбір найкращих 1/10 хромосом
                for (i = 0; i < populationsize / 10; i++)
                {
                    newlist.Add(firstlist[i]);
                    newlistfitness += firstlist[i].GetFitness();
                }

                //adding other members after performing crossover and mutation
                //Додавання населення
                while (i < populationsize)
                {

                    father = SelectParentRoulette();
                    mother = SelectParentRoulette();

                    //crossover
                    //Схрещування
                    if (random.NextDouble() < Chromosome.crossoverrate)
                    {
                        son = Crossover(father, mother);
                    }
                    else
                        son = father;

                    //mutation
                    //Мутація
                    //int mutationType = random.Next(1, 4);
                    //switch (mutationType)
                    //{
                    //    case 1: СustomMutation(son);
                    //        break;
                    //    case 2: SimpleMutation(son);
                    //        break;
                    //    case 3: SwapMutation(son);
                    //        break;
                    //}
                    СustomMutation(son);


                    if (son.fitness == 1)
                        break;

                    newlist.Add(son);
                    newlistfitness += son.GetFitness();
                    i++;
                }

                //if chromosome with fitness 1 found
                //Якщо знайшли бездоганну хромосому
                if (i < populationsize)
                {
                    _logger.LogInformation($"Suitable Timetable has been generated in the {i}th Chromosome " +
                        $"of {nogenerations + 2} generation with fitness of 1.");
                    finalson = son;
                    break;
                }

                //if chromosome with required fitness not found in this generation
                //Якщо бездоганну хромосому не знайшли
                firstlist = newlist;
                newlist.Sort();
                firstlist.Sort();
                _logger.LogInformation($"Generation {nogenerations + 2}");
                nogenerations++;
            }
        }
        //selecting using Roulette Wheel Selection only from the best 10% chromosomes
        //Вибір випадковим чином з 10% найкращих хромосом
        public Chromosome SelectParentRoulette()
        {
            var bestParents = firstlist.Take((int)Math.Ceiling(firstlist.Count() * 10 / 100d)).ToList();
            return bestParents[random.Next(bestParents.Count())];
        }

        //Two point crossover
        //Схрещування двох хромосом
        public Chromosome Crossover(Chromosome father, Chromosome mother)
        {
            _logger.LogInformation("Doing crossover");
            int randomint = random.Next(_context.Grades.Count());
            Gene temp = father.genes[randomint];
            father.genes[randomint] = mother.genes[randomint];
            mother.genes[randomint] = temp;
            if (father.GetFitness() > mother.GetFitness()) return father;
            else return mother;
        }
        //custom mutation
        //Мутація
        public void СustomMutation(Chromosome c)
        {
            _logger.LogInformation("Doing mutation");
            double newfitness = 0, oldfitness = c.GetFitness();
            int geneno = random.Next(_context.Grades.Count());

            int i = 0;
            while (newfitness < oldfitness)
            {

                c.genes[geneno] = new Gene(_context, _logger, geneno);
                newfitness = c.GetFitness();

                i++;
                if (i >= 500000) break;
            }
        }   
        //simple Mutation operation
        //Проста мутація
        public void SimpleMutation(Chromosome c)
        {
            int geneno = random.Next(_context.Grades.Count());
            for (int day = 1; day <= 5; day++)
            {
                Lesson first = c.genes[geneno].geneLessons
                        .Where(l => l.Day == day && l.Slot == 1)
                        .FirstOrDefault();
                Lesson last;
                for (int slot = 1; slot < 8; slot++)
                {
                    Lesson previous = c.genes[geneno].geneLessons
                        .Where(l => l.Day == day && l.Slot == slot)
                        .FirstOrDefault();
                    Lesson next = c.genes[geneno].geneLessons
                        .Where(l => l.Day == day && l.Slot == slot + 1)
                        .FirstOrDefault();

                    if (previous != null && next != null)
                    {
                        previous = next;
                        last = next;
                    }
                }
                last = first;
            }
        }

        //swap mutation
        //Мутація перестановкою
        public void SwapMutation(Chromosome c)
        {
            int geneno = random.Next(_context.Grades.Count());
            int day1;
            int slotno1;
            int day2;
            int slotno2;
            Lesson lessonOne, LessonTwo;

            do
            {
                do
                {
                    day1 = random.Next(1, 6);
                    slotno1 = random.Next(1, 9);
                } while (!c.genes[geneno].geneLessons.Any(l => l.Day == day1 && l.Slot == slotno1));
                
                do
                {
                    day2 = random.Next(1, 6);
                    slotno2 = random.Next(1, 9);
                } while (!c.genes[geneno].geneLessons.Any(l => l.Day == day2 && l.Slot == slotno2));

                lessonOne = c.genes[geneno].geneLessons
                    .Where(l => l.Day == day1 && l.Slot == slotno1)
                    .FirstOrDefault();
                LessonTwo = c.genes[geneno].geneLessons
                    .Where(l => l.Day == day2 && l.Slot == slotno2)
                    .FirstOrDefault();

            } while (lessonOne == LessonTwo);

            Lesson temp = lessonOne;
            lessonOne = LessonTwo;
            LessonTwo = temp;
        }
    }
}

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
        public List<Curriculum> cachedCurricula;
        public List<Grade> cachedGrades;
        public List<Teacher> cachedTeachers;
        public List<int> allGradeIds;
        public double totalNumberOfLessons;
        public double mutationrate = 0.01;

        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<Chromosome> firstlist;
        List<Chromosome> newlist;
        public Chromosome finalson;

        double firstlistfitness;
        double newlistfitness;
        int populationsize = 2000;
        int maxgenerations = 100;
        Random random;
        int numberOfGrades;

        public Scheduler(ApplicationDbContext context,
                          ILogger<IndexModel> logger)
        {
            _context = context;
            cachedCurricula = _context.Curricula.AsNoTracking().ToList();
            totalNumberOfLessons = cachedCurricula.Sum(c => c.Quantity);
            cachedGrades = _context.Grades.AsNoTracking().ToList();
            numberOfGrades = cachedGrades.Count();
            allGradeIds = cachedGrades.Select(g => g.Id).ToList();
            cachedTeachers = _context.Teachers.AsNoTracking().ToList();
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
            firstlist = new List<Chromosome>();
            firstlistfitness = 0;

            for (int i = 0; i < populationsize; i++)
            {
                Chromosome c;
                firstlist.Add(c = new Chromosome(allGradeIds, totalNumberOfLessons, 
                    cachedCurricula, cachedGrades, _logger));
                firstlistfitness += c.fitness;
                _logger.LogInformation($"Initializing population {i, 4}, Fitness: {c.fitness, 7:N5}");
            }
            firstlist.Sort();
        }
        public void CreateNewGenerations()
        {
            Chromosome son = null;

            int nogenerations = 0;

            //looping max no of generations times or until suitable chromosome found
            //Підбір хромосоми
            while (nogenerations < maxgenerations)
            {
                _logger.LogInformation($"Generation {nogenerations + 2,4}");
                newlist = new List<Chromosome>();
                newlistfitness = 0;
                int i;

                //first 1/10 chromosomes added as it is- Elitism
                //Відбір найкращих 1/10 хромосом
                for (i = 0; i < populationsize / 10; i++)
                {
                    newlist.Add(firstlist[i]);
                    newlistfitness += firstlist[i].fitness;
                }

                //adding other members after performing crossover and mutation
                //Додавання населення
                while (i < populationsize)
                {
                    //_logger.LogInformation($"Generation {nogenerations + 2,4}, Population size {i,4}");

                    //crossover
                    //Схрещування
                    son = Crossover(SelectBestParentsRoulette());

                    //mutation
                    //Мутація
                    if (random.NextDouble() < mutationrate)
                    {
                        //int mutationType = random.Next(1, 3);
                        //switch (mutationType)
                        //{
                        //    case 1:
                        //        OneGeneMutation(son);
                        //        _logger.LogInformation($"Doing OneGeneMutation");
                        //        break;
                        //    case 2:
                        //        ShiftMutation(son);
                        //        _logger.LogInformation($"Doing ShiftMutation");
                        //        break;
                        //}
                        OneGeneMutation(son);
                    }

                    //OneGeneMutation(son);
                    //SimpleMutation(son);



                    if (son.fitness == 1)
                        break;

                    newlist.Add(son);
                    newlistfitness += son.fitness;
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
                _logger.LogInformation($"******************Firstlist Fitness: {firstlistfitness,7:N5}");

                firstlist = newlist;
                firstlistfitness = newlistfitness;
                firstlist.Sort();
                finalson = firstlist[0];

                _logger.LogInformation($"******************Newlist   Fitness: {newlistfitness,7:N5}");

                _logger.LogInformation($"Finalson Fitness: {finalson.fitness,7:N5}");

                nogenerations++;
            }
        }
        //selecting using Roulette Wheel Selection only from the best 50% chromosomes
        //Вибір випадковим чином з найкращих 50% хромосом
        public Chromosome[] SelectBestParentsRoulette()
        {
            List<Chromosome> bestParents = new List<Chromosome>();

            int rnd = random.Next(1, 101);
            
            if (rnd > 95 && rnd < 101) // 5% chance to take worst 30%
            {
                for (int i = (int)(populationsize * 0.7) + 1; i < populationsize; i++)
                    bestParents.Add(firstlist[i]);
            }
            if (rnd > 75 && rnd < 96) // 20% chance to take middle from 50% to 70%
            {
                for (int i = (int)(populationsize * 0.5) + 1; i < (int)(populationsize * 0.7); i++)
                    bestParents.Add(firstlist[i]);
            }
            if (rnd > 0 && rnd < 76) // 75% chance to take the best 50% (first 10% already taken as is)
            {
                for (int i = (int)(populationsize * 0.1) + 1; i < (int)(populationsize * 0.5); i++)
                    bestParents.Add(firstlist[i]);
            }
            //var bestParents = firstlist.Take((int)Math.Ceiling(firstlist.Count() * 10 / 100d)).ToList();
            Chromosome parent1;
            Chromosome parent2;
            do
            {
                parent1 = bestParents[random.Next(bestParents.Count())];
                parent2 = bestParents[random.Next(bestParents.Count())];
            } while (parent1.jsonString == parent2.jsonString);
            return new Chromosome[] { parent1, parent2 };
        }

        //Two point crossover
        //Схрещування двох хромосом
        public Chromosome Crossover(Chromosome[] parents)
        {
            _logger.LogInformation($"Father Fitness: {parents[0].fitness,7:N5}");
            _logger.LogInformation($"Mother Fitness: {parents[1].fitness,7:N5}");
            if (parents[0].jsonString == parents[1].jsonString)
                _logger.LogInformation($"Father and mother are the same");
            Chromosome child = new Chromosome(allGradeIds, totalNumberOfLessons, cachedCurricula, cachedGrades, _logger);
            int crossoverPoint = random.Next((int)(numberOfGrades * 0.3), (int)(numberOfGrades * 0.7));
            _logger.LogInformation($"Crossover Point: {crossoverPoint, 6}");

            for (int i = 0; i < crossoverPoint; i++)
            {
                child.genes[i] = parents[0].genes[i];
            }
            for (int i = crossoverPoint; i < numberOfGrades; i ++)
            {
                child.genes[i] = parents[1].genes[i];
            }
            child.GetFitness();
            child.GetJsonString();
            _logger.LogInformation($"Son Fitness: {child.fitness,10:N5}");

            return child;

            //int randomint = random.Next(numberOfGrades);
            //Gene temp = father.genes[randomint];
            //father.genes[randomint] = mother.genes[randomint];
            //mother.genes[randomint] = temp;
            //double fatherFitness = father.GetFitness();
            //double motherFitness = mother.GetFitness();
            //_logger.LogInformation($"Father fitness: {fatherFitness,7:N5}");
            //_logger.LogInformation($"Mother fitness: {motherFitness,7:N5}");

            //if (fatherFitness > motherFitness)
            //    return father;
            //else
            //    return mother;
        }
        //One Gene mutation
        //Мутація одного гену
        public void OneGeneMutation(Chromosome c)
        {
            _logger.LogInformation($"Fitness before mutation: {c.fitness,7:N5}");

            int geneno = random.Next(numberOfGrades);
            c.genes[geneno] = new Gene(_logger, allGradeIds[geneno], cachedCurricula, cachedGrades);
            c.GetFitness();
            c.GetJsonString();
            _logger.LogInformation($"Fitness after  mutation: {c.fitness,7:N5}");

            //double newfitness = 0, oldfitness = c.GetFitness();
            //_logger.LogInformation($"Old fitness: {oldfitness,7:N5}");

            //int i = 0;
            //int geneno;

            //while (newfitness < oldfitness)
            //{
            //    geneno = random.Next(numberOfGrades);

            //    c.genes[geneno] = new Gene(_logger, allGradeIds[geneno], cachedCurricula, cachedGrades);
            //    newfitness = c.GetFitness();

            //    i++;
            //    if (i >= 50) break;
            //}
            //_logger.LogInformation($"New fitness: {newfitness,7:N5}, i: {i,6}");

        }
        //Shift Mutation operation
        //Мутація зсувом угору
        public void ShiftMutation(Chromosome c)
        {
            int geneno = random.Next(numberOfGrades);
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
            c.GetFitness();
            c.GetJsonString();
        }

        //swap mutation
        //Мутація перестановкою
        public void SwapMutation(Chromosome c)
        {
            int day1;
            int slotno1;
            int day2;
            int slotno2;
            int geneno;
            Lesson lessonOne, lessonTwo;
            geneno = random.Next(numberOfGrades);

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
                lessonTwo = c.genes[geneno].geneLessons
                    .Where(l => l.Day == day2 && l.Slot == slotno2)
                    .FirstOrDefault();

            } while (lessonOne == lessonTwo);

            Lesson temp = lessonOne;
            lessonOne = lessonTwo;
            lessonTwo = temp;
            c.GetFitness();
            c.GetJsonString();
        }
    }
}

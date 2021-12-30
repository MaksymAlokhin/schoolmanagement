using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Data;
using sms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace sms.Pages.TimeTable
{
    //Genetic algorithm scheluder
    //Генератор розкладу за генетичним алгоритмом
    public class Scheduler
    {
        public List<Curriculum> cachedCurricula;
        public List<Grade> cachedGrades;
        public List<Teacher> cachedTeachers;
        public List<int> allGradeIds;
        public double totalNumberOfLessons;

        int maxgenerations;
        int populationsize;
        double mutationrate;
        double crossoverrate;

        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<Chromosome> firstlist;
        List<Chromosome> newlist;
        public Chromosome finalson;

        double firstlistfitness;
        double newlistfitness;
        Random random;
        int numberOfGrades;
        int crossoverPoint;
        public Scheduler(ApplicationDbContext context,
                          ILogger<IndexModel> logger)
        {
            string[] settings = File.ReadAllLines(@"GeneticSettings.txt");
            if (!int.TryParse(settings[1], out maxgenerations))
                maxgenerations = 1000;
            if (!int.TryParse(settings[3], out populationsize))
                populationsize = 100;
            if (!double.TryParse(settings[5], out mutationrate))
                mutationrate = 0.01;
            if (!double.TryParse(settings[7], out crossoverrate))
                crossoverrate = 0.9;

            if (maxgenerations < 1) maxgenerations = 1000;
            if (populationsize < 10) populationsize = 100;
            if (mutationrate > 1.0 || mutationrate < 0.0) mutationrate = 0.01;
            if (crossoverrate > 1.0 || crossoverrate < 0.0) crossoverrate = 0.9;

            _context = context;
            cachedCurricula = _context.Curricula.AsNoTracking().ToList();
            totalNumberOfLessons = cachedCurricula.Sum(c => c.Quantity);
            cachedGrades = _context.Grades.AsNoTracking().ToList();
            numberOfGrades = cachedGrades.Count();
            crossoverPoint = numberOfGrades / 2;
            allGradeIds = cachedGrades.Select(g => g.Id).ToList();
            cachedTeachers = _context.Teachers.AsNoTracking().ToList();

            _logger = logger;
            random = new Random();
            //Generating slots
            //Генерація слотів
            new Table(allGradeIds, cachedCurricula, cachedGrades, numberOfGrades);

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
                    cachedCurricula, cachedGrades, random, numberOfGrades));
                firstlistfitness += c.fitness;
            }
            firstlist.Sort();
        }
        public void CreateNewGenerations()
        {
            Chromosome son = null;
            Chromosome mother = null;
            Chromosome father = null;

            int nogenerations = 0;

            //looping max no of generations times or until suitable chromosome found
            //Підбір хромосоми
            while (nogenerations < maxgenerations)
            {
                newlist = new List<Chromosome>();
                newlistfitness = 0;
                int i = 0;

                for (i = 0; i < populationsize / 10; i++)
                {
                    newlist.Add(firstlist[i]);
                    newlistfitness += firstlist[i].fitness;
                }

                //adding other members after performing crossover and mutation
                //Додавання населення
                while (i < populationsize)
                {

                    //crossover
                    //Схрещування
                    mother = SelectBestParentRoulette();
                    father = SelectBestParentRoulette();
                    //mother = TournamentSelection();
                    //father = TournamentSelection();

                    if (random.NextDouble() < crossoverrate)
                        son = Crossover(mother, father);
                    else
                        son = Clone(father);

                    if (random.NextDouble() < mutationrate)
                        UniformMutation(son);
                    
                    son.FindConflicts();
                    son.GetFitness();
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

                firstlist = newlist;
                firstlistfitness = newlistfitness;
                firstlist.Sort();
                finalson = firstlist[0];

                _logger.LogInformation($"Generation: {nogenerations + 2,6} Fitness: {firstlistfitness,7:N5} Finalson: {finalson.fitness,7:N5}");

                nogenerations++;
            }
        }
        //selecting using Roulette Wheel Selection only from the best chromosomes
        //Вибір випадковим чином з найкращих хромосом
        public Chromosome SelectBestParentRoulette()
        {
            //List<Chromosome> bestParents = new List<Chromosome>();
            Chromosome parent = null;
            int rnd = random.Next(1, 101);
            if (rnd > 90 && rnd < 101) // 10% chance to take worst 60%+
            {
                parent = firstlist[random.Next((int)(populationsize * 0.6), populationsize)];
            }
            if (rnd > 70 && rnd < 91) // 20% chance to take middle 30-60%
            {
                parent = firstlist[random.Next((int)(populationsize * 0.3), (int)(populationsize * 0.6))];
            }
            if (rnd > 0 && rnd < 71) // 70% chance to take the best 30%
            {
                parent = firstlist[random.Next(0, (int)(populationsize * 0.3))];
            }
            return parent;
        }
        //Choose the best out of random 3
        //Вибір найкращого серед випадкових 3
        public Chromosome TournamentSelection()
        {
            int poolSize = 5;
            Chromosome[] pool = new Chromosome[poolSize];
            for (int i = 0; i < poolSize; i++)
            {
                pool[i] = firstlist[random.Next(populationsize)];
            }
            Array.Sort(pool);
            return pool[0];
        }
        //Two point crossover
        //Схрещування двох хромосом
        public Chromosome Crossover(Chromosome mother, Chromosome father)
        {
            Chromosome child = new Chromosome(totalNumberOfLessons, random, numberOfGrades);
            crossoverPoint = random.Next((int)(numberOfGrades * 0.3), (int)(numberOfGrades * 0.7));
            for (int i = 0; i < crossoverPoint; i++)
            {
                child.genes[i] = mother.genes[i];
            }
            for (int i = crossoverPoint; i < numberOfGrades; i++)
            {
                child.genes[i] = father.genes[i];
            }
            return child;
        }
        public Chromosome Clone(Chromosome father)
        {
            Chromosome child = new Chromosome(totalNumberOfLessons, random, numberOfGrades);
            for (int i = 0; i < numberOfGrades; i++)
            {
                child.genes[i] = father.genes[i];
            }
            return child;
        }

        //Uniform mutation
        //Безперервна мутація одного гену
        public void UniformMutation(Chromosome c)
        {
            int geneno = random.Next(numberOfGrades);
            c.genes[geneno] = new Gene(geneno, cachedCurricula, cachedGrades, random);
        }

        public void SwapMutation(Chromosome c)
        {
            int grade = random.Next(numberOfGrades);
            int slot1, slot2;
            do
            {
                slot1 = random.Next(Table.totalGradeSlots[grade]);
                slot2 = random.Next(Table.totalGradeSlots[grade]);
            } while (slot1 == slot2);
            int temp = c.genes[grade].slotno[slot1];
            c.genes[grade].slotno[slot1] = c.genes[grade].slotno[slot2];
            c.genes[grade].slotno[slot2] = temp;
        }
    }
}



































//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using sms.Data;
//using sms.Models;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace sms.Pages.TimeTable
//{
//    public class Scheduler
//    {
//        public List<Curriculum> cachedCurricula;
//        public List<Grade> cachedGrades;
//        public List<Teacher> cachedTeachers;
//        public List<int> allGradeIds;
//        public double totalNumberOfLessons;

//        int maxgenerations;
//        int populationsize;
//        double mutationrate;

//        private readonly ApplicationDbContext _context;
//        private readonly ILogger<IndexModel> _logger;
//        List<Chromosome> firstlist;
//        List<Chromosome> newlist;
//        public Chromosome finalson;

//        double firstlistfitness;
//        double newlistfitness;
//        Random random;
//        int numberOfGrades;

//        public Scheduler(ApplicationDbContext context,
//                          ILogger<IndexModel> logger)
//        {
//            _context = context;
//            cachedCurricula = _context.Curricula.AsNoTracking().ToList();
//            totalNumberOfLessons = cachedCurricula.Sum(c => c.Quantity);
//            cachedGrades = _context.Grades.AsNoTracking().ToList();
//            numberOfGrades = cachedGrades.Count();
//            allGradeIds = cachedGrades.Select(g => g.Id).ToList();
//            cachedTeachers = _context.Teachers.AsNoTracking().ToList();
//            _logger = logger;
//            random = new Random();
//            string[] settings = File.ReadAllLines(@"GeneticSettings.txt");
//            maxgenerations = int.Parse(settings[0]);
//            populationsize = int.Parse(settings[1]);
//            mutationrate = double.Parse(settings[2]);

//            //Generating slots
//            //Генерація слотів
//            new Table(allGradeIds, cachedCurricula);

//            //initialising first generation of chromosomes and puting in first list
//            //Ініціалізація першого покоління
//            InitializePopulation();

//            //generating newer generation of chromosomes using crossovers and mutation
//            //Генерація нового покоління
//            CreateNewGenerations();
//        }
//        //initialising first generation of population
//        //Ініціалізація першого покоління
//        public void InitializePopulation()
//        {
//            firstlist = new List<Chromosome>();
//            firstlistfitness = 0;

//            for (int i = 0; i < populationsize; i++)
//            {
//                Chromosome c;
//                firstlist.Add(c = new Chromosome(allGradeIds, totalNumberOfLessons,
//                    cachedCurricula, cachedGrades));
//                firstlistfitness += c.fitness;
//                //_logger.LogInformation($"Initializing population {i, 4}, Fitness: {c.fitness, 7:N5}");
//            }
//            firstlist.Sort();
//        }
//        public void CreateNewGenerations()
//        {
//            Chromosome son = null;

//            int nogenerations = 0;

//            //looping max no of generations times or until suitable chromosome found
//            //Підбір хромосоми
//            while (nogenerations < maxgenerations)
//            {
//                //_logger.LogInformation($"Generation {nogenerations + 2,4}");
//                newlist = new List<Chromosome>();
//                newlistfitness = 0;
//                int i = 0;

//                //first 1 / 10 chromosomes added as it is -Elitism
//                //Відбір найкращих 1 / 10 хромосом
//                for (i = 0; i < populationsize / 10; i++)
//                {
//                    newlist.Add(firstlist[i]);
//                    newlistfitness += firstlist[i].fitness;
//                }

//                //adding other members after performing crossover and mutation
//                //Додавання населення
//                while (i < populationsize)
//                {
//                    //_logger.LogInformation($"                        Generation {nogenerations + 2,4}, Population size {i,4}");

//                    //crossover
//                    //Схрещування
//                    son = Crossover(SelectBestParentsRoulette());

//                    //mutation
//                    //Мутація
//                    if (random.NextDouble() < mutationrate)
//                    {
//                        //int mutationType = random.Next(1, 3);
//                        //switch (mutationType)
//                        //{
//                        //    case 1:
//                        //        OneGeneMutation(son);
//                        //        _logger.LogInformation($"Doing OneGeneMutation");
//                        //        break;
//                        //    case 2:
//                        //        ShiftMutation(son);
//                        //        _logger.LogInformation($"Doing ShiftMutation");
//                        //        break;
//                        //}
//                        OneGeneMutation(son);
//                    }

//                    //OneGeneMutation(son);
//                    //SimpleMutation(son);



//                    if (son.fitness == 1)
//                        break;

//                    newlist.Add(son);
//                    newlistfitness += son.fitness;
//                    i++;
//                }

//                //if chromosome with fitness 1 found
//                //Якщо знайшли бездоганну хромосому
//                if (i < populationsize)
//                {
//                    _logger.LogInformation($"Suitable Timetable has been generated in the {i}th Chromosome " +
//                        $"of {nogenerations + 2} generation with fitness of 1.");
//                    finalson = son;
//                    break;
//                }

//                //if chromosome with required fitness not found in this generation
//                //Якщо бездоганну хромосому не знайшли

//                firstlist = newlist;
//                firstlistfitness = newlistfitness;
//                firstlist.Sort();
//                finalson = firstlist[0];

//                _logger.LogInformation($"Generation: {nogenerations + 2,4} Fitness: {firstlistfitness,7:N0} Finalson: {finalson.fitness,7:N5}");

//                nogenerations++;
//            }
//        }
//        //selecting using Roulette Wheel Selection only from the best chromosomes
//        //Вибір випадковим чином з найкращих хромосом
//        public Chromosome[] SelectBestParentsRoulette()
//        {
//            List<Chromosome> bestParents = new List<Chromosome>();

//            int rnd = random.Next(1, 101);
//            if (rnd > 90 && rnd < 101) // 10% chance to take worst 60%+
//            {
//                for (int i = (int)(populationsize * 0.6) + 1; i < populationsize; i++)
//                    bestParents.Add(firstlist[i]);
//            }
//            if (rnd > 70 && rnd < 91) // 20% chance to take middle 30-60%
//            {
//                for (int i = (int)(populationsize * 0.3) + 1; i < (int)(populationsize * 0.6); i++)
//                    bestParents.Add(firstlist[i]);
//            }
//            if (rnd > 0 && rnd < 71) // 70% chance to take the best 30%
//            {
//                for (int i = 0; i < (int)(populationsize * 0.3); i++)
//                    bestParents.Add(firstlist[i]);
//            }

//            Chromosome parent1, parent2;
//            int rnd1, rnd2;
//            do
//            {
//                rnd1 = random.Next(bestParents.Count());
//                rnd2 = random.Next(bestParents.Count());
//            } while (rnd1 == rnd2);
//            parent1 = bestParents[random.Next(bestParents.Count())];
//            parent2 = bestParents[random.Next(bestParents.Count())];
//            return new Chromosome[] { parent1, parent2 };

//            //Chromosome parent1, parent2;
//            //int rnd1, rnd2;
//            //do
//            //{
//            //    rnd1 = random.Next((int)(populationsize * 0.1));
//            //    rnd2 = random.Next((int)(populationsize * 0.1));
//            //} while (rnd1 == rnd2);
//            //parent1 = firstlist[rnd1];
//            //parent2 = firstlist[rnd2];
//            //return new Chromosome[] { parent1, parent2 };
//        }

//        //Two point crossover
//        //Схрещування двох хромосом
//        public Chromosome Crossover(Chromosome[] parents)
//        {
//            Chromosome child = new Chromosome(totalNumberOfLessons);
//            int crossoverPoint = random.Next((int)(numberOfGrades * 0.3), (int)(numberOfGrades * 0.7));

//            for (int i = 0; i < crossoverPoint; i++)
//            {
//                child.genes[i] = parents[0].genes[i];
//            }
//            for (int i = crossoverPoint; i < numberOfGrades; i++)
//            {
//                child.genes[i] = parents[1].genes[i];
//            }
//            child.GetFitness();
//            return child;

//            //Chromosome father = parents[0];
//            //Chromosome mother = parents[1];
//            //int randomint = random.Next(numberOfGrades);
//            //Gene temp = father.genes[randomint];
//            //father.genes[randomint] = mother.genes[randomint];
//            //mother.genes[randomint] = temp;
//            //father.GetFitness();
//            //mother.GetFitness();

//            //if (father.fitness > mother.fitness)
//            //    return father;
//            //else
//            //    return mother;
//        }
//        //One Gene mutation
//        //Мутація одного гену
//        public void OneGeneMutation(Chromosome c)
//        {

//            int geneno = random.Next(numberOfGrades);
//            c.genes[geneno] = new Gene(allGradeIds[geneno], cachedCurricula, cachedGrades);
//            c.GetFitness();

//            //double newfitness = 0, oldfitness = c.GetFitness();

//            //int i = 0;
//            //int geneno;

//            //while (newfitness < oldfitness)
//            //{
//            //    geneno = random.Next(numberOfGrades);

//            //    c.genes[geneno] = new Gene(allGradeIds[geneno], cachedCurricula, cachedGrades);
//            //    newfitness = c.GetFitness();

//            //    i++;
//            //    if (i >= 500) break;
//            //}
//        }
//        //Shift Mutation operation
//        //Мутація зсувом угору
//        public void ShiftMutation(Chromosome c)
//        {
//            int geneno = random.Next(numberOfGrades);
//            for (int day = 1; day <= 5; day++)
//            {
//                Lesson first = c.genes[geneno].geneLessons
//                        .Where(l => l.Day == day && l.Slot == 1)
//                        .FirstOrDefault();
//                Lesson last;
//                for (int slot = 1; slot < 8; slot++)
//                {
//                    Lesson previous = c.genes[geneno].geneLessons
//                        .Where(l => l.Day == day && l.Slot == slot)
//                        .FirstOrDefault();
//                    Lesson next = c.genes[geneno].geneLessons
//                        .Where(l => l.Day == day && l.Slot == slot + 1)
//                        .FirstOrDefault();

//                    if (previous != null && next != null)
//                    {
//                        previous = next;
//                        last = next;
//                    }
//                }
//                last = first;
//            }
//            c.GetFitness();
//        }

//        //swap mutation
//        //Мутація перестановкою
//        public void SwapMutation(Chromosome c)
//        {
//            int day1;
//            int slotno1;
//            int day2;
//            int slotno2;
//            int geneno;
//            Lesson lessonOne, lessonTwo;
//            geneno = random.Next(numberOfGrades);

//            do
//            {
//                do
//                {
//                    day1 = random.Next(1, 6);
//                    slotno1 = random.Next(1, 9);
//                } while (!c.genes[geneno].geneLessons.Any(l => l.Day == day1 && l.Slot == slotno1));

//                do
//                {
//                    day2 = random.Next(1, 6);
//                    slotno2 = random.Next(1, 9);
//                } while (!c.genes[geneno].geneLessons.Any(l => l.Day == day2 && l.Slot == slotno2));

//                lessonOne = c.genes[geneno].geneLessons
//                    .Where(l => l.Day == day1 && l.Slot == slotno1)
//                    .FirstOrDefault();
//                lessonTwo = c.genes[geneno].geneLessons
//                    .Where(l => l.Day == day2 && l.Slot == slotno2)
//                    .FirstOrDefault();

//            } while (lessonOne == lessonTwo);

//            Lesson temp = lessonOne;
//            lessonOne = lessonTwo;
//            lessonTwo = temp;
//            c.GetFitness();
//        }
//    }
//}

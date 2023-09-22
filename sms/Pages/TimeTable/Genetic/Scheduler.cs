using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using sms.Data;
using sms.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;

namespace sms.Pages.TimeTable
{
    //Genetic algorithm scheluder
    //Генератор розкладу за генетичним алгоритмом
    public class Scheduler
    {
        Settings settings;

        public List<Curriculum> cachedCurricula;
        public List<Grade> cachedGrades;
        public List<Teacher> cachedTeachers;
        public List<int> allGradeIds;
        public double totalNumberOfLessons;

        private readonly ApplicationDbContext _context;
        private readonly ILogger<IndexModel> _logger;
        List<Chromosome> firstList;
        List<Chromosome> newList;
        List<Chromosome> softList;
        public Chromosome finalSon;

        double firstListFitness;
        double newListFitness;
        Random random;
        int numberOfGrades;
        int crossoverPoint;

        Stopwatch stopwatch = new Stopwatch();

        public Scheduler(ApplicationDbContext context, ILogger<IndexModel> logger)
        {
            using (StreamReader r = new StreamReader("GeneticSettings.json"))
            {
                string json = r.ReadToEnd();
                settings = JsonSerializer.Deserialize<Settings>(json);
            }

            _context = context;
            cachedCurricula = _context.Curricula.AsNoTracking().ToList();
            totalNumberOfLessons = cachedCurricula.Sum(c => c.Quantity);
            cachedGrades = _context.Grades.AsNoTracking().ToList();
            numberOfGrades = cachedGrades.Count();
            crossoverPoint = numberOfGrades / 2;
            allGradeIds = cachedGrades.Select(g => g.Id).ToList();
            cachedTeachers = _context.Teachers.AsNoTracking().ToList();
            stopwatch = new Stopwatch();

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
            stopwatch.Start();
            firstList = new List<Chromosome>();
            firstListFitness = 0;

            for (int i = 0; i < settings.populationSize; i++)
            {
                Chromosome c;
                firstList.Add(c = new Chromosome(totalNumberOfLessons,
                    cachedCurricula, cachedGrades, random, numberOfGrades));
                firstListFitness += c.fitness;
            }
            firstList.Sort();
        }
        public void CreateNewGenerations()
        {
            Chromosome son = null;
            Chromosome mother = null;
            Chromosome father = null;
            softList = new List<Chromosome>();
            int min = int.MaxValue;

            int nogenerations = 0;

            //looping max no of generations times or until suitable chromosome found
            //Підбір хромосоми
            while (nogenerations < settings.maxGenerations)
            {
                newList = new List<Chromosome>();

                newListFitness = 0;
                int i;

                //Best chromosomes added as it is - Elitism
                //Відбір найкращих хромосом
                for (i = 0; i < settings.populationSize / 10; i++)
                {
                    newList.Add(firstList[i]);
                    newListFitness += firstList[i].fitness;
                }

                //adding other members after performing crossover and mutation
                //Додавання населення
                while (i < settings.populationSize)
                {
                    //crossover
                    //Схрещування
                    mother = RouletteWheelSelection();
                    father = RouletteWheelSelection();
                    //mother = TournamentSelection();
                    //father = TournamentSelection();

                    if (random.NextDouble() < settings.crossoverRate)
                        son = Crossover(mother, father);
                    else
                        son = Chromosome.CloneChromosome(father);

                    if (random.NextDouble() < settings.mutationRate)
                        UniformMutation(son);


                    //son.RemoveStudentsGaps();
                    if (random.NextDouble() < settings.gapsRemovalRate)
                        son.RemoveTeachersGaps();
                    son.RemoveTeachersConflicts();

                    son.GetFitness();
                    if (son.fitness == 1.0 && son.gapScore >= settings.gapScore)
                        break;
                    //if (son.fitness == 1)
                    //    break;

                    newList.Add(son);
                    newListFitness += son.fitness;
                    i++;
                }

                //if chromosome with fitness 1 found
                //Якщо знайшли бездоганну хромосому
                if (i < settings.populationSize)
                {
                    stopwatch.Stop();
                    _logger.LogInformation($"Час на 1000 {stopwatch.ElapsedMilliseconds / nogenerations * 1000}");

                    _logger.LogInformation($"Розклад згенеровано у {i} хромосомі " +
                        $"{nogenerations + 2} покоління. Час {stopwatch.Elapsed}");
                    finalSon = son;
                    _logger.LogInformation($"Generation: {nogenerations + 1,6} " +
                        $"| Fitness: {firstListFitness,9:N5} " +
                        $"| finalSon: {finalSon.fitness,7:N5} " +
                        $"| Gaps: {finalSon.gaps,4} " +
                        $"| GapScore: {finalSon.gapScore,7:N5} " +
                        $"| Min: {min,4}");
                    break;
                }

                //if chromosome with required fitness not found in this generation
                //Якщо бездоганну хромосому не знайшли
                //newListFitness = 0;
                //for (int f = 0; f < settings.populationSize; f++)
                //{
                //    newListFitness += newList[f].GetFitness();
                //}

                firstList = newList;
                firstListFitness = newListFitness;
                firstList.Sort();

                finalSon = firstList[0];
                if (finalSon.gaps < min)
                    min = finalSon.gaps;

                //if (firstList[0].fitness == 1.0)
                //{
                //    softList.Add(Chromosome.CloneChromosome(firstList[0]));
                //    softList.Sort();
                //    if (softList[0].gaps < min)
                //        min = finalSon.gaps;
                //}
                //if (softList.Count > 0)
                //    finalSon = softList[0];
                //else
                //    finalSon = firstList[0];

                //if (finalSon.fitness == 1.0)
                //_logger.LogInformation($"Generation: {nogenerations + 1,6} " +
                //        $"| Fitness: {firstListFitness,9:N5} " +
                //        $"| finalSon: {finalSon.fitness,7:N5} " +
                //        $"| Gaps: {finalSon.gaps,4} " +
                //        $"| GapScore: {finalSon.gapScore,7:N5} " +
                //        $"| Min: {min,4}");

                nogenerations++;
            }
        }
        //selecting using Roulette Wheel Selection only from the best chromosomes
        //Вибір випадковим чином з найкращих хромосом
        public Chromosome RouletteWheelSelection()
        {
            //List<Chromosome> bestParents = new List<Chromosome>();
            Chromosome parent = null;
            int rnd = random.Next(1, 101);
            if (rnd > 90 && rnd < 101) // 10% chance to take worst 60%+
            {
                parent = firstList[random.Next((int)(settings.populationSize * 0.6), settings.populationSize)];
            }
            if (rnd > 70 && rnd < 91) // 20% chance to take middle 30-60%
            {
                parent = firstList[random.Next((int)(settings.populationSize * 0.3), (int)(settings.populationSize * 0.6))];
            }
            if (rnd > 0 && rnd < 71) // 70% chance to take the best 30%
            {
                parent = firstList[random.Next(0, (int)(settings.populationSize * 0.3))];
            }
            return parent;
        }
        //Choose the best out of random x
        //Вибір найкращого серед випадкових x
        public Chromosome TournamentSelection()
        {
            int poolSize = 5;
            Chromosome[] pool = new Chromosome[poolSize];
            for (int i = 0; i < poolSize; i++)
            {
                pool[i] = firstList[random.Next(settings.populationSize)];
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
            return Chromosome.CloneChromosome(child);
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
                slot1 = random.Next(Table.maxLessonsPerWeek);
                slot2 = random.Next(Table.maxLessonsPerWeek);
            } while (slot1 == slot2);
            int temp = c.genes[grade].slotno[slot1];
            c.genes[grade].slotno[slot1] = c.genes[grade].slotno[slot2];
            c.genes[grade].slotno[slot2] = temp;
        }
    }
    public class Settings
    {
        public int maxGenerations { get; set; }
        public int populationSize { get; set; }
        public double mutationRate { get; set; }
        public double crossoverRate { get; set; }
        public double gapScore { get; set; }
        public double gapsRemovalRate { get; set; }
    }
}

using sms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smsTest
{
    public class Seeder
    {
        public Seeder(ApplicationDbContext context)
        {
            var students = new SeedStudent();
            var grades = new SeedGrade(students);
            var subjects = new SeedSubject();
            var teachers = new SeedTeacher(subjects);
            var lessons = new SeedLesson(grades, subjects, teachers);
            var curricula = new SeedCurriculum(grades, subjects, teachers);
            var gradebooks = new SeedGradebook(students, subjects, teachers);
            var assignments = new SeedAssignment(grades, subjects, teachers);
            var books = new SeedBook();
            var inventories = new SeedInventory();

            if (!context.Students.Any())
            {
                context.AddRange(students.data);
            }
            if (!context.Grades.Any())
            {
                context.AddRange(grades.data);
            }
            if (!context.Teachers.Any())
            {
                context.AddRange(teachers.data);
            }
            if (!context.Subjects.Any())
            {
                context.AddRange(subjects.data);
            }
            if (!context.Lessons.Any())
            {
                context.AddRange(lessons.data);
            }
            if (!context.Curricula.Any())
            {
                context.AddRange(curricula.data);
            }
            if (!context.Gradebooks.Any())
            {
                context.AddRange(gradebooks.data);
            }
            if (!context.Assignments.Any())
            {
                context.AddRange(assignments.data);
            }
            if (!context.Books.Any())
            {
                context.AddRange(books.data);
            }
            if (!context.Inventories.Any())
            {
                context.AddRange(inventories.data);
            }
            context.SaveChanges();
        }
    }
}

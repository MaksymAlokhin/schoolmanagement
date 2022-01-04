using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static sms.Authorisation.Operations;
using sms.Models;

namespace sms.Data
{
    public static class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // For sample purposes seed both with the same password.
                // Password is set with the following:
                // dotnet user-secrets set SeedUserPW <pw>
                // The admin user can do anything

                var adminID = await EnsureUser(serviceProvider, testUserPw, "admin@sms.com");
                await EnsureRole(serviceProvider, adminID, Constants.AdministratorsRole);

                var stewardID = await EnsureUser(serviceProvider, testUserPw, "steward@sms.com");
                await EnsureRole(serviceProvider, stewardID, Constants.StewardsRole);

                var teacherID = await EnsureUser(serviceProvider, testUserPw, "teacher@sms.com");
                await EnsureRole(serviceProvider, teacherID, Constants.TeachersRole);

                var librarianID = await EnsureUser(serviceProvider, testUserPw, "librarian@sms.com");
                await EnsureRole(serviceProvider, librarianID, Constants.LibrariansRole);

                var parentID = await EnsureUser(serviceProvider, testUserPw, "parent@sms.com");
                await EnsureRole(serviceProvider, parentID, Constants.ParentsRole);

                var newID = await EnsureUser(serviceProvider, testUserPw, "newuser@sms.com");

                SeedDB(context);
            }
        }

        private static async Task<string> EnsureUser(IServiceProvider serviceProvider,
                                                    string testUserPw, string UserName)
        {
            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByNameAsync(UserName);
            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = UserName,
                    EmailConfirmed = true
                };
                await userManager.CreateAsync(user, testUserPw);
            }

            if (user == null)
            {
                throw new Exception("The password is probably not strong enough!");
            }

            return user.Id;
        }

        private static async Task<IdentityResult> EnsureRole(IServiceProvider serviceProvider,
                                                                      string uid, string role)
        {
            IdentityResult IR = null;
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            if (roleManager == null)
            {
                throw new Exception("roleManager null");
            }

            if (!await roleManager.RoleExistsAsync(role))
            {
                IR = await roleManager.CreateAsync(new IdentityRole(role));
            }

            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();

            var user = await userManager.FindByIdAsync(uid);

            if (user == null)
            {
                throw new Exception("The testUserPw password was probably not strong enough!");
            }

            var roles = await userManager.GetRolesAsync(user);
            if(roles.Count == 0)
            {
                IR = await userManager.AddToRoleAsync(user, role);
            }
            return IR;
        }
        public static void SeedDB(ApplicationDbContext context)
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
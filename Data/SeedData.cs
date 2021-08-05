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

                var newID = await EnsureUser(serviceProvider, testUserPw, "1@1.com");

                SeedDB(context, adminID);
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
        public static void SeedDB(ApplicationDbContext context, string adminID)
        {
            if (!context.Students.Any())
            {
                context.AddRange(StudentsSeedData.data);
            }
            if (!context.Grades.Any())
            {
                context.AddRange(GradesSeedData.data);
            }
            if (!context.Teachers.Any())
            {
                context.AddRange(TeachersSeedData.data);
            }
            if (!context.Subjects.Any())
            {
                context.AddRange(SubjectsSeedData.data);
            }
            if (!context.Lessons.Any())
            {
                context.AddRange(LessonsSeedData.data);
            }
            if (!context.Curricula.Any())
            {
                context.AddRange(CurriculaSeedData.data);
            }
            if (!context.Gradebooks.Any())
            {
                context.AddRange(GradebooksSeedData.data);
            }

            context.SaveChanges();
        }

    }
}
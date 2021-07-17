using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static sms.Authorisation.Operations;

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

            IR = await userManager.AddToRoleAsync(user, role);

            return IR;
        }
        public static void SeedDB(ApplicationDbContext context, string adminID)
        {
            //if (context.Contact.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //context.Contact.AddRange(
            //    new Contact
            //    {
            //        Name = "Debra Garcia",
            //        Address = "1234 Main St",
            //        City = "Redmond",
            //        State = "WA",
            //        Zip = "10999",
            //        Email = "debra@example.com",
            //        Status = ContactStatus.Approved,
            //        OwnerID = adminID
            //    },
            //    new Contact
            //    {
            //        Name = "Thorsten Weinrich",
            //        Address = "5678 1st Ave W",
            //        City = "Redmond",
            //        State = "WA",
            //        Zip = "10999",
            //        Email = "thorsten@example.com",
            //        Status = ContactStatus.Submitted,
            //        OwnerID = adminID
            //    },
            // new Contact
            // {
            //     Name = "Yuhong Li",
            //     Address = "9012 State st",
            //     City = "Redmond",
            //     State = "WA",
            //     Zip = "10999",
            //     Email = "yuhong@example.com",
            //     Status = ContactStatus.Rejected,
            //     OwnerID = adminID
            // },
            // new Contact
            // {
            //     Name = "Jon Orton",
            //     Address = "3456 Maple St",
            //     City = "Redmond",
            //     State = "WA",
            //     Zip = "10999",
            //     Email = "jon@example.com",
            //     Status = ContactStatus.Submitted,
            //     OwnerID = adminID
            // },
            // new Contact
            // {
            //     Name = "Diliana Alexieva-Bosseva",
            //     Address = "7890 2nd Ave E",
            //     City = "Redmond",
            //     State = "WA",
            //     Zip = "10999",
            //     Email = "diliana@example.com",
            //     OwnerID = adminID
            // }
            // );
            //context.SaveChanges();
        }

    }
}
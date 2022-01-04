using System;
using Xunit;
using sms.Pages;
using sms.Data;
using sms.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace smsTest
{
    public class CurriculaTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public CurriculaTests()
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("CurriculaTestDatabase")
                    .Options;
            context = new ApplicationDbContext(contextOptions);
            SeedCurricula(context);
        }
        public void Dispose()
        {
            context.Dispose();
        }
        private void SeedCurricula(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

        }


        [Fact]
        public void Test1()
        {
            
        }
    }
}

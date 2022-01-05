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
using sms;

namespace smsTest
{
    public class InventoriesTests : IDisposable
    {
        private int PageSize;
        public ApplicationDbContext context { get; private set; }

        public InventoriesTests()
        {
            PageSize = 7;
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase("InventoriesTestDatabase")
                    .Options;
            context = new ApplicationDbContext(contextOptions);
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Seeder seeder = new Seeder(context);
        }
        public void Dispose()
        {
            context.Dispose();
        }

        [Fact]
        public async Task Inventories_IndexModel_OnGetAsync_InventoriesAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.IndexModel(context, config);
            var expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue);

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Inventories_IndexModel_OnGetAsync_InventoriesAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.IndexModel(context, config);
            var expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue);

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderByDescending(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderByDescending(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("йсь")]
        [InlineData("цт")]
        [InlineData("ра")]
        public async Task Inventories_IndexModel_OnGetAsync_FilteredListOfInventoriesIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.IndexModel(context, config);
            IQueryable<Inventory> expectedInventories = context.Inventories;
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedInventories = context.Inventories.Where(s => !s.DecommissionDate.HasValue && s.Name.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Inventories_IndexModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.IndexModel(context, config);
            List<Inventory> expectedInventories = new List<Inventory>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Inventories.Where(i => !i.DecommissionDate.HasValue).Count() / (double)PageSize))
            {
                expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue)
                    .OrderBy(m => m.Name)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue)
                    .OrderBy(m => m.Name)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Inventories_CreateModel_OnPostAsync_InventoryIsAdded()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.CreateModel(context);
            var expectedInventories = new Inventory
            {
                Id = 381,
                Name = "New Inventory Item",
                InventoryNumber = 12345678,
                Quantity = 12,
                Price = 1000.0M,
                InventoryDate = new DateTime(2014, 5, 5)
            };
            pageModel.Inventory = expectedInventories;
            // Act
            var result = await pageModel.OnPostAsync();

            // Assert
            var actualInventory = await context.Inventories.Where(i => !i.DecommissionDate.HasValue)
                .Where(c => c.Name == "New Inventory Item")
                .FirstOrDefaultAsync();
            //var object1Json = JsonSerializer.Serialize(expectedInventories);
            //var object2Json = JsonSerializer.Serialize(actualInventory);
            Assert.Equal(expectedInventories, actualInventory);
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Inventories_CreateModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.CreateModel(context);
            var expectedInventories = new Inventory
            {
                Id = 380,
                Name = "New Inventory Item",
                InventoryNumber = 12345678,
                Quantity = 12,
                Price = 1000.0M,
                InventoryDate = new DateTime(2014, 5, 5)
            };
            pageModel.Inventory = expectedInventories;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync();

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Inventories_DeleteModel_OnGetAsync_InventoryIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DeleteModel(context);
            var testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Inventory>(pageModel.Inventory);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Аксесуари та витратні матеріали до дошок: губка для витирання", model.Name);
            Assert.Equal(97060980, model.InventoryNumber);
            Assert.Equal(19, model.Quantity);
            Assert.Equal(2471.68M, model.Price);
            Assert.Equal(new DateTime(2014, 05, 05), model.InventoryDate);
        }
        [Fact]
        public async Task Inventory_DeleteModel_OnPostAsync_InventoryIsDeleted_WhenInventoryIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DeleteModel(context);
            var testId = 1;
            var expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue).Where(c => c.Id != testId).ToList();

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualInventories = await context.Inventories.Where(i => !i.DecommissionDate.HasValue).AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedInventories.OrderBy(m => m.Id).Select(m => m.Name ),
                actualInventories.OrderBy(m => m.Id).Select(m => m.Name ));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Inventory_DeleteModel_OnPostAsync_NoInventoryIsDeleted_WhenInventoryIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DeleteModel(context);
            var testId = 320;
            var expectedInventories = context.Inventories.Where(i => !i.DecommissionDate.HasValue);

            // Act
            var result = await pageModel.OnPostAsync(null, null, null, testId);

            // Assert
            var actualInventories = await context.Inventories.Where(i => !i.DecommissionDate.HasValue).AsNoTracking().ToListAsync();
            Assert.Equal(
                expectedInventories.OrderBy(m => m.Id).Select(m => m.Name),
                actualInventories.OrderBy(m => m.Id).Select(m => m.Name));
            Assert.IsType<RedirectToPageResult>(result);
        }
        [Fact]
        public async Task Inventory_EditModel_OnGetAsync_InventoryIsFetched()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.EditModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Inventory>(pageModel.Inventory);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Аксесуари та витратні матеріали до дошок: губка для витирання", model.Name);
            Assert.Equal(97060980, model.InventoryNumber);
            Assert.Equal(19, model.Quantity);
            Assert.Equal(2471.68M, model.Price);
            Assert.Equal(new DateTime(2014, 05, 05), model.InventoryDate);
        }
        [Fact]
        public async Task Inventory_EditModel_OnPostAsync_InventoryIsModified()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.EditModel(context);
            int testId = 1;
            var expectedInventory = context.Inventories.Where(i => !i.DecommissionDate.HasValue).FirstOrDefault(m => m.Id == testId);
            pageModel.Inventory = expectedInventory;
            pageModel.Inventory.Quantity = 33;

            // Act
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<RedirectToPageResult>(result);
            var model = Assert.IsAssignableFrom<Inventory>(pageModel.Inventory);
            Assert.Equal(33, model.Quantity);
        }
        [Fact]
        public async Task Inventory_EditModel_OnPostAsync_IfInvalidModel_ReturnPageResult()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.EditModel(context);
            int testId = 1;
            var expectedInventory = context.Inventories.Where(i => !i.DecommissionDate.HasValue).FirstOrDefault(m => m.Id == testId);
            pageModel.Inventory = expectedInventory;
            pageModel.Inventory.Quantity = 33;

            // Act
            pageModel.ModelState.AddModelError("Error", "ModelState is invalid");
            var result = await pageModel.OnPostAsync(null, null, null);

            // Assert
            Assert.IsType<PageResult>(result);
        }
        [Fact]
        public async Task Inventory_DetailsModel_OnGetAsync_InventoryIsFetched_WhenInventoryIsFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DetailsModel(context);
            int testId = 1;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<PageResult>(result);
            var model = Assert.IsAssignableFrom<Inventory>(pageModel.Inventory);
            Assert.Equal(testId, model.Id);
            Assert.Equal("Аксесуари та витратні матеріали до дошок: губка для витирання", model.Name);
            Assert.Equal(97060980, model.InventoryNumber);
            Assert.Equal(19, model.Quantity);
            Assert.Equal(2471.68M, model.Price);
            Assert.Equal(new DateTime(2014, 05, 05), model.InventoryDate);
        }

        //DetailsModel
        [Fact]
        public async Task Inventory_DetailsModel_OnGetAsync_NotFoundResultReturned_WhenInventoryIsNotFound()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DetailsModel(context);
            int testId = 880;

            // Act
            var result = await pageModel.OnGetAsync(null, null, null, testId);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }
        //*****************
        [Fact]
        public async Task Inventories_DecommissionedModel_OnGetAsync_InventoriesAreReturned()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DecommissionedModel(context, config);
            var expectedInventories = context.Inventories.Where(i => i.DecommissionDate.HasValue);

            // Act
            await pageModel.OnGetAsync(null, null, null, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Fact]
        public async Task Inventories_DecommissionedModel_OnGetAsync_InventoriesAreReturnedInDescendingOrder()
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DecommissionedModel(context, config);
            var expectedInventories = context.Inventories.Where(i => i.DecommissionDate.HasValue);

            // Act
            await pageModel.OnGetAsync("name_desc", null, null, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderByDescending(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderByDescending(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData("")]
        [InlineData("йсь")]
        [InlineData("цт")]
        [InlineData("ра")]
        public async Task Inventories_DecommissionedModel_OnGetAsync_FilteredListOfInventoriesIsReturned(string searchString)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DecommissionedModel(context, config);
            IQueryable<Inventory> expectedInventories = context.Inventories.Where(s => s.DecommissionDate.HasValue);
            if (!String.IsNullOrEmpty(searchString))
            {
                expectedInventories = expectedInventories.Where(s => s.DecommissionDate.HasValue && s.Name.Contains(searchString));
            }

            // Act
            await pageModel.OnGetAsync(null, null, searchString, null);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(int.MinValue)]
        [InlineData(int.MaxValue)]
        public async Task Inventories_DecommissionedModel_OnGetAsync_PaginationWorkingAsExpected(int pageIndex)
        {
            // Arrange
            var config = new ConfigurationBuilder().Build();
            var pageModel = new sms.Pages.Equipment.DecommissionedModel(context, config);
            List<Inventory> expectedInventories = new List<Inventory>();
            if (pageIndex > 0 && pageIndex <= Math.Ceiling((double)context.Inventories.Where(i => i.DecommissionDate.HasValue).Count() / (double)PageSize))
            {
                expectedInventories = context.Inventories.Where(i => i.DecommissionDate.HasValue)
                    .OrderBy(m => m.Name)
                    .Skip((pageIndex - 1) * PageSize)
                    .Take(PageSize)
                    .ToList();
            }
            else
            {
                expectedInventories = context.Inventories.Where(i => i.DecommissionDate.HasValue)
                    .OrderBy(m => m.Name)
                    .Take(PageSize)
                    .ToList(); ;
            }

            // Act
            await pageModel.OnGetAsync(null, null, null, pageIndex);

            // Assert
            var actualInventories = Assert.IsAssignableFrom<PaginatedList<Inventory>>(pageModel.Inventory);
            Assert.Equal(
                expectedInventories
                    .OrderBy(m => m.Name)
                    .Take(PageSize).Select(m => m.Name),
                actualInventories
                    .OrderBy(m => m.Name)
                    .Select(m => m.Name)
                );
        }
    }
}

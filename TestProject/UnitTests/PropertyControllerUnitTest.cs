using System;
using System.Threading.Tasks;
using Applications.BLL.App;
using DAL.App.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApp.ApiControllers;
using WebApp.Controllers.TestControllers;
using Xunit;
using Xunit.Abstractions;
using PropertyTypesController = WebApp.Controllers.PropertyTypesController;

namespace TestProject.UnitTests
{
    public class PropertyControllerUnitTest
    {
        private readonly TestController _testController;
        private readonly ITestOutputHelper _testOutputHelper;
        private readonly AppDbContext _ctx;

        public PropertyControllerUnitTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;

            var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            _ctx = new AppDbContext(optionBuilder.Options);
            _ctx.Database.EnsureDeleted();
            _ctx.Database.EnsureCreated();

            using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            var logger = loggerFactory.CreateLogger<TestController>();
            _testController = new TestController(logger, _ctx);
        }

        [Fact]
        public async Task Action_Test_Returns_View()
        {
            // ACT
            var result = await _testController.Test();
            
            // ASSERT
            Assert.NotNull(result);
        }
    }
}
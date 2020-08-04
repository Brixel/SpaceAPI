using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;
using SpaceAPI.Host.Controllers;

namespace SpaceAPI.Test.Controllers
{
    [TestFixture]
    public class StatusControllerTest
    {
        private Mock<IHttpContextAccessor> _httpContextAccessor;
        private LogContext _context;

        [OneTimeSetUp]
        public void TestSetup()
        {
            _httpContextAccessor = new Mock<IHttpContextAccessor>();
            var dbContextOptions = new DbContextOptionsBuilder<LogContext>().UseInMemoryDatabase("LogContext").Options;
            _context = new LogContext(_httpContextAccessor.Object, dbContextOptions);
        }

        [Test]
        public async Task OpenTest()
        {
            // Arrange
            var sut = new StatusController(_context);

            // Act
            var response = await sut.Open();
            // Assert
            response.Should().NotBeNull();
            response.State.Open.Should().BeTrue();
        }

        [Test]
        public async Task CloseTest()
        {
            // Arrange
            _context.StateLogs.Add(new StateLog());
            // Act
            StatusController controller = new StatusController(_context);
            var response = await  controller.Close();;

            // Assert
            response.Should().NotBeNull();
            response.State.Open.Should().BeFalse();
        }
    }
}

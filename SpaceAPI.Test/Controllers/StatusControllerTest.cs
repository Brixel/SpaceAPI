using System.Threading.Tasks;
using FluentAssertions;
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
        [Test, Ignore("BECAUSE I CAN")]
        public async Task OpenTest()
        {
            // Arrange
            StatusController controller = new StatusController(It.IsAny<LogContext>());

            // Act
            var response = await controller.Open();
            // Assert
            response.Should().NotBeNull();
            response.State.Open.Should().BeTrue();
        }

        [Test, Ignore("BECAUSE I CAN")]
        public async Task CloseTest()
        {
            // Arrange

            Mock<LogContext> contextMock = new Mock<LogContext>();
            contextMock.Setup(x => x.StateLogs.Add(It.IsAny<StateLog>()));
            // Act
            StatusController controller = new StatusController(contextMock.Object);
            var response = await  controller.Close();;

            // Assert
            response.Should().NotBeNull();
            response.State.Open.Should().BeFalse();
        }

    }
}

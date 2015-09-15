using System.Web.Http;
using System.Web.Http.Results;
using Moq;
using NUnit.Framework;
using SpaceAPI.Controllers;
using SpaceAPI.Data.Contexts;
using SpaceAPI.Data.Models;
using SpaceAPI.Models.API;

namespace SpaceAPI.Tests.Controllers
{
    [TestFixture]
    public class StatusControllerTest
    {
        [Test, Ignore]
        public void OpenTest()
        {
            // Arrange
            StatusController controller = new StatusController();

            // Act
            IHttpActionResult response = controller.Open();

            var result = response as OkNegotiatedContentResult<Root>;

            
            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(true, result.Content.State.Open);
        }

        [Test, Ignore]
        public void CloseTest()
        {
            // Arrange

            Mock<LogContext> contextMock = new Mock<LogContext>();
            contextMock.Setup(x => x.StateLogs.Add(It.IsAny<StateLog>()));
            // Act
            StatusController controller = new StatusController(contextMock.Object);
            IHttpActionResult response = controller.Close();
            var result = response as OkNegotiatedContentResult<Root>;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(false, result.Content.State.Open);
        }

    }
}

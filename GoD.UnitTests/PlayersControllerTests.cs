using GoD.WebApi.Controllers;
using GoD.WebApi.Core;
using GoD.WebApi.Core.Models;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace GoD.UnitTests
{
    [TestFixture]
    public class PlayersControllerTests
    {
        [Test]
        public async Task GetPlayers_WhenCalled_ReturnOk()
        {
            var _player = new Player
            {
                Id = 1,
                Name = "A",
                Active = true
            };

            // Arrange
            var unitOfWork = new Mock<IUnitOfWork>();
            unitOfWork.Setup(uow => uow.Players.GetPlayers())
                .ReturnsAsync(new List<Player>{ _player });

            var controller = new PlayersController(unitOfWork.Object);

            //Act
            var result = await controller.GetPlayers();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<IEnumerable<Player>>>());
        }
    }
}

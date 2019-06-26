using GoD.WebApi.Controllers;
using GoD.WebApi.Core;
using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.ViewModels;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace GoD.UnitTests.Controllers
{
    [TestFixture]
    public class PlayersControllerTests
    {
        private Mock<IUnitOfWork> _unitOfWork;
        private PlayersController _playersController;

        [SetUp]
        public void SetUp()
        {
            _unitOfWork = new Mock<IUnitOfWork>();
            _playersController = new PlayersController(_unitOfWork.Object);
        }

        [Test]
        public async Task GetPlayers_WhenCalled_ReturnOk()
        {
            var player = new Player
            {
                Id = 1,
                Name = "A",
                Active = true
            };

            // Arrange
            _unitOfWork.Setup(uow => uow.Players.GetPlayers())
                .ReturnsAsync(new List<Player>{ player });

            //Act
            var result = await _playersController.GetPlayers();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<IEnumerable<Player>>>());
        }

        [Test]
        public async Task CreatePlayers_WhenCalled_ReturnOk()
        {
            // Arrange
            _unitOfWork
                .Setup(uow => uow.Players.CreatePlayers(It.IsAny<IEnumerable<PlayersViewModel>>()));

            var playerList = new List<PlayersViewModel>
            {
                new PlayersViewModel
                {
                    PlayerName = "Jon Snow"
                }
            };

            // Act
            var result = await _playersController.CreatePlayers(playerList);

            // Assert
            Assert.That(result, Is.TypeOf<OkResult>());
        }

        [Test]
        public async Task InactivePlayers_WhenCalled_ReturnOk()
        {
            // Arrange
            _unitOfWork.Setup(uow => uow.Players.InactivePlayers()).Returns(Task.CompletedTask);

            // Act
            var result = await _playersController.InactivePlayers();

            // Assert
            Assert.That(result, Is.TypeOf<OkResult>());
        }
    }
}

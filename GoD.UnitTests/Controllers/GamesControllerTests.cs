using GoD.WebApi.Controllers;
using GoD.WebApi.Core.Dto;
using GoD.WebApi.Core.ViewModels;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Http.Results;

namespace GoD.UnitTests.Controllers
{
    [TestFixture]
    public class GamesControllerTests
    {
        private GamesController _gamesController;
        private List<MovesViewModel> _playersMoves;

        [SetUp]
        public void SetUp()
        {
            _gamesController = new GamesController();
            _playersMoves = new List<MovesViewModel>
            {
                new MovesViewModel
                {
                    Move = "Paper",
                    Player = new PlayerDto
                    {
                        Id = 17,
                        Name = "Victor",
                        Active = true
                    }
                },
                new MovesViewModel
                {
                    Move = "Scissors",
                    Player = new PlayerDto
                    {
                        Id = 18,
                        Name = "Michael",
                        Active = true
                    }
                }
            };
        }

        [TearDown]
        public void Dispose()
        {
            _gamesController.Dispose();
        }

        [Test]
        public void ValidateMoves_WhenCalled_ReturnOk()
        {
            // Act
            var result = _gamesController.ValidateMoves(_playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<string>>());
        }
    }
}

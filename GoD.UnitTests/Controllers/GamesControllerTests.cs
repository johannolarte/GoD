using GoD.WebApi.Controllers;
using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.ViewModels;
using NUnit.Framework;
using System.Collections.Generic;
using System.Web.Http.Results;

namespace GoD.UnitTests.Controllers
{
    [TestFixture]
    public class GamesControllerTests
    {
        [Test]
        public void ValidateMoves_WhenCalled_ReturnOk()
        {
            // Arrange
            var playersMoves = new List<MovesViewModel>
            {
                new MovesViewModel
                {
                    Move = "Paper",
                    Player = new Player
                    {
                        Id = 17,
                        Name = "Victor",
                        Active = true
                    }
                },
                new MovesViewModel
                {
                    Move = "Scissors",
                    Player = new Player
                    {
                        Id = 18,
                        Name = "Michael",
                        Active = true
                    }
                }
            };

            var gamesController = new GamesController();

            // Act
            var result = gamesController.ValidateMoves(playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<string>>());
        }
    }
}

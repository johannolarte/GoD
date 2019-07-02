using GoD.WebApi.Core.Games;
using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.ViewModels;
using NUnit.Framework;
using System.Collections.Generic;

namespace GoD.UnitTests.Core.Games
{
    [TestFixture]
    public class GameServiceTests
    {
        [Test]
        public void ValidateMoves_PlayerOnePaperMoveAndPlayerTwoScissorsMove_ReturnPlayerTwoName()
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

            // Act
            var result = GameService.ValidateMoves(playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result, Is.EqualTo(playersMoves[1].Player.Name));
        }
    }
}

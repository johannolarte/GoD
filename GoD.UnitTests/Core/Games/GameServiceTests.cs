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
        private List<MovesViewModel> _playersMoves;

        [SetUp]
        public void SetUp()
        {
            _playersMoves = new List<MovesViewModel>
            {
                new MovesViewModel
                {
                    Move = string.Empty,
                    Player = new Player
                    {
                        Id = 17,
                        Name = "Victor",
                        Active = true
                    }
                },
                new MovesViewModel
                {
                    Move = string.Empty,
                    Player = new Player
                    {
                        Id = 18,
                        Name = "Michael",
                        Active = true
                    }
                }
            };
        }

        [TestCase("Paper", "Rock")]
        [TestCase("Rock", "Scissors")]
        [TestCase("Scissors", "Paper")]
        public void ValidateMoves_PlayerOneWinnerMoveAndPlayerTwoFailMove_ReturnPlayerOneName(string playerOneMove, string playerTwoMove)
        {
            // Arrange
            _playersMoves[0].Move = playerOneMove;
            _playersMoves[1].Move = playerTwoMove;

            // Act
            var result = GameService.ValidateMoves(_playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result, Is.EqualTo(_playersMoves[0].Player.Name));
        }

        [TestCase("Paper", "Scissors")]
        [TestCase("Rock", "Paper")]
        [TestCase("Scissors", "Rock")]
        public void ValidateMoves_PlayerOneFailMoveAndPlayerTwoWinnerMove_ReturnPlayerTwoName(string playerOneMove, string playerTwoMove)
        {
            // Arrange
            _playersMoves[0].Move = playerOneMove;
            _playersMoves[1].Move = playerTwoMove;

            // Act
            var result = GameService.ValidateMoves(_playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result, Is.EqualTo(_playersMoves[1].Player.Name));
        }

        [TestCase]
        public void ValidateMoves_PlayerOneAndPlayerTwoRockMove_ReturnDrawMessage()
        {
            // Arrange
            _playersMoves[0].Move = "Rock";
            _playersMoves[1].Move = "Rock";

            // Act
            var result = GameService.ValidateMoves(_playersMoves);

            // Result
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf<string>());
            Assert.That(result, Is.EqualTo("Draw"));
        }
    }
}

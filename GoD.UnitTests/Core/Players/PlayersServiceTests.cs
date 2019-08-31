using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.Players;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace GoD.UnitTests.Core.Players
{
    [TestFixture]
    public class PlayersServiceTests
    {
        private const string PlayerName = "Jon Snow";

        [Test]
        public void GetPlayers_WhenCalled_ReturnPlayerDtoList()
        {
            var player = new Player
            {
                Id = 1,
                Name = PlayerName,
                Active = true
            };

            //Act
            var result = PlayersService.GetPlayers(new List<Player> { player });

            // Assert
            Assert.That(result.Count, Is.GreaterThan(0));
        }
    }
}

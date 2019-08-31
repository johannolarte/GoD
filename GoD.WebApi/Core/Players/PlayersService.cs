using GoD.WebApi.Core.Dto;
using GoD.WebApi.Core.Models;
using System.Collections.Generic;
using System.Linq;

namespace GoD.WebApi.Core.Players
{
    public static class PlayersService
    {
        public static IEnumerable<PlayerDto> GetPlayers(IEnumerable<Player> players)
        {
            // ToDo: Apply AutoMapper here!!!
            return players.Select(player =>
                new PlayerDto
                {
                    Id = player.Id,
                    Name = player.Name,
                    Active = player.Active
                });
        }
    }
}
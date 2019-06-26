using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.Repositories;
using GoD.WebApi.Core.ViewModels;
using GoD.WebApi.Infrastructure.Web;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace GoD.WebApi.Persistence.Repositories
{
    public class PlayersRepository : OwinContextBase, IPlayersRepository
    {
        public void CreatePlayers(IEnumerable<PlayersViewModel> players)
        {
            var parsedPlayers = players.Select(p => new Player
            {
                Name = p.PlayerName,
                Active = true
            });

            _context.Players.AddRange(parsedPlayers);
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await _context.Players
                .Where(p => p.Active)
                .OrderByDescending(p => p.Id)
                .ToListAsync();
        }

        public async Task InactivePlayers() => await _context.Players.Where(p => p.Active).UpdateAsync(p => new Player { Active = false });
    }
}
using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.Repositories;
using GoD.WebApi.Core.ViewModels;
using GoD.WebApi.Infrastructure.Web;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GoD.WebApi.Persistence.Repositories
{
    public class PlayersRepository : OwinContextBase, IPlayersRepository
    {
        public async Task CreatePlayers(IEnumerable<PlayersViewModel> players)
        {
            players.Select(player => _context.Players.Add(new Player
            {
                Name = player.PlayerName,
                Active = true
            }))
            .ToList();

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Player>> GetPlayers()
        {
            return await _context.Players
                .Where(p => p.Active)
                .OrderByDescending(p => p.Id)
                .Take(2)
                .ToListAsync();
        }
    }
}
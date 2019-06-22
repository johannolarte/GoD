using GoD.WebApi.Core.Models;
using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoD.WebApi.Core.Repositories
{
    public interface IPlayersRepository
    {
        void CreatePlayers(IEnumerable<PlayersViewModel> players);
        Task<IEnumerable<Player>> GetPlayers();
    }
}
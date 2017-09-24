using GoD.WebApi.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoD.WebApi.Core.Repositories
{
    public interface IPlayersRepository
    {
        Task CreatePlayers(IEnumerable<PlayersViewModel> players);
    }
}
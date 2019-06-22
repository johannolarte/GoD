using GoD.WebApi.Core.Repositories;
using System.Threading.Tasks;

namespace GoD.WebApi.Core
{
    public interface IUnitOfWork
    {
        IPlayersRepository Players { get; }

        Task CompleteTaskAsync();
    }
}
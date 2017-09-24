using GoD.WebApi.Core.Repositories;

namespace GoD.WebApi.Core
{
    public interface IUnitOfWork
    {
        IPlayersRepository Players { get; }
    }
}
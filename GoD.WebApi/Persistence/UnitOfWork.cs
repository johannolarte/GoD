﻿using GoD.WebApi.Core;
using GoD.WebApi.Core.Repositories;
using GoD.WebApi.Infrastructure.Web;
using GoD.WebApi.Persistence.Repositories;

namespace GoD.WebApi.Persistence
{
    public class UnitOfWork : OwinContextBase, IUnitOfWork
    {
        public IPlayersRepository Players => new PlayersRepository();
    }
}
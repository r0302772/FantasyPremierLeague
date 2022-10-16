using FantasyPremierLeague.DataAcces.Repository;
using FantasyPremierLeague.Models.bootstrap_static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<BootstrapStaticRootobject> BootstrapStaticRepository { get; }
        //Task Save();
    }
}

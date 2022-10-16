using FantasyPremierLeague.DataAcces.Repository;
using FantasyPremierLeague.Models.bootstrap_static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HttpClient _httpClient;

        private IGenericRepository<BootstrapStaticRootobject> bootstrapStaticRepository;
        public UnitOfWork(HttpClient httpClient, string baseAdress)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://fantasy.premierleague.com/api/");
        }

        public IGenericRepository<BootstrapStaticRootobject> BootstrapStaticRepository
        {
            get
            {
                if (bootstrapStaticRepository == null)
                    bootstrapStaticRepository = new GenericRepository<BootstrapStaticRootobject>(_httpClient, "bootstrap-static/");

                return bootstrapStaticRepository;
            }
        }

        //public async Task Save()
        //{
        //    await _context.SaveChangesAsync();
        //}

    }
}

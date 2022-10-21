﻿using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(string endpoint);
        //IQueryable<TEntity> GetAll();

        //Task<TEntity> GetById(int id);

        //void Create(TEntity entity);
        //void Update(TEntity entity);

        //void Delete(TEntity entity);
    }
}
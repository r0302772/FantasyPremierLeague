﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly HttpClient _httpClient;

        public GenericRepository(HttpClient httpClient, string baseAdress)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://fantasy.premierleague.com/api/");
        }

        public async Task<TEntity> Get(string endpoint)
        {
            TEntity entity;
            using (_httpClient)
            {
                using (var response = await _httpClient.GetAsync(endpoint))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    entity = JsonConvert.DeserializeObject<TEntity>(apiResponse);
                }
            }

            return entity;
        }

        //private readonly HelloCoreContext _context;
        //public GenericRepository(HelloCoreContext context)
        //{
        //    _context = context;
        //}

        //public IQueryable<TEntity> GetAll()
        //{
        //    return _context.Set<TEntity>();
        //}

        //public async Task<TEntity> GetById(int id)
        //{
        //    return await _context.Set<TEntity>().FindAsync(id);
        //}

        //public async Task<TEntity> Get(string uri)
        //{
        //    return await _httpClient.GetAsync(uri);
        //}

        //public void Create(TEntity entity)
        //{
        //    _context.Set<TEntity>().Add(entity);
        //}

        //public void Update(TEntity entity)
        //{
        //    _context.Set<TEntity>().Update(entity);
        //}

        //public void Delete(TEntity entity)
        //{
        //    _context.Set<TEntity>().Remove(entity);
        //}
    }
}

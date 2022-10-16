using System.Linq;
using System.Threading.Tasks;

namespace FantasyPremierLeague.DataAcces.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        //IQueryable<TEntity> GetAll();

        //Task<TEntity> GetById(int id);
        //Task<TEntity> Get(string uri);

        //void Create(TEntity entity);
        //void Update(TEntity entity);

        //void Delete(TEntity entity);
    }
}
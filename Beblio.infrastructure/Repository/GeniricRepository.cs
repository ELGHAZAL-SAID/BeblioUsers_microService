using MMC.Domain.IRepositories;

namespace Beblio.infrastructure.Repository
{
    public class GeniricRepository<T> : IRepository<T> where T : class
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> PostAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> PutAsync(int id, T entity)
        {
            throw new NotImplementedException();
        }
    }
}

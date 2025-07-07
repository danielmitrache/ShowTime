using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{

    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly ShowTimeContext _context;
        private DbSet<T> _dbSet;
        public RepositoryBase(ShowTimeContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}

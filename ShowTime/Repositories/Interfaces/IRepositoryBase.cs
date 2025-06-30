namespace ShowTime.Repositories.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid Id);

        Task AddAsync(T entity);

        void Update(T entity);
        void Delete(T entity);

        Task SaveChangeAsync();
    }
}

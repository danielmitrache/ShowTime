using Microsoft.EntityFrameworkCore;
using ShowTime.Entities;

namespace ShowTime.Repositories.Interfaces
{
    public interface IRepositoryFestival : IRepositoryBase<ShowTime.Entities.Festival>
    {
        public Task<IEnumerable<Festival>> GetAllWithBandsAsync();

        public Task<Festival?> GetByIdWithBandsAsync(Guid id);
    }
}

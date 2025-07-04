using Microsoft.EntityFrameworkCore;
using ShowTime.Context;
using ShowTime.Entities;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class RepositoryFestival : RepositoryBase<ShowTime.Entities.Festival>, IRepositoryFestival
    {
        public RepositoryFestival(ShowTimeConext context) : base(context)
        {
        }

        public async Task<IEnumerable<Festival>> GetAllWithBandsAsync()
        {
            return await _context.Festivals
                                 .Include(f => f.FestivalBands).ThenInclude(fb => fb.Band)
                                 .ToListAsync();
        }
    }
}

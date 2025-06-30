using ShowTime.Context;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class RepositoryBand : RepositoryBase<ShowTime.Entities.Band>, IRepositoryBand
    {
        public RepositoryBand(ShowTimeConext context) : base(context)
        {
        }
    }
}

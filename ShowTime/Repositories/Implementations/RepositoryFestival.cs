using ShowTime.Context;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class RepositoryFestival : RepositoryBase<ShowTime.Entities.Festival>, IRepositoryFestival
    {
        public RepositoryFestival(ShowTimeConext context) : base(context)
        {
        }
    }
}

using ShowTime.Context;
using ShowTime.Repositories.Interfaces;

namespace ShowTime.Repositories.Implementations
{
    public class RepositoryBooking : RepositoryBase<ShowTime.Entities.Booking>, IRepositoryBooking
    {
        public RepositoryBooking(ShowTimeConext context) : base(context)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ShowTime.Entities;

namespace ShowTime.Context
{
    public class ShowTimeConext : DbContext
    {
        public ShowTimeConext(DbContextOptions<ShowTimeConext> options) : base(options)
        {
        }
        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<Booking> Bookings { get; set; }
  
    }
}

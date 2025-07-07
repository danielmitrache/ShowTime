using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShowTime.Entities;

namespace ShowTime.Context
{
    public class ShowTimeContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ShowTimeContext(DbContextOptions<ShowTimeContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FestivalBand>()
                .HasKey(sc => new { sc.FestivalId, sc.BandId });

            modelBuilder.Entity<FestivalBand>()
                .HasOne(sc => sc.Festival)
                .WithMany(s => s.FestivalBands)
                .HasForeignKey(sc => sc.FestivalId);

            modelBuilder.Entity<FestivalBand>()
                .HasOne(sc => sc.Band)
                .WithMany(c => c.FestivalBands)
                .HasForeignKey(sc => sc.BandId);
        }


        public DbSet<Festival> Festivals { get; set; }
        public DbSet<Band> Bands { get; set; }
        public DbSet<FestivalBand> FestivalBands { get; set; }
        public DbSet<Booking> Bookings { get; set; }
  
    }
}

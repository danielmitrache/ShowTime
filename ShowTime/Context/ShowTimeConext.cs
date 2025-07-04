using Microsoft.EntityFrameworkCore;
using ShowTime.Entities;

namespace ShowTime.Context
{
    public class ShowTimeConext : DbContext
    {
        public ShowTimeConext(DbContextOptions<ShowTimeConext> options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // cheie compusa
        //    modelBuilder.Entity<FestivalBand>()
        //                .HasKey(fb => new { fb.FestivalId, fb.BandId });

        //    // FK spre Festival
        //    modelBuilder.Entity<FestivalBand>()
        //                .HasOne(fb => fb.Festival)
        //                .WithMany(f => f.FestivalBands)
        //                .HasForeignKey(fb => fb.FestivalId);

        //    // FK spre Band
        //    modelBuilder.Entity<FestivalBand>()
        //                .HasOne(fb => fb.Band)
        //                .WithMany(b => b.FestivalBands)
        //                .HasForeignKey(fb => fb.BandId);

        //    //modelBuilder.Entity<Festival>()
        //    //            .HasMany(f => f.Bands)
        //    //            .WithMany(b => b.Festivals)
        //    //            .UsingEntity<FestivalBand>();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

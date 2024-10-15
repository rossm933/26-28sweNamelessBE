using Microsoft.EntityFrameworkCore;
using _26_28sweNamelessBE.Models;
using _26_28sweNamelessBE.Data;

namespace _26_28sweNamelessBE
{
    public class _26_28sweNamelessBEDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<RSVP> RSVPs { get; set; }

        public DbSet<Venue> Venues { get; set; }

        public _26_28sweNamelessBEDbContext(DbContextOptions<_26_28sweNamelessBEDbContext> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(EventData.Events);
            modelBuilder.Entity<Venue>().HasData(VenueData.Venues);
            modelBuilder.Entity<RSVP>().HasData(RSVPData.RSVPs);

            modelBuilder.Entity<Event>()
                .HasMany(e => e.RSVP)
                .WithOne(r => r.Event)
                .HasForeignKey(r => r.EventId)
                .OnDelete(DeleteBehavior.Cascade);
            
            modelBuilder.Entity<Venue>()
                .HasMany(v => v.Events)
                .WithOne(e => e.Venue)
                .HasForeignKey(e => e.VenueId)
                .OnDelete(DeleteBehavior.Cascade);

        }
        }
}

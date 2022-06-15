
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Reflection;
using Trips.Booking.Core.Entities;

namespace Trips.Booking.Infrastructure.Data
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options) : base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trip>()
                .HasIndex(x => new { x.Name })
                .IsUnique(true);

            modelBuilder.Entity<Customer>()
                .HasIndex(x => x.Email)
                .IsUnique(true);
                
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

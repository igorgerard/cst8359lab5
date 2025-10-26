using Lab5.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab5.Data
{
    public class DealsFinderDbContext : DbContext
    {
        public DealsFinderDbContext(DbContextOptions<DealsFinderDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<FoodDeliveryService> FoodDeliveryServices { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<FoodDeliveryService>().ToTable("FoodDeliveryService");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");

           
            modelBuilder.Entity<Subscription>()
                .HasKey(s => new { s.CustomerId, s.ServiceId });

           
            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Subscriptions)
                .HasForeignKey(s => s.CustomerId);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.FoodDeliveryService)
                .WithMany(f => f.Subscriptions)
                .HasForeignKey(s => s.ServiceId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

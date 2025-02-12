using System.Collections.Generic;
using System.Data.Entity;

namespace MotoVibe.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MotoVibeConnection")
        {
        }

        // Add DbSets for all models
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<MotorModel> MotorModels { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Motorbike> Motorbikes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Warranty> Warranties { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<MotorbikeImage> MotorbikeImages { get; set; }
    }
}
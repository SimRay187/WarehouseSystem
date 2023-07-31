using WarehouseSystem.Data.Models.Configuration;
using WarehouseSystem.Data.Models.Extensions;

namespace WarehouseSystem.Data
{
    
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using System.Reflection;
    using WarehouseSystem.Data.Models;

    public class WarehouseSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public WarehouseSystemDbContext(DbContextOptions<WarehouseSystemDbContext> options)
            : base(options)
        {
        }


        public DbSet<OrderProducts> OrderProducts = null!;

        public DbSet<Board> Boards { get; set; } = null!;

        public DbSet<Firm> Firms { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            Assembly configAssembly = Assembly.GetAssembly(typeof(WarehouseSystemDbContext)) ??
                Assembly.GetExecutingAssembly();
            builder.ApplyConfigurationsFromAssembly(configAssembly);



            builder.Entity<OrderProducts>()
                .HasKey(e => new { e.OrderId, e.ProductId });

            builder.ApplyMockData();

            base.OnModelCreating(builder);
        }


    }
}
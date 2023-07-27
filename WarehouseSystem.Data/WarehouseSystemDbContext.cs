namespace WarehouseSystem.Data
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using WarehouseSystem.Data.Models;

    public class WarehouseSystemDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public WarehouseSystemDbContext(DbContextOptions<WarehouseSystemDbContext> options)
            : base(options)
        {
        }
    }
}
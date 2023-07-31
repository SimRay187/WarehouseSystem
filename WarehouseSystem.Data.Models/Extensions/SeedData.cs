using Microsoft.EntityFrameworkCore;
using WarehouseSystem.Data.Models.Configuration;

namespace WarehouseSystem.Data.Models.Extensions;

public static class SeedData
{
    public static void ApplyMockData(this ModelBuilder builder)
    {
        builder.ApplyConfiguration(new BoardConfiguration());
    }
}
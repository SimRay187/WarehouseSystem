using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WarehouseSystem.Data.Models.Configuration;

public class BoardConfiguration : IEntityTypeConfiguration<Board>
{
    public void Configure(EntityTypeBuilder<Board> builder)
    {
        builder.HasData(GetAll());
    }

    private List<Board> GetAll()
        => new()
        {
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Available"
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "In Progress"
            },
            new ()
            {
                Id = Guid.NewGuid(),
                Name = "Completed Today"
            }
        };
}
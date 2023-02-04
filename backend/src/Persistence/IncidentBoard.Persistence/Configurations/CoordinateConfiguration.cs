using IncidentBoard.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IncidentBoard.Persistence.Configurations;
internal sealed class CoordinateConfiguration : IEntityTypeConfiguration<Coordinate>
{
    public void Configure(EntityTypeBuilder<Coordinate> builder)
    {
        builder.Property(x => x.Laitude).IsRequired(); //IsRequired - не сохраняет null
        builder.Property(x => x.Longitude).IsRequired();
    }
}

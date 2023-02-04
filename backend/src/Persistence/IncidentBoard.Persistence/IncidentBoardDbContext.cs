using IncidentBoard.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace IncidentBoard.Persistence;
public class IncidentBoardDbContext : DbContext
{
    public IncidentBoardDbContext(DbContextOptions<IncidentBoardDbContext> options) : base(options)
    {

    }

    public DbSet<Incident> Incidents { get; set; }
    public DbSet<Coordinate> Coordinates { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
         => builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
}


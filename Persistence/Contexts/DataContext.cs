using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Contexts;


public class DataContext : DbContext
{
    public DataContext() { }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<EventEntity> Events { get; set; }
    public DbSet<PackageEntity> Packages { get; set; }
    public DbSet<EventPackageEntity> EventPackages { get; set; }
}



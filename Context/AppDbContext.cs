using Microsoft.EntityFrameworkCore;

namespace AUTH.Backend.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // Register DbSets here
    // Example: public DbSet<Crud> Crud { get; set; }

}

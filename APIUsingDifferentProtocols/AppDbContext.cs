using Microsoft.EntityFrameworkCore;

namespace APIUsingDifferentProtocols;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Project> Projects { get; set; }
}

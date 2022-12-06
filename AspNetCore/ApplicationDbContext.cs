using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Project> Projects { get; set; } = null!;
    public DbSet<Team> Teams { get; set; } = null!;
    public DbSet<Hour> Hours { get; set; } = null!;
    public DbSet<Key> Key { get; set; } = null!;
  }
}
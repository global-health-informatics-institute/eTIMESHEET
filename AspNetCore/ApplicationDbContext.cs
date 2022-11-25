using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Hour> Hours { get; set; } = null!;
    public DbSet<Team> Teams { get; set; } = null!;
    public DbSet<Project> Projects { get; set; } =null!;
  }
}
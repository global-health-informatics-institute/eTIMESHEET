using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Hour> Hours { get; set; } = null!;
    public DbSet<ProjectTeam> ProjectTeams { get; set; } = null!;
    public DbSet<AddProject> AddProjects { get; set; } =null!;
  }
}
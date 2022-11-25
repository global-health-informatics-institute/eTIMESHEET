using System;

namespace AspNetCore
{
  public class ProjectTeam
  {
  public int Id { get; set; } 
  
  public AddProject AddProject { get; set; } =null!;
  public int AddProjectId { get; set; }
  public string? Member { get; set; }
  public DateOnly Start { get; set; }
  public DateOnly End { get; set; }
  
  }
}
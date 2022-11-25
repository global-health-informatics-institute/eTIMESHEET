using System;

namespace AspNetCore
{
  public class ProjectTeam
  {
  public int Id { get; set; } 
  public int AddProjectId { get; set; }
  public string? Member { get; set; }
  public DateOnly Start { get; set; }
  public DateOnly End { get; set; }
  
  }
}
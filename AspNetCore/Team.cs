using System;
using System.ComponentModel.DataAnnotations.Schema;
namespace AspNetCore
{
  public class Team
  {
  public int Id { get; set; } 
  // public string? Name { get; set; }
  public string? Member { get; set; }
  public DateOnly Start { get; set; }
  public DateOnly End { get; set; }
    // [ForeignKey("ProjectId")] 
  public int ProjectId { get; set; }
  // public Project Project { get; set; }
  }
}
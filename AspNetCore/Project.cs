using System;

namespace AspNetCore
{
  public class Project
  {
  public int Id { get; set; } 
  public string? Name { get; set; }
  public string? Coordinator { get; set; }
  public DateOnly Start { get; set; }
  public DateOnly End { get; set; }
  }
}
using System;

namespace AspNetCore
{
  public class Key
  {
  public int Id { get; set; } 
  public int ProjectId { get; set; }
  public string? Member { get; set; }
  public DateTime Start { get; set; }
  public DateTime End { get; set; }
  // public Project Project { get; set; }=null!;
  
  }
}
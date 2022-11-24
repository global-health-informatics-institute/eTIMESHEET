using System;

namespace AspNetCore
{
  public class Hour
  {
    public int Id { get; set; }
    public string? Task { get; set; }
    public float Hours { get; set; }
    public float Minutes { get; set; } 
    public  float Total { get; set; } 
  }
}
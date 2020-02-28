using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public string Name { get; set; }
    public static decimal Price { get; set; } = 5.00m;
    public Bread(string name)
    {
      Name = name;
    }
  }
}
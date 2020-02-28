using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public string Name { get; set; }
    public static decimal Price { get; set; } = 2.00m;
    public Pastry(string name)
    {
      Name = name;
    }

    public static decimal CalculatePastriesCost(int numberOfPastries)
    {

      int numberOfRegularPrice = numberOfPastries;

      return numberOfRegularPrice * Price;
    }
  }
}
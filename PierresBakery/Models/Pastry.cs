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
      int numberOfPastryDeals = 0;

      if (numberOfPastries % 3 == 0)
      {
        numberOfPastryDeals = (numberOfPastries / 3);
        numberOfRegularPrice = 0;
      }
      decimal costOfPastryDeals = numberOfPastryDeals * 5.00m;
      decimal costOfRegularPricePastries = numberOfRegularPrice * Price;
      return costOfPastryDeals + costOfRegularPricePastries;
    }
  }
}
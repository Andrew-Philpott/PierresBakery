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

      int numberOfRegularPricePastries = 0;
      int numberOfPastryDeals = 0;

      if (numberOfPastries % 3 == 0)
      {
        numberOfPastryDeals = (numberOfPastries / 3);
        numberOfRegularPricePastries = 0;
      }
      else
      {
        numberOfPastryDeals = (numberOfPastries / 3);
        numberOfRegularPricePastries = numberOfPastries % 3;
      }

      decimal costOfPastryDeals = numberOfPastryDeals * 5.00m;
      decimal costOfRegularPricePastries = numberOfRegularPricePastries * Price;
      return costOfPastryDeals + costOfRegularPricePastries;
    }
  }
}
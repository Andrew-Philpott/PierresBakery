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

    public static decimal CalculateLoaves(int numberOfLoaves)
    {
      int numberOfBreadDeals = 0;
      int numberOfRegularPriceBread = 0;
      if (numberOfLoaves % 3 == 0)
      {
        numberOfBreadDeals = (numberOfLoaves / 3);
      }
      else if (numberOfLoaves % 3 != 0)
      {
        numberOfBreadDeals = (numberOfLoaves / 3);
        numberOfRegularPriceBread = numberOfLoaves % 3;
      }
      else
      {
        numberOfRegularPriceBread = numberOfLoaves;
      }

      decimal costOfBreadDeals = numberOfBreadDeals * (2 * Price);
      decimal costOfRegularPriceBread = numberOfRegularPriceBread * Price;
      return costOfBreadDeals + costOfRegularPriceBread;
    }
  }
}
using System;

namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    new public static decimal PriceForOne { get; private set; }
    new public static decimal PriceForDeal { get; private set; }
    new public static int NumberOfBakedGoodsForDeal { get; private set; }
    new public static int NumberOfBakedGoodsFreeFromDeal { get; private set; }
    static Pastry()
    {
      PriceForOne = 2.00m;
      PriceForDeal = 2.5m * PriceForOne;
      NumberOfBakedGoodsForDeal = 3;
      NumberOfBakedGoodsFreeFromDeal = 0;
    }
    public Pastry(string name) : base(name)
    {

    }
    public static decimal CalculateCostForBakedGoods(int numberOfBakedGoods)
    {
      int numberOfBakedGoodsDeals = 0;
      int numberOfRegularPriceBakeGoods = 0;
      if (numberOfBakedGoods % ((NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal)) == 0)
      {
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }
      else
      {
        //Else the cost isequal to the number of baked goods deals + the remaining number of baked goods that are not part of the deal
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
        numberOfRegularPriceBakeGoods = numberOfBakedGoods % (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }

      decimal costOfBakedGoodsDeals = numberOfBakedGoodsDeals * PriceForDeal;
      decimal costOfRegularPricedBakedGood = numberOfRegularPriceBakeGoods * PriceForOne;
      return costOfBakedGoodsDeals + costOfRegularPricedBakedGood;
    }
  }
}
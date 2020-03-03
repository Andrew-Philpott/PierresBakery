namespace PierresBakery.Models
{
  public class Pastry : BakedGood
  {
    public static double PriceForOne { get; private set; }
    public static double PriceForDeal { get; private set; }
    public static int NumberOfBakedGoodsForDeal { get; private set; }
    public static int NumberOfBakedGoodsFreeFromDeal { get; private set; }
    static Pastry()
    {
      PriceForOne = 2.00;
      PriceForDeal = 2.5 * PriceForOne;
      NumberOfBakedGoodsForDeal = 3;
      NumberOfBakedGoodsFreeFromDeal = 0;
    }
    public Pastry(string name) : base(name)
    {

    }
    public static double CalculateCostForBakedGoods(int numberOfBakedGoods)
    {
      int numberOfBakedGoodsDeals = 0;
      int numberOfRegularPriceBakeGoods = 0;
      if (numberOfBakedGoods % ((NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal)) == 0)
      {
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }
      else
      {
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
        numberOfRegularPriceBakeGoods = numberOfBakedGoods % (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }

      double costOfBakedGoodsDeals = numberOfBakedGoodsDeals * PriceForDeal;
      double costOfRegularPricedBakedGood = numberOfRegularPriceBakeGoods * PriceForOne;
      return costOfBakedGoodsDeals + costOfRegularPricedBakedGood;
    }
  }
}
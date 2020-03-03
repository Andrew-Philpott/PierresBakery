namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    public static int BreadCount { get; set; }
    public static double PriceForOne { get; private set; }
    public static double PriceForDeal { get; private set; }
    public static int NumberOfBakedGoodsForDeal { get; private set; }
    public static int NumberOfBakedGoodsFreeFromDeal { get; private set; }
    static Bread()
    {
      PriceForOne = 5.00;
      PriceForDeal = 2 * PriceForOne;
      NumberOfBakedGoodsForDeal = 2;
      NumberOfBakedGoodsFreeFromDeal = 1;
    }
    public Bread(string name) : base(name)
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

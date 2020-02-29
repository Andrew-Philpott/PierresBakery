namespace PierresBakery.Models
{
  public class Bread : BakedGood
  {
    public static int BreadCount { get; set; }
    public static decimal PriceForOne { get; private set; }
    public static decimal PriceForDeal { get; private set; }
    public static int NumberOfBakedGoodsForDeal { get; private set; }
    public static int NumberOfBakedGoodsFreeFromDeal { get; private set; }
    static Bread()
    {
      PriceForOne = 5.00m;
      PriceForDeal = 2 * PriceForOne;
      NumberOfBakedGoodsForDeal = 2;
      NumberOfBakedGoodsFreeFromDeal = 1;
    }
    public Bread(string name) : base(name)
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
        numberOfBakedGoodsDeals = numberOfBakedGoods / (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
        numberOfRegularPriceBakeGoods = numberOfBakedGoods % (NumberOfBakedGoodsForDeal + NumberOfBakedGoodsFreeFromDeal);
      }

      decimal costOfBakedGoodsDeals = numberOfBakedGoodsDeals * PriceForDeal;
      decimal costOfRegularPricedBakedGood = numberOfRegularPriceBakeGoods * PriceForOne;
      return costOfBakedGoodsDeals + costOfRegularPricedBakedGood;
    }
  }
}

namespace PierresBakery.Models
{
  public abstract class BakedGood
  {
    public string Name { get; set; }
    protected static decimal PriceForOne { get; set; }
    protected static decimal PriceForDeal { get; set; }
    protected static int NumberOfBakedGoodsForDeal { get; set; }
    protected static int NumberOfBakedGoodsFreeFromDeal { get; set; }

    public BakedGood(string name)
    {
      Name = name;
    }
  }
}

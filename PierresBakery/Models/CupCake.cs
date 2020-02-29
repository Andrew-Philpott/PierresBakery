namespace PierresBakery.Models
{
  public class CupCake : Pastry
  {
    public static int Count { get; private set; } = 0;
    public CupCake(string name) : base(name)
    {
      Count++;
    }

    ~CupCake()
    {
      Count--;
    }
  }
}
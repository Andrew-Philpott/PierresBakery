namespace PierresBakery.Models
{
  public class Bagel : Bread
  {
    public static int Count { get; private set; } = 0;
    public Bagel(string name) : base(name)
    {
      Count++;
    }
  }
}
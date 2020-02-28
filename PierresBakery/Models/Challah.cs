namespace PierresBakery.Models
{
  public class Challah : Bread
  {
    public static int Count { get; private set; } = 0;
    public Challah(string name) : base(name)
    {
      Count++;
    }
  }
}
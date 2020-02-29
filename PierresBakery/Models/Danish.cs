namespace PierresBakery.Models
{
  public class Danish : Pastry
  {
    public static int Count { get; private set; } = 0;
    public Danish(string name) : base(name)
    {
      Count++;
    }

    ~Danish()
    {
      Count--;
    }
  }
}
using System;
using PierresBakery.Models;
public class Program
{

  public static void Main()
  {
    Console.WriteLine("Hi! Welcome to Pierres Bakery! The price of a loaf of bread is $" + (int)Bread.Price + " and a pastry is $" + (int)Pastry.Price);
    Console.ReadLine();
  }
}
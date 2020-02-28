using System;
using System.Collections.Generic;
using PierresBakery.Models;
public class Program
{
  Bread b = new Bread("Bread");
  Pastry p = new Pastry("Pastry");
  List<Bread> bread = new List<Bread>();
  List<Pastry> pastry = new List<Pastry>();
  public static void Main()
  {
    Console.WriteLine(Bread.PriceForOne);
    Console.WriteLine(Bread.PriceForDeal);
    Console.WriteLine("Hi! Welcome to Pierres Bakery! The price of a loaf of bread is $" + (int)Bread.PriceForOne + " and a pastry is $" + (int)Pastry.PriceForOne);
    Console.WriteLine("Buy 2 loaves of bread, get 1 free. Buy 3 pastries for $5");
    Console.WriteLine("How many loaves of bread would you like?");
    int numberOfLoavesOfBread = int.Parse(Console.ReadLine());
    decimal costOfBread = Bread.CalculateCostForBakedGoods(numberOfLoavesOfBread);
    Console.WriteLine("How many pastries would you like?");
    int numberOfPastries = int.Parse(Console.ReadLine());
    decimal costOfPastries = Pastry.CalculateCostForBakedGoods(numberOfLoavesOfBread);
    Console.WriteLine("The total cost of your order is: " + (costOfBread + costOfPastries));
    Console.ReadLine();
  }
}
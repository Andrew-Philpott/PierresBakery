using System;
using PierresBakery.Models;
public class Program
{

  public static void Main()
  {
    Console.WriteLine("Hi! Welcome to Pierres Bakery! The price of a loaf of bread is $" + (int)Bread.Price + " and a pastry is $" + (int)Pastry.Price);
    Console.WriteLine("Buy 2 loaves of bread, get 1 free. Buy 3 pastries for $5");
    Console.WriteLine("How many loaves of bread would you like?");
    int numberOfLoavesOfBread = int.Parse(Console.ReadLine());
    Console.WriteLine(Bread.CalculateLoavesCost(numberOfLoavesOfBread));
    Console.WriteLine("How many pastries would you like?");
    int numberOfPastries = int.Parse(Console.ReadLine());
    Console.WriteLine(Pastry.CalculatePastriesCost(numberOfPastries));
    Console.WriteLine("The total cost of your order is: ");
    Console.ReadLine();
  }
}
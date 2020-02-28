using System;
using System.Collections.Generic;
using PierresBakery.Models;
public class Program
{

  public static void BreadOption(List<Bread> bread, List<Pastry> pastries)
  {
    Console.WriteLine("What kind of bread would you like? ['bagel' for bagel, 'baguette' for baguette, or 'challah' for challah.");
    string breadType = Console.ReadLine();
    Console.WriteLine("How many " + breadType + "\'s would you like?");
    string breadAmountString = Console.ReadLine();
    int breadAmountInt = 0;
    bool result = int.TryParse(breadAmountString, out breadAmountInt);
    while (!result)
    {
      Console.WriteLine("I'm sorry, the value entered wasn't recognized. Please try again.");
      Console.WriteLine("How many " + breadType + "\'s would you like?");
      breadAmountString = Console.ReadLine();
      result = int.TryParse(breadAmountString, out breadAmountInt);
    }
    for (int i = 0; i < breadAmountInt; i++)
    {
      bread.Add(new Bread(breadType));
    }
    Console.WriteLine(bread.Count);
    Console.WriteLine("Okay, that's " + breadAmountInt + " " + breadType + "\'s added to your order.");
    ContinueShopping(bread, pastries);
  }

  public static void PastryOption(List<Bread> bread, List<Pastry> pastries)
  {
    Console.WriteLine("What kind of pastry would you like? ['bear claw' for bear claw, 'doughnut' for doughnut, or 'cup cake' for cup cake.");
    string pastryType = Console.ReadLine();
    Console.WriteLine("How many " + pastryType + "\'s would you like?");
    string pastryAmountString = Console.ReadLine();
    int pastryAmountInt = 0;
    bool result = int.TryParse(pastryAmountString, out pastryAmountInt);
    while (!result)
    {
      Console.WriteLine("I'm sorry, the value entered wasn't recognized. Please try again.");
      Console.WriteLine("How many " + pastryType + "\'s would you like?");
      pastryAmountString = Console.ReadLine();
      result = int.TryParse(pastryAmountString, out pastryAmountInt);
    }
    for (int i = 0; i < pastryAmountInt; i++)
    {
      pastries.Add(new Pastry(pastryType));
    }
    Console.WriteLine(pastries.Count);
    Console.WriteLine("Okay, that's " + pastryAmountInt + " " + pastryType + "\'s added to your order.");
    ContinueShopping(bread, pastries);
  }

  public static void ContinueShopping(List<Bread> bread, List<Pastry> pastries)
  {
    Console.WriteLine("What else can I get for you today? ['Bread' for bread, 'Pastry' for pastries, or 'Checkout' to review your order]");

    string breadOrPasty = Console.ReadLine();
    if (breadOrPasty == "Bread")
    {
      Program.BreadOption(bread, pastries);
    }
    else if (breadOrPasty == "Pastry")
    {
      Program.PastryOption(bread, pastries);
    }
    else if (breadOrPasty == "Checkout")
    {
      Checkout(bread, pastries);
    }
  }

  public static void Checkout(List<Bread> bread, List<Pastry> pastries)
  {
    // Console.WriteLine("How many loaves of bread would you like?");
    // int numberOfLoavesOfBread = int.Parse(Console.ReadLine());
    // decimal costOfBread = Bread.CalculateCostForBakedGoods(numberOfLoavesOfBread);
    // Console.WriteLine("How many pastries would you like?");
    // int numberOfPastries = int.Parse(Console.ReadLine());
    // decimal costOfPastries = Pastry.CalculateCostForBakedGoods(numberOfLoavesOfBread);
    // Console.WriteLine("The total cost of your order is: " + (costOfBread + costOfPastries));
    // Console.ReadLine();
  }
  public static void Main()
  {
    List<Bread> bread = new List<Bread>();
    List<Pastry> pastries = new List<Pastry>();

    Console.WriteLine(Bread.PriceForOne);
    Console.WriteLine(Bread.PriceForDeal);
    Console.WriteLine("Hi! Welcome to Pierres Bakery! The price of a loaf of bread is $" + (int)Bread.PriceForOne + " and a pastry is $" + (int)Pastry.PriceForOne);
    Console.WriteLine("Buy 2 loaves of bread, get 1 free. Buy 3 pastries for $5");
    Console.WriteLine("What would you like today? ['Bread' for bread, 'Pastry' for pastries");
    string breadOrPasty = Console.ReadLine();
    if (breadOrPasty == "Bread")
    {
      Program.BreadOption(bread, pastries);
    }
    else if (breadOrPasty == "Pastry")
    {
      Program.PastryOption(bread, pastries);
    }
    Program.ContinueShopping(bread, pastries);
  }
}

using System;
using System.Collections.Generic;
using PierresBakery.Models;
public class Program
{

  public static void BreadOption(List<Bread> bread, List<Pastry> pastries)
  {
    Console.WriteLine("What kind of bread would you like? ['bagel' for bagel, 'baguette' for baguette, or 'challah' for challah.");
    string breadType = Console.ReadLine();
    while ((breadType != "bagel") && (breadType != "baguette") && (breadType != "challah"))
    {
      Console.WriteLine("I'm sorry, the bread entered wasn't recognized.");
      Console.WriteLine("What kind of bread would you like? ['bagel' for bagel, 'baguette' for baguette, or 'challah' for challah.");
      breadType = Console.ReadLine();
    }
    Console.WriteLine("How many " + breadType + "\'s would you like?");
    string breadAmountString = Console.ReadLine();
    int breadAmountInt = 0;
    bool result = int.TryParse(breadAmountString, out breadAmountInt);
    while (!result)
    {
      Console.WriteLine("I'm sorry, the number value entered wasn't recognized. Please try again.");
      Console.WriteLine("How many " + breadType + "\'s would you like?");
      breadAmountString = Console.ReadLine();
      result = int.TryParse(breadAmountString, out breadAmountInt);
    }
    switch (breadType)
    {
      case "baguette":
        for (int i = 0; i < breadAmountInt; i++)
        {
          Bread b = new Baguette("Baguette");
          bread.Add(b);
        }
        break;
      case "challah":
        for (int i = 0; i < breadAmountInt; i++)
        {
          Bread b = new Challah("Challah");
          bread.Add(b);
        }
        break;
      case "bagel":
        for (int i = 0; i < breadAmountInt; i++)
        {
          Bread b = new Bagel("Bagel");
          bread.Add(b);
        }
        break;
      default:
        break;
    }
    Console.WriteLine(bread.Count);
    Console.WriteLine("Okay, that's " + breadAmountInt + " " + breadType + "\'s added to your order.");
    ContinueShopping(bread, pastries);
  }

  public static void PastryOption(List<Bread> bread, List<Pastry> pastries)
  {
    Console.WriteLine("What kind of pastry would you like? ['bear claw' for bear claw, 'danish' for danish, or 'cup cake' for cup cake.");
    string pastryType = Console.ReadLine();
    while ((pastryType != "bear claw") && (pastryType != "danish") && (pastryType != "cup cake"))
    {
      Console.WriteLine("I'm sorry, the pastry entered wasn't recognized.");
      Console.WriteLine("What kind of pastry would you like? ['bear claw' for bear claw, 'danish' for danish, or 'cup cake' for cup cake.");
      pastryType = Console.ReadLine();
    }
    Console.WriteLine("How many " + pastryType + "\'s would you like?");
    string pastryAmountString = Console.ReadLine();
    int pastryAmountInt = 0;
    bool result = int.TryParse(pastryAmountString, out pastryAmountInt);
    while (!result)
    {
      Console.WriteLine("I'm sorry, the number value entered wasn't recognized. Please try again.");
      Console.WriteLine("How many " + pastryType + "\'s would you like?");
      pastryAmountString = Console.ReadLine();
      result = int.TryParse(pastryAmountString, out pastryAmountInt);
    }
    switch (pastryType)
    {
      case "bear claw":
        for (int i = 0; i < pastryAmountInt; i++)
        {
          Pastry p = new BearClaw("Bear Claw");
          pastries.Add(p);
        }
        break;
      case "cup cake":
        for (int i = 0; i < pastryAmountInt; i++)
        {
          Pastry p = new CupCake("Cup Cake");
          pastries.Add(p);
        }
        break;
      case "danish":
        for (int i = 0; i < pastryAmountInt; i++)
        {
          Pastry p = new Danish("Danish");
          pastries.Add(p);
        }
        break;
      default:
        break;
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
    Console.WriteLine("Okay here's what you ordered.");
    if (pastries.Count != 0)
    {
      Console.WriteLine("Pastries");
      if (BearClaw.Count != 0)
      {
        Console.WriteLine("Bear Claws: " + BearClaw.Count);
      }
      if (Danish.Count != 0)
      {
        Console.WriteLine("Danishes: " + Danish.Count);
      }
      if (CupCake.Count != 0)
      {
        Console.WriteLine("Cupcakes: " + CupCake.Count);
      }
    }
    if (bread.Count != 0)
    {
      Console.WriteLine("Bread");
      if (Baguette.Count != 0)
      {
        Console.WriteLine("Baguettes " + Baguette.Count);
      }
      if (Challah.Count != 0)
      {
        Console.WriteLine("Challah: " + Challah.Count);
      }
      if (Bagel.Count != 0)
      {
        Console.WriteLine("Bagels: " + Bagel.Count);
      }
    }
    decimal totalBeforeTax = 0;
    totalBeforeTax += Bread.CalculateCostForBakedGoods(bread.Count);
    totalBeforeTax += Pastry.CalculateCostForBakedGoods(pastries.Count);
    Console.WriteLine("Your order comes to:");
    Console.WriteLine("Before tax: " + String.Format("{0:C}", totalBeforeTax));
    decimal totalAfterTax = totalBeforeTax + (totalBeforeTax * 0.065m);
    Console.WriteLine("After tax: " + String.Format("{0:C}", totalAfterTax));
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
  }
}

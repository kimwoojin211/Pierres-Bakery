/*
changing Price methods back to static

*/
using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("\\o/ \\o/ Welcome to Pierre's Bakery! \\o/ \\o/");
      Console.WriteLine("      These are our prices for today.");
      Console.WriteLine("");
      Console.WriteLine("SUPERDEALSUPERDEALSUPERDEALSUPERDEALSUPERDEAL");
      Console.WriteLine("SUPERDEAL                           SUPERDEAL");
      Console.WriteLine("SUPERDEAL     Bread: $5 a Loaf      SUPERDEAL");
      Console.WriteLine("SUPERDEAL    Buy 2, Get 1 Free!     SUPERDEAL");
      Console.WriteLine("SUPERDEAL                           SUPERDEAL");
      Console.WriteLine("SUPERDEAL   Pastries: 1 for $2      SUPERDEAL");
      Console.WriteLine("SUPERDEAL             3 for $5      SUPERDEAL");
      Console.WriteLine("SUPERDEAL                           SUPERDEAL");
      Console.WriteLine("SUPERDEALSUPERDEALSUPERDEALSUPERDEALSUPERDEAL");
      Console.WriteLine("");

      int breadAmount = -1, pastryAmount = -1;
      Console.WriteLine("Please enter the number of loaves of bread you would like. (Positive integers only.)");
      while(breadAmount < 0)
      {
        breadAmount = BakedGood.NumberOf(Console.ReadLine());
      }
      Console.WriteLine("Please enter the number of pastries you would like. (Positive integers only.)");
      while(pastryAmount < 0)
      {
        pastryAmount = BakedGood.NumberOf(Console.ReadLine());
      }
      Bread bread = new Bread(breadAmount);
      Pastry pastry = new Pastry(pastryAmount);
      int totalBreadPrice = bread.Price();
      int totalPastryPrice = pastry.Price();

      Console.WriteLine($"Your total amount is ${totalBreadPrice + totalPastryPrice}");
    }
  }
}
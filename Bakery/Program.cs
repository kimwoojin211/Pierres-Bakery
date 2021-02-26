/*
*/
using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      // int loaves = 0; int pastries = 0;
      Console.WriteLine("");
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

      // Bread bread = new Bread();
      // Pastry pastry = new Pastry();
      Console.WriteLine("Please enter the number of loaves of bread you would like. (Positive integers only.)");
      int totalBreadPrice = -1;
      while(totalBreadPrice<0)
      {
        totalBreadPrice = Bread.Price(Console.ReadLine());
      }
      Console.WriteLine("Please enter the number of pastries you would like. (Positive integers only.)");
      int totalPastryPrice = -1;
      while(totalPastryPrice<0)
      {
        totalPastryPrice = Pastry.Price(Console.ReadLine());
      };
      Console.WriteLine($"Your total amount is ${totalBreadPrice + totalPastryPrice}");
    }
  }
}
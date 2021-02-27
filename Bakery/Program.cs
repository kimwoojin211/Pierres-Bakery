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
      Console.WriteLine("SUPERDEAL    Any 5 Items:  -$2!     SUPERDEAL");
      Console.WriteLine("SUPERDEAL                           SUPERDEAL");
      Console.WriteLine("SUPERDEALSUPERDEALSUPERDEALSUPERDEALSUPERDEAL");
      Console.WriteLine("");

      int breadAmount, pastryAmount;
      int totalBreadAmount = 0, totalPastryAmount = 0;
      string choice = "";
      while(choice != "TOTAL")
      {
        Console.WriteLine("Enter \"Bread\" or \"Pastry\" (Case Insensitive), or enter \"Total\" to calculate the total cost of your order)");
        choice = Console.ReadLine().ToUpper();
        switch(choice)
        {
          case "BREAD":
            breadAmount = -1;
            Console.WriteLine("Please enter the number of loaves of bread you would like. (Positive integers only.)");
            while(breadAmount < 0)
            {
              breadAmount = BakedGood.NumberOf(Console.ReadLine());
            }
            totalBreadAmount += breadAmount;
            break;
          case "PASTRY":
            pastryAmount = -1;
            Console.WriteLine("Please enter the number of pastries you would like. (Positive integers only.)");
            while(pastryAmount < 0)
            {
              pastryAmount = BakedGood.NumberOf(Console.ReadLine());
            }
            totalPastryAmount += pastryAmount;
            break;
          case "TOTAL":
            break;
          default:
            Console.WriteLine("Invalid selection. Please enter Bread, Pastry, or Total.");
            break;
        }
      }
      Bread bread = new Bread(totalBreadAmount);
      Pastry pastry = new Pastry(totalPastryAmount);
      int totalBreadPrice = bread.Price();
      int totalPastryPrice = pastry.Price();
      int fiveForThree = 2*((totalBreadAmount+totalPastryAmount)/5);
      Console.WriteLine($"Your total of {totalBreadAmount} loaves and {totalPastryAmount} pastries comes out to ${totalBreadPrice + totalPastryPrice - fiveForThree}");
    }
  }
}
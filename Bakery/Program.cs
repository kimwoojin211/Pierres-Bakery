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
      string input = "";
      while(input != "TOTAL") // allows user to select and add more bread or pastries until "total" is entered into the terminal;
      {
        Console.WriteLine("Enter \"Bread\" or \"Pastry\" (case insensitive) to purchase your desired baked good, or enter \"Total\" to calculate the total cost of your order)");
        input = Console.ReadLine().ToUpper();
        switch(input)
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
      //Total bread and pastry amounts are determined. Determine total price.
      Bread bread = new Bread(totalBreadAmount);
      Pastry pastry = new Pastry(totalPastryAmount);
      int fiveForThree = 2*((totalBreadAmount+totalPastryAmount)/5);
      Console.WriteLine($"Your total of {totalBreadAmount} loaves and {totalPastryAmount} pastries comes out to ${bread.Price() + pastry.Price() - fiveForThree}");
    }
  }
}
/*
moving checkAmount to models cs files. Program doesn't like having methods not Main() :(
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

      Bread bread = new Bread();
      Pastry pastry = new Pastry();
      // loaves = Bread.CheckAmount("loaves");
      // pastries = Pastry.CheckAmount("pastries");
      int total = bread.Price() + pastry.Price();
      Console.WriteLine($"Your total amount is ${total}");
    }

    // private static int checkAmount(String object)
    // {
    //   int amount = 0;
    //   Console.WriteLine($"Please enter the number of ${object} you would like.");
    //   try
    //   {
    //     amount = Int32.Parse(Console.ReadLine());
    //     if(amount < 0)
    //     {
    //       throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
    //     }
    //     return amount;
    //   }
    //   catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
    //   {
    //     Console.WriteLine("Non-integer detected. Please enter a positive integer.");
    //     checkAmount(object);
    //   }
    //   catch(OverflowException)
    //   {
    //     Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647");
    //     checkAmount(object);
    //   }
    //   catch (ArgumentException ex)
    //   {
    //     Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
    //     checkAmount(object);
    //   }
    // }
  }
}
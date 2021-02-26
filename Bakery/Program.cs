using System;

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
      Console.WriteLine("Please enter the number of loaves you would like.");
      try
      {
        int loaves = Int32.Parse(Console.ReadLine());
        if(loaves < 0)
        {
          throw new Exception("Negative amount"); // inspo from https://www.dotnetperls.com/throw
        }
      }
      catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
      {
          Console.WriteLine("Non-integer detected. Please enter a positive integer.");
          Console.WriteLine("");
      }

    }
  }

}
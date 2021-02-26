
/*
Changing Price method to amount method. going to add another Price method, but make it abstract.
*/
using System;
namespace Bakery.Models
{
  public abstract class BakedGood
  {
    public abstract int Price();
    public static int NumberOf(string input)
    {
      int num = -1;
      try
      {
        num = Int32.Parse(input);
        if (num < 0)
        {
          throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
        }
      }
      catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
      {
        Console.WriteLine("Non-integer detected. Please enter a positive integer.");
      }
      catch (OverflowException)
      {
        Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647).");
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
      }
      return num;
    }
  }
}
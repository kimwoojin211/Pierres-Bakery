/*
*/
using System;
namespace Bakery.Models
{
  public abstract class BakedGood
  {
    public abstract int Price(); // require all baked goods to have their own declared Price method.
    public static int NumberOf(string input) // determines a number from user's input, helps filter out any non-number, non-integer, and non-positive inputs
    {
      int num = -1;
      try
      {
        if (Int32.Parse(input) < 0) // valid number integer, but negative
        {
          throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
        }
        num = Int32.Parse(input);
      }
      // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
      catch (FormatException) // if a non-number or non-integer is given as input
      {
        Console.WriteLine("Non-integer detected. Please enter a positive integer.");
      }
      catch (OverflowException) // if number larger than int range given as input
      {
        Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647).");
      }
      catch (ArgumentException ex) // if negative number given as input
      {
        Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
      }
      return num;
    }
  }
}
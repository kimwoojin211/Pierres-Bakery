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
        if (Int32.Parse(input) < 0)
        {
          throw new ArgumentException("Negative amount detected. Please enter a positive integer."); 
        }
        num = Int32.Parse(input);
      }
      
      catch (FormatException) 
      {
        Console.WriteLine("Non-integer detected. Please enter a positive integer.");
      }
      catch (OverflowException) 
      {
        Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647).");
      }
      catch (ArgumentException ex) 
      {
        Console.WriteLine(ex.Message);
      }
      return num;
    }
  }
}
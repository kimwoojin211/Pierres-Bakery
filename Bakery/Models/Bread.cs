using System;
/*
sike. no more recursion in here. probably shouldn't have had ReadLine in here in the first place.
*/
namespace Bakery.Models
{
  public class Bread
  {
    public Bread()
    {
    }

    public int Price(string input)
    {
      int amount = -1;
      try
      {
        amount = Int32.Parse(input);
        if(amount < 0)
        {
          throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
        }
      }
      catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
      {
        Console.WriteLine("Non-integer detected. Please enter a positive integer.");
        return amount; 
      }
      catch(OverflowException)
      {
        Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647");
        return amount;
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
        return amount;
      }

      return 5*amount - 5*(amount/3);
    }
    
    // private int askAmount(string input) // can't use object as a variable name
    // {
    //   int amount = -1;
    //   try
    //   {
    //     amount = Int32.Parse(input);
    //     if(amount < 0)
    //     {
    //       throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
    //     }
    //   }
    //   catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
    //   {
    //     Console.WriteLine("Non-integer detected. Please enter a positive integer."); // basically a recursion call. therefore, it was finishing the rest of the code once it got a proper integer, and amount was still being run as 0. so fix was to set amount to the recursion call so at the very end, it'll always have something to return inside amount.
    //   }
    //   catch(OverflowException)
    //   {
    //     Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647");
    //   }
    //   catch (ArgumentException ex)
    //   {
    //     Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
    //   }
    //   return amount;
    // }
  }
}
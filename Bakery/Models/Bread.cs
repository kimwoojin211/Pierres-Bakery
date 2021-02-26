using System;
/*
askAmount()-
Invalid input bug: If an invalid input was given by the user, then even after the user puts in a correct integer value, the program wouldn't remember the value, and calculate either baked good's price at 0.
Solution: When recursively calling the method, make sure to set amount to the value of askAmount, so when it runs into an invalid input, it remembers to change the value of amount once it does get a valid input.
*/
namespace Bakery.Models
{
  public class Bread
  {
    public Bread()
    {
    }

    public int Price()
    {
      int amount = askAmount();
      return 5*amount - 5*(amount/3);
    }
    
    private int askAmount() // can't use object as a variable name
    {
      int amount = 0;
      Console.WriteLine("Please enter the number of loaves of bread you would like. (Positive integers only.)");
      try
      {
        amount = Int32.Parse(Console.ReadLine());
        if(amount < 0)
        {
          throw new ArgumentException("Negative amount detected. Please enter a positive integer."); // inspo from https://www.dotnetperls.com/throw && https://www.tutorialsteacher.com/csharp/csharp-exception
        }
      }
      catch (FormatException) // inspo from https://docs.microsoft.com/en-us/dotnet/api/system.int32.parse?view=net-5.0
      {
        Console.WriteLine("Non-integer detected. Please enter a positive integer.");
        amount = askAmount(); // basically a recursion call. therefore, it was finishing the rest of the code once it got a proper integer, and amount was still being run as 0. so fix was to set amount to the recursion call so at the very end, it'll always have something to return inside amount.
      }
      catch(OverflowException)
      {
        Console.WriteLine("Overflow detected. Please enter a smaller positive integer (<=2,147,483,647");
        amount = askAmount();
      }
      catch (ArgumentException ex)
      {
        Console.WriteLine(ex.Message); // https://docs.microsoft.com/en-us/dotnet/api/system.argumentexception.message?view=netframework-4.8#System_ArgumentException_Message
        amount = askAmount();
      }
      return amount;
    }
  }
}
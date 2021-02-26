using System;
/*

*/
namespace Bakery.Models
{
  public class Pastry
  {
    public Pastry()
    {
    }

    public int Price()
    {
      int amount = askAmount();
      return 5*(amount/3) + 2*(amount%3);
    }

    private int askAmount() // can't use object as a variable name
    {
      int amount = 0;
      Console.WriteLine("Please enter the number of pastries you would like. (Positive integers only.)");
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
        amount = askAmount();
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
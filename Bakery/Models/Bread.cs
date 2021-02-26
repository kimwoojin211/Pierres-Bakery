/*
SO CLEANNNNNNNNNNNNN
*/
namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    public Bread()
    {
    }

    public override int Price(string input)
    {
      int amount = base.Price(input);      
      return amount>0 ? (5*amount - 5*(amount/3)) : amount;
    }
  }
}
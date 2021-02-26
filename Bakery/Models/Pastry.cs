/*
SO CLEANNNNNNNNNNNNNNNNNNNNNNN
*/
namespace Bakery.Models
{
  public class Pastry : BakedGood
  {
    public Pastry()
    {
    }

    public override int Price(string input)
    {      
      int amount = base.Price(input);
      return amount>0 ?  5*(amount/3) + 2*(amount%3) : amount;
    }

  }
}
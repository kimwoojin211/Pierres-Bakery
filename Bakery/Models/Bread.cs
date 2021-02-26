/*
ternary operator no longer needed because all negative inputs should be filtered through BakedGood's NumberOf method.
*/
namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    public int Amount { get; set; }
    
    public Bread(int input)
    {
      Amount = input;      
    }

    public override int Price()
    {
      return 5*Amount - 5*(Amount/3);
    }
  }
}
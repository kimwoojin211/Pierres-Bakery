/*
*/
namespace Bakery.Models
{
  public class Bread : BakedGood
  {
    public int Amount { get; set; }
    
    public Bread(int input)
    {
      Amount = input; // negatives already filtered
    }

    public override int Price()
    {
      // $5, buy 2 get 1 free
      return 5*Amount - 5*(Amount/3);
    }
  }
}
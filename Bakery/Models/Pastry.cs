/*
*/
namespace Bakery.Models
{
  public class Pastry : BakedGood
  {
    public int Amount { get; set; }

    public Pastry(int input)
    {
      Amount = input; // negatives already filtered
    }
    // 1 for $2, 2 for $3
    public override int Price()
    {
      return 5*(Amount/3) + 2*(Amount%3);
    }

  }
}
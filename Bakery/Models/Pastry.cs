namespace Bakery.Models
{
  public class Pastry : BakedGood
  {
    public int Amount { get; set; }

    public Pastry(int input)
    {
      Amount = input;
    }
    
    public override int Price()
    {
      return 5*(Amount/3) + 2*(Amount%3);
    }

  }
}
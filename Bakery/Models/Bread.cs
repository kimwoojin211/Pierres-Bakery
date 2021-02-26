/*
i need auto-implemented properties

changing Price methods from virtual/overridden to static because i'm no longer calling Bakedgood's method price, since it's not finding the price anymore, it's just checking for a valid amount input.
so I'm losing the overriding feature for price, but now i'll be able to use static, and get rid of the Bread and Pastry objects in Program.cs
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
      return Amount>0 ? (5*Amount - 5*(Amount/3)) : Amount;
    }
  }
}
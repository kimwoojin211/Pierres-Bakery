/*

*/
namespace Bakery.Models
{
  public class Pastry
  {
    public Pastry()
    {

    }

  public int Price(int amount)
    {
      return 5*(amount/3) + 2*(amount%3);
    }
  }
}
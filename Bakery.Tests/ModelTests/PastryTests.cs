using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {

      Pastry NewPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), NewPastry.GetType());
    }
  }
}
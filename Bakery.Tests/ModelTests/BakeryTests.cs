/*
uhh. is this allowed? to just have one test file? or do we need to have one test file per cs file.
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread NewBread = new Bread();
      Assert.AreEqual(typeof(Bread), NewBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {

      Pastry NewPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), NewPastry.GetType());
    }


    [TestMethod]
    public void BreadPrice_ReturnsBreadPrice_Int()
    {
      Bread NewBread = new Bread();
      int price = NewBread.Price(4); // only dollars, so only ints needed. no decimals.
      Assert.AreEqual(price, 15);
    }
    [TestMethod]
    public void PastryPrice_ReturnsPastryPrice_Int()
    {
      Pastry NewPastry = new Pastry();
      int price = NewPastry.Price(4); // only dollars, so only ints needed. no decimals.
      Assert.AreEqual(price, 15);
    }
  }
}
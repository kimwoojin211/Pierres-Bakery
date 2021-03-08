using System;
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

      Pastry NewPastry = new Pastry(255);
      Assert.AreEqual(typeof(Pastry), NewPastry.GetType());
    }
    [TestMethod]
    public void PastryPrice_ReturnsPastryPrice_Int()
    {
      Pastry NewPastry = new Pastry(1);
      int price = NewPastry.Price();
      Assert.AreEqual(2, price);
    }
    [TestMethod]
    public void PastryPrice_ReturnsDiscountedPastryPrice_Int()
    {
      Pastry NewPastry = new Pastry(3);
      int price = NewPastry.Price(); 
      Assert.AreEqual(5,price);
    }
  }
}
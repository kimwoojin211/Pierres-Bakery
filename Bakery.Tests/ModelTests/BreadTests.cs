using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread NewBread = new Bread(4);
      Assert.AreEqual(typeof(Bread), NewBread.GetType());
    }
    [TestMethod]
    public void BreadPrice_ReturnsBreadPrice_Int()
    {
      Bread NewBread = new Bread(2);
      int price = NewBread.Price();
      Assert.AreEqual(10, price);
    }
    [TestMethod]
    public void BreadPrice_ReturnsDiscountedBreadPrice_Int()
    {
      Bread NewBread = new Bread(23);
      int price = NewBread.Price();
      Assert.AreEqual(80,price);
    }
  }
}
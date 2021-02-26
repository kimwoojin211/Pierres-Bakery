/*
need to delete all the Bread and Pastry constructors now that price is a static method.
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
      int price = Bread.Price("23"); // only dollars, so only ints needed. no decimals.
      Assert.AreEqual(80,price);
    }

    [TestMethod]
    public void BreadPrice_ReturnsNegativeOneOnInvalidInput_Int()
    {
      int price = Bread.Price("abc");
      Assert.AreEqual(-1, price);
    }
    [TestMethod]
    public void PastryPrice_ReturnsPastryPrice_Int()
    {
      int price = Pastry.Price("4"); // only dollars, so only ints needed. no decimals.
      Assert.AreEqual(7,price);
    }
    [TestMethod]
    public void PastryPrice_ReturnsNegativeOneOnInvalidInput_Int()
    {
      int price = Pastry.Price("-153"); // only dollars, so only ints needed. no decimals.
      Assert.AreEqual(-153, price);
    }
  }
}
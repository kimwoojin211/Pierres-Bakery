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
      Bread NewBread = new Bread(4);
      Assert.AreEqual(typeof(Bread), NewBread.GetType());
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {

      Pastry NewPastry = new Pastry(255);
      Assert.AreEqual(typeof(Pastry), NewPastry.GetType());
    }


    [TestMethod]
    public void BreadPrice_ReturnsBreadPrice_Int()
    {
      Bread NewBread = new Bread(23);
      int price = NewBread.Price();
      Assert.AreEqual(80,price);
    }

    [TestMethod]
    public void BreadPrice_ReturnsNegativeOneOnInvalidInput_Int()
    {
      Bread NewBread = new Bread(-4);
      int price = NewBread.Price();
      Assert.AreEqual(-4, price);
    }
    [TestMethod]
    public void PastryPrice_ReturnsPastryPrice_Int()
    {
      Pastry NewPastry = new Pastry(4);
      int price = NewPastry.Price(); 
      Assert.AreEqual(7,price);
    }
    [TestMethod]
    public void PastryPrice_ReturnsNegativeOneOnInvalidInput_Int()
    {
      Pastry NewPastry = new Pastry(-153);
      int price = NewPastry.Price();
      Assert.AreEqual(-153, price);
    }
  }
}
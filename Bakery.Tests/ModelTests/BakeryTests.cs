/*
need to add BakedGoods tests
deleting negative price tests because price methods can no longer receive negative inputs (filtered by BakedGood.NumberOf))
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
    public void PastryPrice_ReturnsPastryPrice_Int()
    {
      Pastry NewPastry = new Pastry(4);
      int price = NewPastry.Price(); 
      Assert.AreEqual(7,price);
    }
    [TestMethod]
    public void BakedGoodAmount_ReturnsArgIfPositiveInteger_Int()
    {
      int price = BakedGood.NumberOf(3888);
      Assert.AreEqual(3888, price);
    }
    [TestMethod]
    public void BakedGoodAmount_ReturnsNegativeOnNegativeInt_Int()
    {
      int price = BakedGood.NumberOf(-153);
      Assert.AreEqual(-153, price);
    }
    [TestMethod]
    public void BakedGoodAmount_ReturnsNegativeOneOnNonInteger_Int()
    {
      int price = BakedGood.NumberOf(35.23353);
      Assert.AreEqual(-1, price);
    }

    [TestMethod]
    public void BakedGoodAmount_ReturnsNegativeOneOnInvalidString_Int()
    {
      int price = BakedGood.NumberOf("hello Epicodus Staff");
      Assert.AreEqual(-1, price);
    }
  }
}
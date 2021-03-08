using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakedGoodTests
  {
    [TestMethod]
    public void BakedGoodAmount_ReturnsArgIfPositiveInteger_Int()
    {
      int price = BakedGood.NumberOf("3888");
      Assert.AreEqual(3888, price);
    }
    [TestMethod]
    public void BakedGoodAmount_ReturnsNegativeOneOnNegativeInt_Int()
    {
      int price = BakedGood.NumberOf("-153");
      Assert.AreEqual(-1, price);
    }
    [TestMethod]
    public void BakedGoodAmount_ReturnsNegativeOneOnNonInteger_Int()
    {
      int price = BakedGood.NumberOf("35.23353");
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
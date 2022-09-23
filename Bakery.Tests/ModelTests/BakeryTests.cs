using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests 
  {
    [TestMethod]
    public void BakeryConstructor_CreatesInstanceOfBakery_Constructor()
    {
      BakeryShop bakeryShop = new BakeryShop(1, 1);
      Assert.AreEqual(typeof(BakeryShop), bakeryShop.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsCost_Int()
    {
      int bread = 2;
      int pastry = 1;
      BakeryShop bakeryShop = new BakeryShop(bread, pastry);
       int totalBread = bakeryShop.Bread;
      int totalPastry = bakeryShop.Pastry;
      int total = totalBread + totalPastry;
      Assert.AreEqual(total, 3);
    }
  }
}
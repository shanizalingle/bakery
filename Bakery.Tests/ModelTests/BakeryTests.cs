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
    public void GetItem_ReturnsItems_Int()
    {
      int bread = 2;
      int pastry = 1;
      BakeryShop bakeryShop = new BakeryShop(bread, pastry);
      int totalBread = bakeryShop.Bread;
      int totalPastry = bakeryShop.Pastry;
      int total = totalBread + totalPastry;
      Assert.AreEqual(total, 3);
    }

    [TestMethod]
    public void GetItem_ReturnsItemCost_Int()
    {
      int bread = 10;
      int pastry = 10;
      BakeryShop bakeryShop = new BakeryShop(bread, pastry);
      int breadCost = bakeryShop.GetBreadCost(bread);
      int pastryCost = bakeryShop.GetPastryCost(pastry);
      int totalCost = breadCost + pastryCost;
      Assert.AreEqual(totalCost, 52);
    }
  }
}
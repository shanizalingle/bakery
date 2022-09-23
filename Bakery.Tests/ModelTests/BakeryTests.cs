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
      BakeryShop newBakery = new BakeryShop(1, 1);
      Assert.AreEqual(typeof(BakeryShop), newBakery.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsCost_Int()
    {
      int breadCost = 5;
      int pastryCost = 2;
      BakeryShop newBakery = new BakeryShop(breadCost, pastryCost);
       int totalBread = newBakery.BreadCost;
      int totalPastry = newBakery.PastryCost;
      int total = totalBread + totalPastry;
      Assert.AreEqual(total, 7);
    }
  }
}
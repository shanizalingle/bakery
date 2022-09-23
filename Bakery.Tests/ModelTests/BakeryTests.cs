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
      BakeryShop newBakery = new BakeryShop();
      Assert.AreEqual(typeof(BakeryShop), newBakery.GetType());
    }
  }
}
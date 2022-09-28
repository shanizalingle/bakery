using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GetBreadTests 
  {
    [TestMethod]
    public void GetBreadConstructor_CreatesInstanceOfGetBread_Constructor()
    {
      GetBread getBread = new GetBread(1);
      Assert.AreEqual(typeof(GetBread), getBread.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsItems_Int()
    {
      int bread = 2;
      GetBread getBread = new GetBread(bread);
      int totalBread = getBread.Bread;
      Assert.AreEqual(totalBread, 2);
    }

    [TestMethod]
    public void GetItem_ReturnsItemCost_Int()
    {
      int bread = 10;
      GetBread getBread = new GetBread(bread);
      int breadCost = getBread.GetBreadCost(bread);
      Assert.AreEqual(breadCost, 35);
    }
  }
}
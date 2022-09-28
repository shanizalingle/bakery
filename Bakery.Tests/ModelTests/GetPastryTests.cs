using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class GetPastryTests 
  {
    [TestMethod]
    public void GetPastryConstructor_CreatesInstanceOfGetPastry_Constructor()
    {
      GetPastry getPastry = new GetPastry(1);
      Assert.AreEqual(typeof(GetPastry), getPastry.GetType());
    }

    [TestMethod]
    public void GetItem_ReturnsItems_Int()
    {
      int pastry = 5;
      GetPastry getPastry = new GetPastry(pastry);
      int totalPastry = getPastry.pastry;
      Assert.AreEqual(totalPastry, 5;
    }

    [TestMethod]
    public void GetItem_ReturnsItemCost_Int()
    {
      int pastry = 1;
      GetPastry getPastry = new GetPastry(pastry);
      int pastryCost = getPastry.GetPastryCost(pastry);
      Assert.AreEqual(pastryCost, 2);
    }
  }
}
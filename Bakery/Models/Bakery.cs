using System;

namespace Bakery.Models
{
  public class BakeryShop
  {
    public int Bread { get; set; }

    public int Pastry { get; set; }

    public BakeryShop (int bread, int pastry)
    {
      Bread = bread;
      Pastry = pastry;
    }

    public int GetBreadCost(int bread)
    {
      return Bread;
    }

    public int GetPastryCost(int pastry)
    {
      return Pastry;
    }
  }
}
using System;

namespace Bakery.Models
{
  public class BakeryShop
  {
    public int BreadCost { get; set; }

    public int PastryCost { get; set; }

    public BakeryShop (int breadCost, int pastryCost)
    {
      BreadCost = breadCost;
      PastryCost = pastryCost;
    }

    public int GetBreadCost(int breadCost)
    {
      return BreadCost;
    }

    public int GetPastryCost(int pastryCost)
    {
      return PastryCost;
    }
  }
}
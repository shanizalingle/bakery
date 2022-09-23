using System;

namespace Bakery.Models
{
  public class BakeryShop
  {
    public int BreadCost { get; set; }

    public int PastryCost { get; set; }

    public int BakeryItems(int breadCost, int pastryCost)
    {
      BreadCost = breadCost;
      PastryCost = pastryCost;
      return breadCost;
      return pastryCost;
    }

  }
}
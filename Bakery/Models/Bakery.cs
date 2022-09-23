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
      int breadCost = 0;

      if (Bread % 3 == 0)
      {
        breadCost = (Bread * 5) * 2/3;
      } 
      else if (Bread <= 2)
      {
        breadCost = Bread * 5;
      }
      else 
      {
        breadCost = (((Bread - (Bread % 3)) * 5) * 2/3) + ((Bread % 3) * 5);
      }
      return breadCost;
    }

    public int GetPastryCost(int pastry)
    {
      int pastryCost = 0;
      if (Pastry % 3 == 0) 
      {
        pastryCost = (Pastry/ 3) * 5;
      } 
      else if (Pastry <= 2) 
      {
        pastryCost = Pastry * 2;
      } else 
      {
        pastryCost = (((Pastry - (Pastry % 3)) / 3) * 5) + ((Pastry % 3) * 2);
      }
      return pastryCost;
    }
  }
}

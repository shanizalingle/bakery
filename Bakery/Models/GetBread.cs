using System;

namespace Bakery.Models
{
  public class GetBread
  {
    public int Bread { get; set; }

    public GetBread (int bread)
    {
      Bread = bread;
    }

    public int GetBreadCost(int bread)
    {
      int breadCost = 0;

      if (Bread <= 2)
      {
        breadCost = Bread * 5;
      }
      else 
      {
        breadCost = (((Bread - (Bread % 3)) * 5) * 2/3) + ((Bread % 3) * 5);
      }
      return breadCost;
    }
  }
}
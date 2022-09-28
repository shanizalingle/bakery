using System;

namespace Bakery.Models
{
  public class GetPastry
  {
    public int Pastry { get; set; }

    public GetPastry (int pastry)
    {
      Pastry = pastry;
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


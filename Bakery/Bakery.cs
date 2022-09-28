using System;

namespace Bakery.Models
{
  public class Bakery
  {

    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!" + "\n");
      Console.WriteLine("Inventory:" + "\n" + "- Fresh baked baguettes: $5 each" + "\n" + "- Fresh assorted pastries: $2 each" + "\n");
      Console.WriteLine("We are currently offering the following deals:" + "\n" + "- Bread: Buy 2, get 1 free" + "\n" + "- Pastries: Buy 3 for $5" + "\n");
      Console.WriteLine("Begin Order -----------------------------------" + "\n");

      bool repeat = true;
      while (repeat)
      {
        Console.WriteLine("Enter bread quantity: ");
        string stringBread = Console.ReadLine();
        int bread = int.Parse(stringBread);
    
        Console.WriteLine("\n" + "Enter pastry quantity: ");
        string stringPastry = Console.ReadLine();
        int pastry = int.Parse(stringPastry);
      
        Console.WriteLine("\n" + "Checkout --------------------------------------" + "\n");

        GetBread getBread = new GetBread(bread);
        GetPastry getPastry = new GetPastry(pastry);
        int breadCost = getBread.GetBreadCost(bread);
        int pastryCost = getPastry.GetPastryCost(pastry);
        int totalCost = breadCost + pastryCost;

        if (bread > 0 || pastry > 0)
        {
          Console.WriteLine("Bread-- " + bread);
          Console.WriteLine("Pastry-- " + pastry);
          Console.WriteLine("\n" + "Order total: $" + totalCost);
        }
        else 
        {
          Console.WriteLine("\n" + "There are no items in your cart, please try again");
        }

        Console.WriteLine("\n" + "Would you like to start a new order? (yes/no)");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
          Console.WriteLine("\n" + "Continue Order --------------------------------" + "\n");
          repeat = true;
        }
        else if (response == "no")
        {
          Console.WriteLine("\n" + "Thank you for shopping with us!" + "\n" + "Goodbye!");
          repeat = false;
        }
        else 
        {
          Console.WriteLine("\n" + "That command was not found, please try again" + "\n");
        }
      }
    }
  }
}

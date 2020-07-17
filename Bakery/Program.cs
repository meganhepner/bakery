using System;
using Bakery.Models;
using System.Collections.Generic; 

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Press ['Y'] to see today's offerings");
      string menu = Console.ReadLine();
      Bread newBread = new Bread(0);
      Pastry newPastry = new Pastry(0);
      if (menu == "Y" || menu == "y")
      {
        Console.WriteLine("**Whole Wheat Loaves $6");
        Console.WriteLine("**Sale!** Sourdough Boules $5 or Buy 2 Get 1 Free");
        Console.WriteLine("**Sale!** Sugar Cookies $2 or 3 for $5");
        Console.WriteLine("How many Whole Wheat Loaves would you like to purchase? If none, please enter 0!");
        string wholeWheat = Console.ReadLine();
        int wholeWheatOrder = int.Parse(wholeWheat);
        newBread.AddOrderToList(wholeWheatOrder * 6);
        Console.WriteLine("That will be $" + (wholeWheatOrder * 6));
        Console.WriteLine("How many Sourdough Boules would you like to purchase? If none, please enter 0!");
        string userBreadInput = Console.ReadLine();
        int breadOrder = int.Parse(userBreadInput);
        int breadTotal = newBread.TallyBreadOrder(breadOrder);
        newBread.AddOrderToList(breadTotal);
        Console.WriteLine("That will be $" + breadTotal);
        Console.WriteLine("How many pastries would you like to purchase? If none, please enter 0!");
        string userPastryInput = Console.ReadLine();
        int pastryOrder = int.Parse(userPastryInput);
        int pastryTotal = newPastry.TallyPastryOrder(pastryOrder);
        newPastry.AddOrderToList(pastryTotal);
        Console.WriteLine("That will be $" + pastryTotal);
        // Console.Write("Your order total is $" + (breadTotal + pastryTotal));
        Console.WriteLine("Your total today will be $" + (newBread.TotalBreadOrder() + newPastry.TotalPastryOrder()) + ". Thankyou for shopping at Pierre's!");
      }
      else 
      {
        Main();
      }
    }
  }
}
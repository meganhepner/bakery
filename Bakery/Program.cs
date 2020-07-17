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
        Console.WriteLine("**Sale!** Sourdough Boules $5 or Buy 2 Get 1 Free");
        Console.WriteLine("**Sale!** Sugar Cookies $2 or 3 for $5");
        Console.WriteLine("How many loaves would you like to purchase? If none, please enter 0!");
        string userBreadInput = Console.ReadLine();
        int breadOrder = int.Parse(userBreadInput);
        int breadTotal = newBread.TallyBreadOrder(breadOrder);
        Console.WriteLine("That will be $" + breadTotal);
        Console.WriteLine("How many pastries would you like to purchase? If none, please enter 0!");
        string userPastryInput = Console.ReadLine();
        int pastryOrder = int.Parse(userPastryInput);
        int pastryTotal = newPastry.TallyPastryOrder(pastryOrder);
        Console.WriteLine("That will be $" + pastryTotal);
        Console.Write("Your order total is $" + (breadTotal + pastryTotal));
      }
      else 
      {
        Main();
      }

    }
  }
}
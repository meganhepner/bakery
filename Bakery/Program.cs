using System;
using Bakery.Models; 

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery! Press ['Y'] to see today's offerings");
      string menu = Console.ReadLine();
      if (menu == "Y" || menu == "y")
      {
        Console.WriteLine("**Sale!** Sourdough Boules $5 or Buy 2 Get 1 Free");
        Console.WriteLine("**Sale!** Sugar Cookies $2 or 3 for $5");
        Console.WriteLine("Would you like to purchase any bread today? Press ['Y'] for Yes, or ['Enter'] to continue to other Bakery options");
        string bread = Console.ReadLine();
        if (bread == "Y" || bread == "y")
        {
          Console.WriteLine("How many loaves would you like to purchase?");
          string userBreadInput = Console.ReadLine();
          int breadOrder = int.Parse(userBreadInput);
          Bread newBread = new Bread(breadOrder);
          int breadTotal = newBread.TallyBreadOrder(breadOrder);
          Console.WriteLine("Your order total is $" + breadTotal);
          Console.WriteLine(newBread.BreadOrder);
        }
        else
        {
          Console.WriteLine("Would you like to purchase any pastries today? Press ['Y'] for Yes, or ['Enter'] to see your shopping cart"); 
          string pastry = Console.ReadLine();
          if (pastry == "Y" || pastry == "y")
          {
            Console.WriteLine("How many pastries would you like to purchase?");
            string userPastryInput = Console.ReadLine();
            int pastryOrder = int.Parse(userPastryInput);
            Pastry newPastry = new Pastry();
            int pastryTotal = newPastry.TallyPastryOrder(pastryOrder);
            Console.WriteLine("Your order total is $" + pastryTotal);
          }
          else
          {
            Console.Write("Your order total is $I don't know!!");
          }
        }

      }
      else 
      {
        Main();
      }

    }
  }
}
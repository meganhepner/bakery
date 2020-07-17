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

      }
      else 
      {
        Main();
      }

    }
  }
}
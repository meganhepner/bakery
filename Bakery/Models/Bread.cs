using System;
// using System.Collections.Generic; if List??

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public int TallyBreadOrder(int breadOrder)
    {
      int currentOrder = 0;
      for (int i = 1; i <= breadOrder; i++)
      {
        if (i%3 == 0)
        {
          currentOrder += 0;
        }
        else
        {
        currentOrder += 5;
        }
      }
      return currentOrder;
    }

    // properties, methods, etc. will go here.

  }
}
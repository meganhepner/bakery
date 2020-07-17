using System;
// using System.Collections.Generic; if List??

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public int TallyOrder(int breadOrder)
    {
      int currentOrder = 0;
      for (int i = 1; i <= breadOrder; i++)
      {
        currentOrder += 5;
      }
      return currentOrder;
    }

    // properties, methods, etc. will go here.

  }
}
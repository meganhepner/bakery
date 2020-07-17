using System;
// using System.Collections.Generic; if List??

namespace Bakery
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public int TallyPastryOrder(int pastryOrder)
    {
      int currentOrder = 0;
      for (int i = 1; i <= pastryOrder; i++)
      {
        currentOrder += 2;
      }
      return currentOrder;
    }
  }
}
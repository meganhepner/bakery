using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    private int _pastryOrder;
    public int TallyPastryOrder(int pastryOrder)
    {
      int currentOrder = 0;
      for (int i = 1; i <= pastryOrder; i++)
      {
        if (i%3 == 0)
        {
          currentOrder += 1;
        }
        else
        {
        currentOrder += 2;
        }
      }
      return currentOrder;
    }
  }
}
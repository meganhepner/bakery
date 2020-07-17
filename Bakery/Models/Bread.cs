using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    private static List<int> _orders = new List<int> {};
  
    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
      _orders.Add(BreadOrder);

    }
    private int _breadOrder;
    public int TotalOrder()
    {
      return 0;
    }
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
  }
}
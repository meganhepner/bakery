using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Bread
  {
    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
    public int BreadOrder { get; set; }
    private static List<int> _orders = new List<int> {};
  
    public int TotalBreadOrder()
    {
      int total = 0;
      foreach(int order in _orders)
      {
        total = total + order;
      }
      return total;
    }

    public void AddOrderToList (int order)
    {
      _orders.Add(order);
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
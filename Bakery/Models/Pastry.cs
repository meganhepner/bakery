using System;
using System.Collections.Generic;

namespace Bakery
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    private static List<int> _orders = new List<int> {};
    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
    }
    public int TotalPastryOrder()
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_True()
    {
      Bread newBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnsBreadOrder_Int()
    {
      int breadOrder = 10;
      Bread newBread = new Bread(breadOrder);
      int result = newBread.BreadOrder;
      Assert.AreEqual(breadOrder, result);
    }

    [TestMethod]
    public void TallyBreadOrder_Charges5DollarsPerLoaf_True()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(5, testBread.TallyBreadOrder(1));
    }

      [TestMethod]
    public void TallyBreadOrder_DoesNottChargeForEveryThirdLoaf_True()
    {
      Bread testBread = new Bread(0);
      Assert.AreEqual(30, testBread.TallyBreadOrder(9));
    }

    
  }
}
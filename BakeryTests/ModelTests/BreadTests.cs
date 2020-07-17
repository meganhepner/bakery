using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TallyBreadOrder_Charges5DollarsPerLoaf_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.TallyBreadOrder(1));
    }

      [TestMethod]
    public void TallyBreadOrder_DoesNottChargeForEveryThirdLoaf_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(30, testBread.TallyBreadOrder(9));
    }

    
  }
}
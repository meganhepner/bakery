using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void TallyOrder_Charges5DollarsPerLoaf_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(5, testBread.TallyOrder(1));
    }

      [TestMethod]
    public void TallyOrder_DoesNottChargeForEveryThirdLoaf_True()
    {
      Bread testBread = new Bread();
      Assert.AreEqual(30, testBread.TallyOrder(9));
    }

    
  }
}
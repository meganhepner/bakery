using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void TallyPastryOrder_Charges2DollarsForEachPastry_True()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(2, testPastry.TallyPastryOrder(1));
    }
    [TestMethod]
    public void TallyPastryOrder_Charges1DollarsForEveryThirdPastry_True()
    {
      Pastry testPastry = new Pastry();
      Assert.AreEqual(15, testPastry.TallyPastryOrder(9));
    }
  }
}
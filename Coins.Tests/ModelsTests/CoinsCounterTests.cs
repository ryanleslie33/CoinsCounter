using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinsName;

namespace Coins.Tests
{
  [TestClass]
  public class CoinsCountTest
  {
    [TestMethod]
    public void FindCount_Userinputnumberisreturnedinchange_True()
   {
     int dollarAmount = 50;

     int Result = CoinsCount.ReturnCount(dollarAmount);
      Assert.AreEqual(2,Result);
   }
  }
}

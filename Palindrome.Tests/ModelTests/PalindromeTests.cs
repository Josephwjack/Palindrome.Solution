using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class ProgramTests
  {
    [TestMethod]
    public void CheckIsPal_ItShouldReverseString_ReverseString()
    {
      Program testProgram = new Program();
      Assert.AreEqual(true, testProgram.IsPal(dad));
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PChecker;

namespace PChecker.TestTools
{
  [TestClass]
  public class PalindromeTests
  {
    [TestMethod]
    public void IsWord_AWordAWord_True()
    {
      Palindrome testP = new Palindrome();
      Assert.AreEqual(true, testP.IsWord("test"));
    }

    [TestMethod]
    public void IsWord_AWordAWord_False()
    {
      Palindrome testP = new Palindrome();
      Assert.AreEqual(false, testP.IsWord(" "));
    }

    [TestMethod]
    public void IsPalindrome_SameForwardAndBackward_True()
    {
      Palindrome testP = new Palindrome();
      Assert.AreEqual(true, testP.IsPalindrome("racecar"));
    }

    [TestMethod]
    public void IsPalindrome_SameForwardAndBackward_False()
    {
      Palindrome testP = new Palindrome();
      Assert.AreEqual(false, testP.IsPalindrome("epicodus"));
    }
  }
}
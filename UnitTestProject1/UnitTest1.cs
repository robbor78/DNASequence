using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SRM682DNASequence;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      string[] allSequences = new string[]
      {
"TOPBOATER",
"SUSHI",
"GATTACA",
"GOODLUCK",
"VVZWKCSIQEGANULDLZESHUYHUQGRKUMFCGTATGOHMLKBIRCA"
      };

      int[] allMax = new int[] { 2, 0, 7, 1, 6 };

      Program p = new Program();
      int length = allSequences.Length;
      for (int i = 0; i < length; i++)
      {
        string sequence = allSequences[i];
        int actual = p.longestDNASequence(sequence);
        int expected = allMax[i];
        Assert.AreEqual(expected, actual);
      }
    }
  }
}

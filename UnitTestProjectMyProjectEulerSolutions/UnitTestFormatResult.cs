using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem31;

namespace UnitTestProjectMyProjectEulerSolutions
{
  [TestClass]
  public class UnitTestFormatResult
  {
    [TestMethod]
    public void TestMethod_1_time_200()
    {
      const int sourcea = 1;
      const int sourceb = 0;
      const int sourcec = 0;
      const int sourced = 0;
      const int sourcee = 0;
      const int sourcef = 0;
      const int sourceg = 0;
      const int sourceh = 0;
      const string expected = "200=200*1";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_time_100()
    {
      const int sourcea = 0;
      const int sourceb = 2;
      const int sourcec = 0;
      const int sourced = 0;
      const int sourcee = 0;
      const int sourcef = 0;
      const int sourceg = 0;
      const int sourceh = 0;
      const string expected = "200=100*2";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }
  }
}
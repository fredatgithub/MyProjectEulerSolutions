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
    public void TestMethod_2_times_100()
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

    [TestMethod]
    public void TestMethod_4_times_50()
    {
      const int sourcea = 0 ;// 200;
      const int sourceb = 0 ;// 100;
      const int sourcec = 4 ;// 50;
      const int sourced = 0 ;// 20;
      const int sourcee = 0 ;// 10;
      const int sourcef = 0 ;// 5;
      const int sourceg = 0 ;// 2;
      const int sourceh = 0; // 1;
      const string expected = "200=50*4";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_10_times_20()
    {
      const int sourcea = 0;// 200;
      const int sourceb = 0;// 100;
      const int sourcec = 0;// 50;
      const int sourced = 10;// 20;
      const int sourcee = 0;// 10;
      const int sourcef = 0;// 5;
      const int sourceg = 0;// 2;
      const int sourceh = 0; // 1;
      const string expected = "200=20*10";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_20_times_10()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 20; // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=10*20";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_40_times_5()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 0; // 10;
      const int sourcef = 40;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=5*40";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }
  }
}
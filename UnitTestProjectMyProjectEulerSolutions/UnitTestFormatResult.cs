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
      const int sourcea = 0;// 200;
      const int sourceb = 0;// 100;
      const int sourcec = 4;// 50;
      const int sourced = 0;// 20;
      const int sourcee = 0;// 10;
      const int sourcef = 0;// 5;
      const int sourceg = 0;// 2;
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

    [TestMethod]
    public void TestMethod_100_times_2()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 0; // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 100;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=2*100";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_200_times_1()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 0; // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 200;  // 1;
      const string expected = "200=1*200";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100_by_1_plus_50_by_4()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 1;  // 100;
      const int sourcec = 2;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 0; // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=100*1+50*2";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_many_factors()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 1;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 2;  // 20;
      const int sourcee = 1; // 10;
      const int sourcef = 2;  // 5;
      const int sourceg = 25;  // 2;
      const int sourceh = 10;  // 1;
      const string expected = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_no_factor()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 0;  // 20;
      const int sourcee = 0;  // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_one_of_each_factor()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 1;  // 100;
      const int sourcec = 1;  // 50;
      const int sourced = 1;  // 20;
      const int sourcee = 1;  // 10;
      const int sourcef = 1;  // 5;
      const int sourceg = 1;  // 2;
      const int sourceh = 13;  // 1;
      const string expected = "200=100*1+50*1+20*1+10*1+5*1+2*1+1*13";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_two_of_each_factor()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 2;  // 50;
      const int sourced = 2;  // 20;
      const int sourcee = 2;  // 10;
      const int sourcef = 2;  // 5;
      const int sourceg = 2;  // 2;
      const int sourceh = 28;  // 1;
      const string expected = "200=50*2+20*2+10*2+5*2+2*2+1*28";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_three_of_each()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 1;  // 50;
      const int sourced = 3;  // 20;
      const int sourcee = 3;  // 10;
      const int sourcef = 3;  // 5;
      const int sourceg = 3;  // 2;
      const int sourceh = 39;  // 1;
      const string expected = "200=50*1+20*3+10*3+5*3+2*3+1*39";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_four_of_each()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 1;  // 50;
      const int sourced = 4;  // 20;
      const int sourcee = 4;  // 10;
      const int sourcef = 4;  // 5;
      const int sourceg = 4;  // 2;
      const int sourceh = 2;  // 1;
      const string expected = "200=50*1+20*4+10*4+5*4+2*4+1*2";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_five_of_each()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 5;  // 20;
      const int sourcee = 5;  // 10;
      const int sourcef = 5;  // 5;
      const int sourceg = 5;  // 2;
      const int sourceh = 15;  // 1;
      const string expected = "200=20*5+10*5+5*5+2*5+1*15";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_six_of_each()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 6;  // 20;
      const int sourcee = 6;  // 10;
      const int sourcef = 6;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=20*6+10*6+5*6";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seven_of_each_just_one()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 6;  // 20;
      const int sourcee = 7;  // 10;
      const int sourcef = 2;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=20*6+10*7+5*2";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_seven_of_each_top_max()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 7;  // 20;
      const int sourcee = 6;  // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=20*7+10*6";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eight_of_each__top_max()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 8;  // 20;
      const int sourcee = 0;  // 10;
      const int sourcef = 8;  // 5;
      const int sourceg = 0;  // 2;
      const int sourceh = 0;  // 1;
      const string expected = "200=20*8+5*8";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eight_of_each__take_two()
    {
      const int sourcea = 0;  // 200;
      const int sourceb = 0;  // 100;
      const int sourcec = 0;  // 50;
      const int sourced = 8;  // 20;
      const int sourcee = 0;  // 10;
      const int sourcef = 0;  // 5;
      const int sourceg = 8;  // 2;
      const int sourceh = 24;  // 1;
      const string expected = "200=20*8+2*8+1*24";
      string result = Program.FormatResult(sourcea, sourceb, sourcec, sourced, sourcee, sourcef, sourceg, sourceh);
      Assert.AreEqual(result, expected);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateUnitTestFile;

namespace UnitTestProjectCreateUnitTestFile
{
  [TestClass]
  public class UnitTestGetMultiplier
  {
    [TestMethod]
    public void TestMethod_10()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 1;
      const string expected = "10";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 100;
      const string expected = "1";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_20()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 20;
      const string expected = "2";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_5()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 5;
      const string expected = "2";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 2;
      const string expected = "25";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 1;
      const string expected = "10";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_50()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=100*1+50*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 50;
      const string expected = "2";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateUnitTestFile;

namespace UnitTestProjectCreateUnitTestFile
{
  [TestClass]
  public class UnitTestHasMultiplier
  {
    [TestMethod]
    public void TestMethod_200_true()
    {
      const string sourceLine = "200=200*1";
      const int sourcePosition = 200;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_200_false()
    {
      const string sourceLine = "200=100*1";
      const int sourcePosition = 200;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100_true()
    {
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 100;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100_false()
    {
      const string sourceLine = "200=20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 100;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_50_false()
    {
      const string sourceLine = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 50;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_50_true()
    {
      const string sourceLine = "200=100*1+50*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 50;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_20_false()
    {
      const string sourceLine = "200=100*1+50*2+10*1+5*2+2*25+1*10";
      const int sourcePosition = 20;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_20_true()
    {
      const string sourceLine = "200=100*1+50*2+20*1+10*1+5*2+2*25+1*10";
      const int sourcePosition = 20;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_10_false()
    {
      const string sourceLine = "200=100*1+50*2+20*1+5*2+2*25+1*10";
      const int sourcePosition = 10;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_10_true()
    {
      const string sourceLine = "200=100*1+50*2+20*1+10*1+5*2+2*25+1*10";
      const int sourcePosition = 10;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_5_false()
    {
      const string sourceLine = "200=100*1+50*2+10*1+2*25+1*10";
      const int sourcePosition = 5;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_5_true()
    {
      const string sourceLine = "200=100*1+50*2+20*1+10*1+5*2+2*25+1*10";
      const int sourcePosition = 5;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_false()
    {
      const string sourceLine = "200=100*1+50*2+10*1+5*2+1*10";
      const int sourcePosition = 2;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_true()
    {
      const string sourceLine = "200=100*1+50*2+20*1+10*1+5*2+2*25+1*10";
      const int sourcePosition = 2;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_false()
    {
      const string sourceLine = "200=100*1+50*2+10*1+5*2+2*25";
      const int sourcePosition = 1;
      const bool expected = false;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_1_true()
    {
      const string sourceLine = "200=100*1+50*2+20*1+10*1+5*2+2*25+1*10";
      const int sourcePosition = 1;
      const bool expected = true;
      bool result = Program.HasMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }
  }
}
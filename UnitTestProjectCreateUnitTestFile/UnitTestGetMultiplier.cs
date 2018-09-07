using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreateUnitTestFile;

namespace UnitTestProjectCreateUnitTestFile
{
  [TestClass]
  public class UnitTestGetMultiplier
  {
    [TestMethod]
    public void TestMethod_1()
    {
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      const string sourceLine = "200=200*1";
      const int sourcePosition = 1;
      const string expected = "1";
      string result = Program.GetMultiplier(sourceLine, sourcePosition);
      Assert.AreEqual(result, expected);
    }
  }
}
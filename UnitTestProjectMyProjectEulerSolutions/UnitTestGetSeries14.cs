using Microsoft.VisualStudio.TestTools.UnitTesting;
using Func = MyProjectEulerSolutions.Program;

namespace UnitTestProjectMyProjectEulerSolutions
{
  [TestClass]
  public class UnitTestGetSeries14
  {
    [TestMethod]
    public void TestMethodGetSeries14_1()
    {
      const int source = 1;
      string expected = "1";
      string result = Func.GetSeries14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodGetSeries14_2()
    {
      const int source = 2;
      string expected = "2-1";
      string result = Func.GetSeries14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodGetSeries14_3()
    {
      const int source = 3;
      string expected = "3-10-5-16-8-4-2-1";
      string result = Func.GetSeries14(source);
      Assert.AreEqual(result, expected);
    }
  }
}
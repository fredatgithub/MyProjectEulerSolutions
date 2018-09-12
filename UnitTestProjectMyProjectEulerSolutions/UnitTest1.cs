using Problem31;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectMyProjectEulerSolutions
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod_1_multiply_by_200()
    {
      const int a = 0;
      const int b = 0;
      const int c = 0;
      const int d = 0;
      const int e = 0;
      const int f = 0;
      const int g = 0;
      const int h = 200;
      const string expected = "200=1*200";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
  }
}

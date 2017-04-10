using Microsoft.VisualStudio.TestTools.UnitTesting;
using Func = MyProjectEulerSolutions.Program;

namespace UnitTestProjectMyProjectEulerSolutions
{
  [TestClass]
  public class UnitTestFunctions
  {
    [TestMethod]
    public void TestMethodFunctionProblem14_1()
    {
      const int source = 1;
      const int expected = 4;
      int result = Func.FunctionProblem14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodFunctionProblem14_2()
    {
      const int source = 2;
      const int expected = 1;
      int result = Func.FunctionProblem14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodFunctionProblem14_3()
    {
      const int source = 3;
      const int expected = 10;
      int result = Func.FunctionProblem14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodFunctionProblem14_4()
    {
      const int source = 4;
      const int expected = 2;
      int result = Func.FunctionProblem14(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethodFunctionProblem14_5()
    {
      const int source = 5;
      const int expected = 16;
      int result = Func.FunctionProblem14(source);
      Assert.AreEqual(result, expected);
    }
  }
}
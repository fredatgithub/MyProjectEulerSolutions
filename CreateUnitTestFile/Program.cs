using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CreateUnitTestFile
{
  public class Program
  {
    public static void Main()
    {
      // read the result file and then create a unit test file
      string fileName = "result.txt";
      List<string> fileLines = new List<string>();
      try
      {
        using (StreamReader sr = new  StreamReader(fileName))
        {
          while (!sr.EndOfStream)
          {
            fileLines.Add(sr.ReadLine());
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }

      // create a unit test file
      StringBuilder unitTestFile = new StringBuilder();
      string unitTestFileName = string.Empty;
      unitTestFile.Append("using Microsoft.VisualStudio.TestTools.UnitTesting;");
      unitTestFile.AppendLine();
      unitTestFile.Append("using Problem31;");
      unitTestFile.AppendLine();
      unitTestFile.AppendLine();
      unitTestFile.Append("namespace UnitTestProjectMyProjectEulerSolutions");
      unitTestFile.AppendLine();
      unitTestFile.Append("{");
      unitTestFile.AppendLine();
      unitTestFile.Append("[TestClass]");
      unitTestFile.AppendLine();
      unitTestFile.Append("public class UnitTestFormatResult2");
      unitTestFile.AppendLine();
      unitTestFile.Append("{");
      unitTestFile.AppendLine();
     
      // looping through the result file

      foreach (string line in fileLines)
      {
        // 200=2*1+1*198
        unitTestFile.Append("[TestMethod]");
        unitTestFile.AppendLine();
        unitTestFile.Append($"public void TestMethod_{line.Substring(4, line.ToString().Length - 4)}");
        unitTestFile.AppendLine();
        unitTestFile.Append("{");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int a = {GetMultiplier(line, 1)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int b = {GetMultiplier(line, 2)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int c = {GetMultiplier(line, 3)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int d = {GetMultiplier(line, 4)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int e = {GetMultiplier(line, 5)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int f = {GetMultiplier(line, 6)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int g = {GetMultiplier(line, 7)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const int h = {GetMultiplier(line, 8)};");
        unitTestFile.AppendLine();
        unitTestFile.Append($"const string expected = \"{line}\";");
        unitTestFile.AppendLine();
        unitTestFile.Append("string result = Program.FormatResult(a, b, c, d, e, f, g, h);");
        unitTestFile.AppendLine();
        unitTestFile.Append("Assert.AreEqual(result, expected);");
        unitTestFile.AppendLine();
        unitTestFile.Append("}");
        unitTestFile.AppendLine();
        unitTestFile.AppendLine();
      }

      unitTestFile.AppendLine();
      unitTestFile.Append("}");
      unitTestFile.AppendLine();
      unitTestFile.Append("}");

      unitTestFileName = unitTestFile.ToString();
      unitTestFile.Clear();
      // save the file
      try
      {
        using (StreamWriter sw = new StreamWriter("unitTest.cs"))
        {
          sw.WriteLine(unitTestFileName);
        }

        Console.WriteLine("unit file written correctly");
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }

    public static string GetMultiplier(string line, int position)
    {
      string result = string.Empty;
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      line = line.Substring(4, line.Length - 4);
      string[] tmpSubPlus = line.Split('+');
      result = tmpSubPlus[0];
      return result;
    }
  }
}
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
      //string fileNameToWrite = "unitTest";
      int fileNameToWriteCounter = 2;
      int numberOfUnitTestPerFile = 10000;
      int counterInnerLoop = 1;
      // read the result file
      List<string> fileLines = ReadFile(fileName);
      // create a unit test file
      string fileToBeWrittenUnitFile = GetHeader(fileNameToWriteCounter);

      // looping through the result file
      foreach (string line in fileLines)
      {
        if (counterInnerLoop % numberOfUnitTestPerFile == 0)
        {
          // we write the file and create another new unit test file
          // adding footer to the file
          fileToBeWrittenUnitFile += AddFooter();
          WriteFile(fileToBeWrittenUnitFile, fileNameToWriteCounter);

          //increase counter for next unit test file
          fileNameToWriteCounter++;
          // delete file content and create a new one with header
          fileToBeWrittenUnitFile = GetHeader(fileNameToWriteCounter);
          fileToBeWrittenUnitFile += AddUnitTest(line);
          counterInnerLoop++;
        }
        else
        {
          fileToBeWrittenUnitFile += AddUnitTest(line);
          counterInnerLoop++;
        }
      }

      // writing the file at the end
      fileToBeWrittenUnitFile += AddFooter();
      WriteFile(fileToBeWrittenUnitFile, fileNameToWriteCounter);
      //free memory
      fileToBeWrittenUnitFile = string.Empty;

      Console.WriteLine("Press any key to exit:");
      Console.ReadKey();
    }

    private static string AddUnitTest(string line)
    {
      StringBuilder unitTestFile = new StringBuilder();
      // 200=2*1+1*198
      unitTestFile.Append("[TestMethod]");
      unitTestFile.AppendLine();
      unitTestFile.Append($"public void TestMethod_{line.Substring(4, line.ToString().Length - 4).Replace("*", "_multiply_by_").Replace("+", "_plus_")}()");
      unitTestFile.AppendLine();
      unitTestFile.Append("{");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int a = {(HasMultiplier(line, 200) ? GetMultiplier(line, 200) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int b = {(HasMultiplier(line, 100) ? GetMultiplier(line, 100) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int c = {(HasMultiplier(line, 50) ? GetMultiplier(line, 50) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int d = {(HasMultiplier(line, 20) ? GetMultiplier(line, 20) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int e = {(HasMultiplier(line, 10) ? GetMultiplier(line, 10) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int f = {(HasMultiplier(line, 5) ? GetMultiplier(line, 5) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int g = {(HasMultiplier(line, 2) ? GetMultiplier(line, 2) : "0")};");
      unitTestFile.AppendLine();
      unitTestFile.Append($"const int h = {(HasMultiplier(line, 1) ? GetMultiplier(line, 1) : "0")};");
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
      return unitTestFile.ToString();
    }

    private static void WriteFile(string fileToBeWrittenUnitFile, int fileNumber)
    {
      // save the file
      try
      {
        using (StreamWriter sw = new StreamWriter($"unitTest{fileNumber}.cs"))
        {
          sw.WriteLine(fileToBeWrittenUnitFile);
        }

        Console.WriteLine($"Unit file: unitTest{fileNumber}.cs written correctly");
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }

    private static string AddFooter()
    {
      StringBuilder unitTestFile = new StringBuilder();
      unitTestFile.AppendLine();
      unitTestFile.Append("}");
      unitTestFile.AppendLine();
      unitTestFile.Append("}");

      return unitTestFile.ToString();
    }

    private static string GetHeader(int fileNameToWriteCounter)
    {
      // header
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
      unitTestFile.Append($"public class UnitTestFormatResult{fileNameToWriteCounter}");
      unitTestFile.AppendLine();
      unitTestFile.Append("{");
      unitTestFile.AppendLine();
      return unitTestFile.ToString();
    }

    private static List<string> ReadFile(string fileName)
    {
      List<string> result = new List<string>();

      try
      {
        using (StreamReader sr = new StreamReader(fileName))
        {
          while (!sr.EndOfStream)
          {
            result.Add(sr.ReadLine());
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }

      return result;
    }

    public static string GetMultiplier(string line, int number)
    {
      string result = string.Empty;
      //200=100*1+20*2+10*1+5*2+2*25+1*10
      line = line.Substring(4, line.Length - 4);
      string[] tmpSubPlus = line.Split('+');
      for (int i = 0; i <= tmpSubPlus.Length - 1; i++)
      {
        if (tmpSubPlus[i].Contains($"{number}*"))
        {
          result = tmpSubPlus[i].Split('*')[1];
          break;
        }
      }

      return result;
    }

    public static bool HasMultiplier(string line, int number) => line.Contains($"{number}*");
  }
}
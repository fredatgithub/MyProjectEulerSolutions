using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem31
{
  internal class Program
  {
    private static void Main()
    {
      Action<string> display = Console.WriteLine;
      display("---------------------------------------------------------------------");
      display("Problem 31");
      /*
         In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:
         1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
         It is possible to make £2 in the following way:
         1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
         How many different ways can £2 be made using any number of coins?
       */
      var pences = new List<int> { 200, 100, 50, 20, 10, 5, 2, 1 };
      var result31 = new List<string>();
      int searchedValue = 200;
      bool newResult = false;
      CreateLoopfileIfNotExist();
      // Let's calculate by hand to get an idea of the algorithm
      // By hand it would be something like
      //result31.Add("1x200");
      //result31.Add("2x100");
      //result31.Add("1x100+2x50");
      //result31.Add("1x100+5x20");
      //result31.Add("1x100+1x50+2x20+1x10");
      //result31.Add("1x100+1x50+1x20+3x10");
      //result31.Add("1x100+1x50+1x20+2x10+2x5");
      //result31.Add("1x100+1x50+1x20+2x10+1x5+2x2+1x1");
      //result31.Add("1x100+1x50+1x20+2x10+1x5+1x2+3x1");
      //result31.Add("1x100+1x50+1x20+1x10+4x5");
      List<int> divisorList = new List<int>();
      int factorMin = searchedValue / pences.Max(); // 1
      int factorMax = searchedValue / pences.Min(); // 200
                                                    // 200p cannot go higher than 1 because 1 * 200 = 200
                                                    // 1p cannot go higher than 200 because 200 * 1 = 200
                                                    // so make a for loop for each coins accordingly
      ulong counter31 = 0;
      // not saved if program is controled-C
      //int a1 = Properties.Settings.Default.Loop1;
      //int a2 = Properties.Settings.Default.Loop2;
      //int a3 = Properties.Settings.Default.Loop3;
      //int a4 = Properties.Settings.Default.Loop4;
      //int a5 = Properties.Settings.Default.Loop5;
      //int a6 = Properties.Settings.Default.Loop6;
      //int a7 = Properties.Settings.Default.Loop7;
      //int a8 = Properties.Settings.Default.Loop8;
      //ReadLoopValues()
      int a1 = ReadLoopValues(1);
      int a2 = ReadLoopValues(2);
      int a3 = ReadLoopValues(3);
      int a4 = ReadLoopValues(4);
      int a5 = ReadLoopValues(5);
      int a6 = ReadLoopValues(6);
      int a7 = ReadLoopValues(7);
      int a8 = ReadLoopValues(8);

      for (int a = a1; a < 2; a++) // 200
      {
        for (int b = a2; b < 3; b++) // 100
        {
          for (int c = a3; c < 5; c++) // 50
          {
            for (int d = a4; d < 11; d++) // 20
            {
              for (int e = a5; e < 21; e++) // 10
              {
                for (int f = a6; f < 41; f++) // 5
                {
                  for (int g = a7; g < 101; g++) // 2
                  {
                    for (int h = a8; h < 201; h++) // 1
                    {
                      Console.WriteLine($"Solution={counter31}--200=200*{a} + 100*{b} + 50*{c} + 20*{d} + 10*{e} + 5*{f} + 2*{g} + 1*{h}");
                      if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) + (f * 5) + (g * 2) + (h * 1) == 200)
                      {
                        result31.Add($"200=200*{a}+100*{b}+50*{c}+20*{d}+10*{e}+5*{f}+2*{g}+1*{h}");
                        SaveSettings(a, b, c, d, e, f, g, h);
                        SaveResults(result31);
                        newResult = true;
                        counter31++;
                      }
                    }
                  }

                  //backup already done loops
                  SaveSettings(a, b, c, d, e, f, 0, 0);
                  if (newResult)
                  {
                    SaveResults(result31);
                    newResult = false;
                  }
                }
              }
            }
          }
        }
      }

      try
      {
        using (StreamWriter sw = new StreamWriter("result-final.txt"))
        {
          foreach (string item in result31)
          {
            sw.WriteLine(item);
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception);
      }

      display("End of problems");
      Console.ReadKey();
    }

    private static void CreateLoopfileIfNotExist()
    {
      if (!File.Exists(Properties.Settings.Default.LoopValuesFileName))
      {
        try
        {
          using (StreamWriter sw = new StreamWriter(Properties.Settings.Default.LoopValuesFileName))
          {
            for (int i = 1; i < 9; i++)
            {
              sw.WriteLine("0");
            }
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception.Message);
        }
      }
    }

    private static int ReadLoopValues(int cursor)
    {
      int result = 0;
      List<string> lines = new List<string>();
      try
      {
        using (StreamReader sr = new StreamReader(Properties.Settings.Default.LoopValuesFileName))
        {
          while (sr.Peek() >= 0)
          {
            lines.Add(sr.ReadLine());
          }
        }

        string tmpResult = lines.ToArray()[cursor - 1]; 
        result = int.Parse(tmpResult);
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }

      return result;
    }

    private static void SaveResults(List<string> list)
    {
      if (list.Count == 0) return;
      try
      {
        bool append = true;
        using (StreamWriter sr = new StreamWriter(Properties.Settings.Default.ResultFileName, append))
        {
          foreach (string line in list)
          {
            sr.WriteLine(line);
          }
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }

    private static void SaveSettings(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8)
    {
      // not saved when pgm is controled-C
      //Properties.Settings.Default.Loop1 = a1;
      //Properties.Settings.Default.Loop2 = a2;
      //Properties.Settings.Default.Loop3 = a3;
      //Properties.Settings.Default.Loop4 = a4;
      //Properties.Settings.Default.Loop5 = a5;
      //Properties.Settings.Default.Loop6 = a6;
      //Properties.Settings.Default.Loop7 = a7;
      //Properties.Settings.Default.Loop8 = a8;
      //Properties.Settings.Default.Save();
      try
      {
        using (StreamWriter sr = new StreamWriter(Properties.Settings.Default.LoopValuesFileName))
        {
          sr.WriteLine(a1);
          sr.WriteLine(a2);
          sr.WriteLine(a3);
          sr.WriteLine(a4);
          sr.WriteLine(a5);
          sr.WriteLine(a6);
          sr.WriteLine(a7);
          sr.WriteLine(a8);
        }
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
    }
  }
}
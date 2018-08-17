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
      // Let's calculate by hand to get an idea of the algorithm
      // By hand it would be something like
      result31.Add("1x200");
      result31.Add("2x100");
      result31.Add("1x100+2x50");
      result31.Add("1x100+5x20");
      result31.Add("1x100+1x50+2x20+1x10");
      result31.Add("1x100+1x50+1x20+3x10");
      result31.Add("1x100+1x50+1x20+2x10+2x5");
      result31.Add("1x100+1x50+1x20+2x10+1x5+2x2+1x1");
      result31.Add("1x100+1x50+1x20+2x10+1x5+1x2+3x1");
      result31.Add("1x100+1x50+1x20+1x10+4x5");
      List<int> divisorList = new List<int>();
      int factorMin = searchedValue / pences.Max(); // 1
      int factorMax = searchedValue / pences.Min(); // 200
      // 200p cannot go higher than 1 because 1 * 200 = 200
      // 1p cannot go higher than 200 because 200 * 1 = 200
      // so make a for loop for each coins
      ulong counter31 = 0;
      int a1 = Properties.Settings.Default.Loop1;
      int a2 = Properties.Settings.Default.Loop2;
      int a3 = Properties.Settings.Default.Loop3;
      int a4 = Properties.Settings.Default.Loop4;
      int a5 = Properties.Settings.Default.Loop5;
      int a6 = Properties.Settings.Default.Loop6;
      int a7 = Properties.Settings.Default.Loop7;
      int a8 = Properties.Settings.Default.Loop8;

      for (int a = a1; a < 201; a++)
      {

        for (int b = a2; b < 201; b++)
        {
          //if ((a * 200) + (b * 100) > 200)
          //{
          //  break;
          //}

          for (int c = a3; c < 201; c++)
          {
            //if ((a * 200) + (b * 100) + (c * 50) > 200)
            //{
            //  break;
            //}

            for (int d = a4; d < 201; d++)
            {
              //if ((a * 200) + (b * 100) + (c * 50) + (d * 20) > 200)
              //{
              //  break;
              //}

              for (int e = a5; e < 201; e++)
              {
                //if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) > 200)
                //{
                //  break;
                //}

                for (int f = a6; f < 201; f++)
                {
                  //if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) + (f * 5)  > 200)
                  //{
                  //  break;
                  //}

                  for (int g = a7; g < 201; g++)
                  {
                    //if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) + (f * 5) + (g * 2) > 200)
                    //{
                    //  break;
                    //}

                    for (int h = a8; h < 201; h++)
                    {
                      //if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) + (f * 5) + (g * 2) + (h * 1) > 200)
                      //{
                      //  break;
                      //}

                      Console.WriteLine($"Solution={counter31}--200*{a} + 100*{b} + 50*{c} + 20*{d} + 10*{e} + 5*{f} + 2*{g} + 1*{h}");
                      if ((a * 200) + (b * 100) + (c * 50) + (d * 20) + (e * 10) + (f * 5) + (g * 2) + (h * 1) == 200)
                      {
                        result31.Add($"a={a}-b={b}-c={c}-d={d}-e={e}-f={f}-g={g}-h={h}");
                        SaveSettings(a, b, c, d, e, f, g, h);
                        counter31++;
                      }
                    }
                  }

                  //backup already done loops
                 SaveSettings(a, b, c, d, e, f, 1, 1);
                }
              }
            }
          }
        }
      }

      try
      {
        using (StreamWriter sw = new StreamWriter("result.txt"))
        {
          foreach (string item in result31)
          {
            sw.WriteLine($"200 = {item}");
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

    private static void SaveSettings(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8)
    {
      Properties.Settings.Default.Loop1 = a1;
      Properties.Settings.Default.Loop2 = a2;
      Properties.Settings.Default.Loop3 = a3;
      Properties.Settings.Default.Loop4 = a4;
      Properties.Settings.Default.Loop5 = a5;
      Properties.Settings.Default.Loop6 = a6;
      Properties.Settings.Default.Loop7 = a7;
      Properties.Settings.Default.Loop8 = a8;
      Properties.Settings.Default.Save();
    }
  }
}
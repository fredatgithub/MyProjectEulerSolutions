﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem31;

namespace UnitTestProjectMyProjectEulerSolutions
{
  [TestClass]
  public class UnitTestFormatResult
  {
    [TestMethod]
    public void TestMethod_1_time_200()
    {
      const int a = 1;
      const int b = 0;
      const int c = 0;
      const int d = 0;
      const int e = 0;
      const int f = 0;
      const int g = 0;
      const int h = 0;
      const string expected = "200=200*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_2_times_100()
    {
      const int a = 0;
      const int b = 2;
      const int c = 0;
      const int d = 0;
      const int e = 0;
      const int f = 0;
      const int g = 0;
      const int h = 0;
      const string expected = "200=100*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_4_times_50()
    {
      const int a = 0;// 200;
      const int b = 0;// 100;
      const int c = 4;// 50;
      const int d = 0;// 20;
      const int e = 0;// 10;
      const int f = 0;// 5;
      const int g = 0;// 2;
      const int h = 0; // 1;
      const string expected = "200=50*4";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_10_times_20()
    {
      const int a = 0;// 200;
      const int b = 0;// 100;
      const int c = 0;// 50;
      const int d = 10;// 20;
      const int e = 0;// 10;
      const int f = 0;// 5;
      const int g = 0;// 2;
      const int h = 0; // 1;
      const string expected = "200=20*10";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_20_times_10()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 20; // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=10*20";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_40_times_5()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 0; // 10;
      const int f = 40;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=5*40";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100_times_2()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 0; // 10;
      const int f = 0;  // 5;
      const int g = 100;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=2*100";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_200_times_1()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 0; // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 200;  // 1;
      const string expected = "200=1*200";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_100_by_1_plus_50_by_4()
    {
      const int a = 0;  // 200;
      const int b = 1;  // 100;
      const int c = 2;  // 50;
      const int d = 0;  // 20;
      const int e = 0; // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=100*1+50*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_many_factors()
    {
      const int a = 0;  // 200;
      const int b = 1;  // 100;
      const int c = 0;  // 50;
      const int d = 2;  // 20;
      const int e = 1; // 10;
      const int f = 2;  // 5;
      const int g = 25;  // 2;
      const int h = 10;  // 1;
      const string expected = "200=100*1+20*2+10*1+5*2+2*25+1*10";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_no_factor()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 0;  // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_one_of_each_factor()
    {
      const int a = 0;  // 200;
      const int b = 1;  // 100;
      const int c = 1;  // 50;
      const int d = 1;  // 20;
      const int e = 1;  // 10;
      const int f = 1;  // 5;
      const int g = 1;  // 2;
      const int h = 13;  // 1;
      const string expected = "200=100*1+50*1+20*1+10*1+5*1+2*1+1*13";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_two_of_each_factor()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 2;  // 50;
      const int d = 2;  // 20;
      const int e = 2;  // 10;
      const int f = 2;  // 5;
      const int g = 2;  // 2;
      const int h = 28;  // 1;
      const string expected = "200=50*2+20*2+10*2+5*2+2*2+1*28";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_three_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 1;  // 50;
      const int d = 3;  // 20;
      const int e = 3;  // 10;
      const int f = 3;  // 5;
      const int g = 3;  // 2;
      const int h = 39;  // 1;
      const string expected = "200=50*1+20*3+10*3+5*3+2*3+1*39";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_four_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 1;  // 50;
      const int d = 4;  // 20;
      const int e = 4;  // 10;
      const int f = 4;  // 5;
      const int g = 4;  // 2;
      const int h = 2;  // 1;
      const string expected = "200=50*1+20*4+10*4+5*4+2*4+1*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_five_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 5;  // 20;
      const int e = 5;  // 10;
      const int f = 5;  // 5;
      const int g = 5;  // 2;
      const int h = 15;  // 1;
      const string expected = "200=20*5+10*5+5*5+2*5+1*15";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_six_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 6;  // 20;
      const int e = 6;  // 10;
      const int f = 6;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*6+10*6+5*6";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seven_of_each_just_one()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 6;  // 20;
      const int e = 7;  // 10;
      const int f = 2;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*6+10*7+5*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_seven_of_each_top_max()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 7;  // 20;
      const int e = 6;  // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*7+10*6";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eight_of_each__top_max()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 8;  // 20;
      const int e = 0;  // 10;
      const int f = 8;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*8+5*8";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eight_of_each_take_two()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 8;  // 20;
      const int e = 0;  // 10;
      const int f = 0;  // 5;
      const int g = 8;  // 2;
      const int h = 24;  // 1;
      const string expected = "200=20*8+2*8+1*24";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eight_of_each_take_one()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 8;  // 20;
      const int e = 0;  // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 40;  // 1;
      const string expected = "200=20*8+1*40";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_nine_of_each_take_five()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 9;  // 20;
      const int e = 0;  // 10;
      const int f = 4;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*9+5*4";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_nine_of_each_take_ten()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 9;  // 20;
      const int e = 1;  // 10;
      const int f = 2;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*9+10*1+5*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_nine_of_each_take_two()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 9;  // 20;
      const int e = 0;  // 10;
      const int f = 2;  // 5;
      const int g = 5;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*9+5*2+2*5";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_nine_of_each_take_one()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 9;  // 20;
      const int e = 0;  // 10;
      const int f = 2;  // 5;
      const int g = 2;  // 2;
      const int h = 6;  // 1;
      const string expected = "200=20*9+5*2+2*2+1*6";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ten_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 10;  // 20;
      const int e = 0;  // 10;
      const int f = 0;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=20*10";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ten_of_each_take_five()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 10;  // 10;
      const int f = 20;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=10*10+5*20";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ten_of_each_take_two()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 10;  // 10;
      const int f = 19;  // 5;
      const int g = 2;  // 2;
      const int h = 1;  // 1;
      const string expected = "200=10*10+5*19+2*2+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_eleven_of_each_top()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 11;  // 10;
      const int f = 11;  // 5;
      const int g = 11;  // 2;
      const int h = 13;  // 1;
      const string expected = "200=10*11+5*11+2*11+1*13";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_twelve_of_each_top()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 12;  // 10;
      const int f = 12;  // 5;
      const int g = 10;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=10*12+5*12+2*10";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirteen_of_each_top()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 13;  // 10;
      const int f = 13;  // 5;
      const int g = 2;  // 2;
      const int h = 1;  // 1;
      const string expected = "200=10*13+5*13+2*2+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirteen_of_each_bottom()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 13;  // 10;
      const int f = 13;  // 5;
      const int g = 0;  // 2;
      const int h = 5;  // 1;
      const string expected = "200=10*13+5*13+1*5";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
  }
}

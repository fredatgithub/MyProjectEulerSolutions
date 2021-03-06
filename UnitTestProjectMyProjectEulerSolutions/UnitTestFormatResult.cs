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

    [TestMethod]
    public void TestMethod_thirteen_of_each_3()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 13;  // 10;
      const int f = 12;  // 5;
      const int g = 5;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=10*13+5*12+2*5";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourteen_of_each_1()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 14;  // 10;
      const int f = 12;  // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*14+5*12";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fifteen_of_each()
    {
      const int a = 0;  // 200;
      const int b = 0;  // 100;
      const int c = 0;  // 50;
      const int d = 0;  // 20;
      const int e = 15;  // 10;
      const int f = 10;  // 5;
      const int g = 0;  // 2;
      const int h = 0;  // 1;
      const string expected = "200=10*15+5*10";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixteen_of_each()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 16;  // 10;
      const int f = 8;   // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*16+5*8";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventeen_of_each()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 17;  // 10;
      const int f = 6;   // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*17+5*6";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_eighteen_of_each()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 18;  // 10;
      const int f = 4;   // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*18+5*4";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_nineteen_of_each()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 19;  // 10;
      const int f = 2;   // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*19+5*2";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_of_each()
    {
      const int a = 0;   // 200;
      const int b = 0;   // 100;
      const int c = 0;   // 50;
      const int d = 0;   // 20;
      const int e = 20;  // 10;
      const int f = 0;   // 5;
      const int g = 0;   // 2;
      const int h = 0;   // 1;
      const string expected = "200=10*20";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 21;   // 5;
      const int g = 47;   // 2;
      const int h = 1;    // 1;
      const string expected = "200=5*21+2*47+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_one_2()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 21;   // 5;
      const int g = 46;   // 2;
      const int h = 3;    // 1;
      const string expected = "200=5*21+2*46+1*3";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_one_3()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 21;   // 5;
      const int g = 45;   // 2;
      const int h = 5;    // 1;
      const string expected = "200=5*21+2*45+1*5";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 22;   // 5;
      const int g = 45;   // 2;
      const int h = 0;    // 1;
      const string expected = "200=5*22+2*45";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 23;   // 5;
      const int g = 42;   // 2;
      const int h = 1;    // 1;
      const string expected = "200=5*23+2*42+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 24;   // 5;
      const int g = 40;   // 2;
      const int h = 0;    // 1;
      const string expected = "200=5*24+2*40";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 25;   // 5;
      const int g = 37;   // 2;
      const int h = 1;    // 1;
      const string expected = "200=5*25+2*37+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_five_2()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 25;   // 5;
      const int g = 25;   // 2;
      const int h = 25;    // 1;
      const string expected = "200=5*25+2*25+1*25";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 26;   // 5;
      const int g = 35;   // 2;
      const int h = 0;    // 1;
      const string expected = "200=5*26+2*35";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_six_2()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 26;   // 5;
      const int g = 26;   // 2;
      const int h = 18;   // 1;
      const string expected = "200=5*26+2*26+1*18";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 27;   // 5;
      const int g = 32;   // 2;
      const int h = 1;    // 1;
      const string expected = "200=5*27+2*32+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_seven_2()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 27;   // 5;
      const int g = 27;   // 2;
      const int h = 11;    // 1;
      const string expected = "200=5*27+2*27+1*11";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_eight()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 28;   // 5;
      const int g = 30;   // 2;
      const int h = 0;    // 1;
      const string expected = "200=5*28+2*30";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_twenty_eight_2()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 28;   // 5;
      const int g = 28;   // 2;
      const int h = 4;    // 1;
      const string expected = "200=5*28+2*28+1*4";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_twenty_nine()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 29;   // 5;
      const int g = 27;   // 2;
      const int h = 1;    // 1;
      const string expected = "200=5*29+2*27+1*1";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 30;   // 5;
      const int g = 25;   // 2;
      const int h = 0;    // 1;
      const string expected = "200=5*30+2*25";
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 31;   // 5;
      const int g = 22;   // 2;
      const int h = 1;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*31+2*22+1*1";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 32;   // 5;
      const int g = 20;   // 2;
      const int h = 0;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*32+2*20";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 33;   // 5;
      const int g = 17;   // 2;
      const int h = 1;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*33+2*17+1*1";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 34;   // 5;
      const int g = 15;   // 2;
      const int h = 0;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*34+2*15";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 35;   // 5;
      const int g = 12;   // 2;
      const int h = 1;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*35+2*12+1*1";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 36;   // 5;
      const int g = 10;   // 2;
      const int h = 0;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*36+2*10";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 37;   // 5;
      const int g = 7;    // 2;
      const int h = 1;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*37+2*7+1*1";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_eight()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 38;   // 5;
      const int g = 5;    // 2;
      const int h = 0;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*38+2*5";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_thirty_nine()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 39;   // 5;
      const int g = 2;    // 2;
      const int h = 1;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*39+2*2+1*1";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_fourty()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 40;   // 5;
      const int g = 0;    // 2;
      const int h = 0;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=5*40";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_fourty_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 41;   // 2;
      const int h = 118;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*41+1*118";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 42;   // 2;
      const int h = 116;    // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*42+1*116";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 43;   // 2;
      const int h = 114;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*43+1*114";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 44;   // 2;
      const int h = 112;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*44+1*112";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 45;   // 2;
      const int h = 110;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*45+1*110";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 46;   // 2;
      const int h = 108;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*46+1*108";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 47;   // 2;
      const int h = 106;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*47+1*106";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_eight()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 48;   // 2;
      const int h = 104;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*48+1*104";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fourty_nine()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 49;   // 2;
      const int h = 102;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*49+1*102";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 50;   // 2;
      const int h = 100;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*50+1*100";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 51;   // 2;
      const int h = 98;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*51+1*98";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 52;   // 2;
      const int h = 96;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*52+1*96";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 53;   // 2;
      const int h = 94;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*53+1*94";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 54;   // 2;
      const int h = 92;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*54+1*92";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 55;   // 2;
      const int h = 90;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*55+1*90";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 56;   // 2;
      const int h = 88;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*56+1*88";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 57;   // 2;
      const int h = 86;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*57+1*86";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_fivety_eight()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 58;   // 2;
      const int h = 84;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*58+1*84";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_fivety_nine()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 59;   // 2;
      const int h = 82;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*59+1*82";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_sixty()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 60;   // 2;
      const int h = 80;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*60+1*80";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_sixty_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 61;   // 2;
      const int h = 78;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*61+1*78";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 62;   // 2;
      const int h = 76;  // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*62+1*76";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 63;   // 2;
      const int h = 74;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*63+1*74";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 64;   // 2;
      const int h = 72;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*64+1*72";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 65;   // 2;
      const int h = 70;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*65+1*70";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 66;   // 2;
      const int h = 68;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*66+1*68";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 67;   // 2;
      const int h = 66;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*67+1*66";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_eight()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 68;   // 2;
      const int h = 64;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*68+1*64";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_sixty_nine()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 69;   // 2;
      const int h = 62;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*69+1*62";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 70;   // 2;
      const int h = 60;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*70+1*60";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_one()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 71;   // 2;
      const int h = 58;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*71+1*58";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_two()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 72;   // 2;
      const int h = 56;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*72+1*56";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_three()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 73;   // 2;
      const int h = 54;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*73+1*54";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_four()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 74;   // 2;
      const int h = 52;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*74+1*52";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_five()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 75;   // 2;
      const int h = 50;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*75+1*50";
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_seventy_six()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 76;   // 2;
      const int h = 48;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*76+1*48";
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_seventy_seven()
    {
      const int a = 0;    // 200;
      const int b = 0;    // 100;
      const int c = 0;    // 50;
      const int d = 0;    // 20;
      const int e = 0;    // 10;
      const int f = 0;    // 5;
      const int g = 77;   // 2;
      const int h = 46;   // 1;
      string result = Program.FormatResult(a, b, c, d, e, f, g, h);
      const string expected = "200=2*77+1*46";
      Assert.AreEqual(result, expected);
    }
  }
}

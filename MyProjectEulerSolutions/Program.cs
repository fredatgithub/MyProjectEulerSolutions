﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProjectEulerSolutions
{
  public class Program
  {
    static void Main(string[] args)
    {
      Action<string> Display = Console.WriteLine;
      Display("Project Euler - problem 1");
      /*
       If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
       Find the sum of all the multiples of 3 or 5 below 1000.
       */
      var multipleDeTrois = new List<int>();
      var multipleDeCinq = new List<int>();
      for (int i = 1; i < (1000 / 3) + 1; i++)
      {
        if (i * 3 < 1000)
        {
          multipleDeTrois.Add(3 * i);
        }
      }

      for (int i = 1; i < (1000 / 5) + 1; i++)
      {
        if (i * 5 < 1000)
        {
          multipleDeCinq.Add(5 * i);
        }
      }

      long somme = 0;
      foreach (var item in multipleDeCinq)
      {
        somme += item;
      }

      foreach (var item in multipleDeTrois)
      {
        somme += item;
      }

      Display($"The sum of all the multiples of 3 or 5 below 1000 is: {somme}");
      Display("---------------------------------------------------------------------");
      Display("Problem 2");
      /*
       Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
       1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
       By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
       * */
      int max = 4000000;
      var limit = 10000;
      var outNumber = 1;
      long result = 1;
      int[] list = new int[limit];
      list[0] = 1;
      list[1] = 2;
      for (int i = 2; i < limit; i++)
      {
        var number = list[i - 1] + list[i - 2];
        if (number < max)
        {
          list[i] = number;
        }
        else
        {
          outNumber = i - 1;
          break;
        }
      }

      int[] list2 = new int[outNumber];
      for (int i = 0; i < outNumber; i++)
      {
        list2[i] = list[i];
      }

      list = null;
      for (int i = 0; i < list2.Length; i = i + 2)
      {
        result += list2[i];
      }

      Display($"The sum of even value lesser than 4 millions is {result}");
      Display("---------------------------------------------------------------------");
      Display("Problem 3");
      /*
       The prime factors of 13195 are 5, 7, 13 and 29.
       What is the largest prime factor of the number 600851475143 ?
      */
      //long number3 = 600851475143;
      List<long> list3 = new List<long>();
      //list3 = GetDivisors(number3);
      //for (long i = 3; i < number3; i = i + 2)
      //{
      //  if (number3 % i == 0)
      //  {
      //    list3.Add(i);
      //  }

      //  //Console.WriteLine(i);
      //}

      //Display($"The largest prime factor of the number 600851475143 is {list3.ToList().Max()}");
      Display("The largest prime factor of the number 600851475143 is being calculated");
      Display("---------------------------------------------------------------------");
      Display("Problem 4");
      /*
       A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
       Find the largest palindrome made from the product of two 3-digit number
       */
      List<int> list4 = new List<int>();
      for (int i = 999; i >= 100; i--)
      {
        for (int j = 999; j >= 100; j--)
        {
          if (IsPalindrome(i * j))
          {
            list4.Add(i * j);
          }
        }
      }

      Display($"The largest palindrome made from the product of two 3-digit number is {list4.ToList().Max()}");
      Display("---------------------------------------------------------------------");
      Display("Problem 5");
      /*
       2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
       
       What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
       */
      int maxValue = 5000;
      int result5 = 0;
      for (int i = 20; i < maxValue; i++)
      {
        bool divisor = true;
        for (int j = 1; j < 21; j++)
        {
          if (i % j != 0)
          {
            divisor = false;
            break;
          }
        }

        if (divisor)
        {
          result5 = i;
          break;
        }
        //Display($"i={i}");
      }

      Display($"The smallest positive number that is evenly divisible by all of the numbers from 1 to 20 is {result5}");
      Display("---------------------------------------------------------------------");
      Display("Problem 6");
      /*
       The sum of the squares of the first ten natural numbers is,
       1^2 + 2^2 + ... + 10^2 = 385
       The square of the sum of the first ten natural numbers is,
       (1 + 2 + ... + 10)^2 = 552 = 3025
       Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
       Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
       */
      long result6 = 0;

      Display($"The difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is {result6}");
      Display("---------------------------------------------------------------------");
      Display("Problem 7");
      /*
       By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
       What is the 10 001st prime number?
       */
      int tenThousandAndOnePrimeCounter = 1;
      int counter = 3;
      while (tenThousandAndOnePrimeCounter != 10001)
      {
        if (IsPrime(counter))
        {
          tenThousandAndOnePrimeCounter++;
        }

        //Display($"Number of prime found so far: {tenThousandAndOnePrimeCounter} and prime being checked: {counter}");
        counter = counter + 2;
      }

      Display($"The 10 001st prime number is {counter}");
      Display("---------------------------------------------------------------------");
      Display("Problem 8");
      /*
       The four adjacent digits in the 1000-digit number that have the greatest product are 9 × 9 × 8 × 9 = 5832.

        73167176531330624919225119674426574742355349194934
        96983520312774506326239578318016984801869478851843
        85861560789112949495459501737958331952853208805511
        12540698747158523863050715693290963295227443043557
        66896648950445244523161731856403098711121722383113
        62229893423380308135336276614282806444486645238749
        30358907296290491560440772390713810515859307960866
        70172427121883998797908792274921901699720888093776
        65727333001053367881220235421809751254540594752243
        52584907711670556013604839586446706324415722155397
        53697817977846174064955149290862569321978468622482
        83972241375657056057490261407972968652414535100474
        82166370484403199890008895243450658541227588666881
        16427171479924442928230863465674813919123162824586
        17866458359124566529476545682848912883142607690042
        24219022671055626321111109370544217506941658960408
        07198403850962455444362981230987879927244284909188
        84580156166097919133875499200524063689912560717606
        05886116467109405077541002256983155200055935729725
        71636269561882670428252483600823257530420752963450
        Find the thirteen adjacent digits in the 1000-digit number that have the greatest product. What is the value of this product?
        */
      string ThousandDigitNumber = @"7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
      List<long> list8 = new List<long>();
      for (int i = 0; i < ThousandDigitNumber.Length - 13; i++)
      {
        list8.Add(Multiply(ThousandDigitNumber.Substring(i, 13)));
      }

      Display($"The thirteen adjacent digits in the 1000-digit number that have the greatest product is {list8.ToList().Max()}");
      Display("---------------------------------------------------------------------");
      Display("Problem 9");
      /*
       A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a2 + b2 = c2
       For example, 32 + 42 = 9 + 16 = 25 = 52.
       There exists exactly one Pythagorean triplet for which a + b + c = 1000.
       Find the product abc.
       */
      int result9 = 0;
      for (int a = 0; a < 1001; a++)
      {
        for (int b = a + 1; b < 1000; b++)
        {
          for (int c = b + 1; c < 1000; c++)
          {
            if ((a + b + c == 1000) && (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)))
            {
              result9 = a * b * c;
              Display($"a={a}, b={b}, c={c}");
              break;
            }
          }

          if (result9 != 0) break;
        }

        if (result9 != 0) break;
      }

      Display($"Find the product abc of the Pythagorean triplet for which a + b + c = 1000 is {result9}");
      Display("---------------------------------------------------------------------");
      Display("Problem 10");
      /*
        The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        Find the sum of all the primes below two million.
       */
      //long result10 = 1;
      List<int> list10 = new List<int>();
      counter = 3;
      // uncomment to verify the result
      //while (counter < 2000000)
      //{
      //  if (IsPrime(counter))
      //  {
      //    list10.Add(counter);
      //    result10 += counter;
      //  }
      //  Display($"counter: {counter}");
      //  counter = counter + 2;
      //}

      //Display($"The sum of all the primes below two million is {result10}");
      Display($"The sum of all the primes below two million is 142 913 828 921");
      Display("---------------------------------------------------------------------");
      Display("Problem 11");
      /*
       In the 20×20 grid below, four numbers along a diagonal line have been marked in red.

          08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08
          49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00
          81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65
          52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91
          22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80
          24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50
          32 98 81 28 64 23 67 10>26<38 40 67 59 54 70 66 18 38 64 70
          67 26 20 68 02 62 12 20 95>63<94 39 63 08 40 91 66 49 94 21
          24 55 58 05 66 73 99 26 97 17>78<78 96 83 14 88 34 89 63 72
          21 36 23 09 75 00 76 44 20 45 35>14<00 61 33 97 34 31 33 95
          78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92
          16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57
          86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58
          19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40
          04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66
          88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69
          04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36
          20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16
          20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54
          01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48

        The product of these numbers is 26 × 63 × 78 × 14 = 1788696.
        What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?
        */
      //string grid11 = @"08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08 49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00 81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65 52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91 22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80 24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50 32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70 67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21 24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72 21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95 78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92 16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57 86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58 19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40 04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66 88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69 04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36 20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16 20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54 01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";
      List<long> list11 = new List<long>();
      //for (int i = 0; i < grid11.Length - 192; i++)
      //{
      //  int a = int.Parse(grid11.Substring(i, 2));
      //  int b = int.Parse(grid11.Substring(i + 64, 2));
      //  int c = int.Parse(grid11.Substring(i + 128, 2));
      //  int d = int.Parse(grid11.Substring(i + 192, 2)); // bug
      //  list11.Add(a * b * c * d);
      //}

      //Display($"The greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid is {list11.ToList().Max()}");
      Display("---------------------------------------------------------------------");
      Display("I have skipped problem 12 and 13");
      Display("---------------------------------------------------------------------");
      Display("Problem 14");
      /*
       The following iterative sequence is defined for the set of positive integers:
       n → n/2 (n is even)
       n → 3n + 1 (n is odd)
       Using the rule above and starting with 13, we generate the following sequence:
       13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

       It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
       Which starting number, under one million, produces the longest chain?
       NOTE: Once the chain starts the terms are allowed to go above one million.
       */

      var dico14 = new Dictionary<int, string>();
      var max15 = 1000;
      for (int i = 1; i < max15; i++)
      {
        dico14[i] = GetSeries14(i);
      }


      Display($"The starting number, under one million, which produces the longest chain is {dico14.Values.Max()}");
      Display("---------------------------------------------------------------------");
      Display("Problem 15");
      /*
        
       */
      Display("---------------------------------------------------------------------");
      Display("Problem 29");
      /*
       Consider all integer combinations of ab for 2 ≤ a ≤ 5 and 2 ≤ b ≤ 5:
       2^2=4, 2^3=8, 2^4=16, 2^5=32
       3^2=9, 3^3=27, 3^4=81, 3^5=243
       4^2=16, 4^3=64, 4^4=256, 4^5=1024
       5^2=25, 5^3=125, 5^4=625, 5^5=3125
       If they are then placed in numerical order, with any repeats removed, we get the following sequence of 15 distinct terms:
       4, 8, 9, 16, 25, 27, 32, 64, 81, 125, 243, 256, 625, 1024, 3125
       How many distinct terms are in the sequence generated by ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100?
       */
      var result29 = new List<double>();
      double[,] array29 = new double[101, 101];

      for (int a = 2; a < 101; a++)
      {
        for (int b = 2; b < 101; b++)
        {
          array29[a, b] = (double)Math.Pow(a, b);
        }
      }

      for (int a = 2; a < 101; a++)
      {
        for (int b = 2; b < 101; b++)
        {
          if (!result29.Contains(array29[a, b]))
          {
            result29.Add(array29[a, b]);
          }

        }
      }

      Display($"The number of distinct terms are in the sequence generated by ab for 2 ≤ a ≤ 100 and 2 ≤ b ≤ 100 is {result29.Count}");
      Display("---------------------------------------------------------------------");
      Display("Problem 30");
      /*
       Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
       1634 = 1^4 + 6^4 + 3^4 + 4^4
       8208 = 8^4 + 2^4 + 0^4 + 8^4
       9474 = 9^4 + 4^4 + 7^4 + 4^4
       As 1 = 14 is not a sum it is not included.
       The sum of these numbers is 1634 + 8208 + 9474 = 19316.
       Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
       */
      var result30 = new List<string>();
      var result301 = new List<int>();
      for (int number = 10000; number < 99999; number++)
      {
        int a = int.Parse(number.ToString().Substring(0, 1));
        int b = int.Parse(number.ToString().Substring(1, 1));
        int c = int.Parse(number.ToString().Substring(2, 1));
        int d = int.Parse(number.ToString().Substring(3, 1));
        int e = int.Parse(number.ToString().Substring(4, 1));
        double tempNumber = Math.Pow(a, 5) + Math.Pow(b, 5) + Math.Pow(c, 5) + Math.Pow(d, 5) + Math.Pow(e, 5);
        if (number == tempNumber)
        {
          result30.Add($"{number} = {a}^5 + {b}^5 + {c}^5 + {d}^5 + {e}^5");
          result301.Add(number);
        }
      }

      long result30Final = 0;
      foreach (int number in result301)
      {
        result30Final += number;
      }

      foreach (string item in result30)
      {
        Display(item);
      }

      Display($"The sum of all the numbers that can be written as the sum of fifth powers of their digits  is {result30Final}");
      Display("---------------------------------------------------------------------");
      Display("Problem 31");
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
      for (int a = 1; a < 201; a++)
      {
        for (int b = 1; b < 201; b++)
        {
          for (int c = 1; c < 201; c++)
          {
            for (int d = 1; d < 201; d++)
            {
              for (int e = 1; e < 201; e++)
              {
                for (int f = 1; f < 201; f++)
                {
                  for (int g = 1; g < 201; g++)
                  {
                    for (int h = 1; h < 201; h++)
                    {
                      Console.WriteLine($"a={a}-b={b}-c={c}-d={d}-e={e}-f={f}-g={g}-h={h}--counter={counter31}");
                      if ((a*200)+(b*100)+(c*50)+(d*20)+(e*10)+(f*5)+(g*2)+(h*1) == 200)
                      {
                        result31.Add($"a={a}-b={b}-c={c}-d={d}-e={e}-f={f}-g={g}-h={h}");
                        counter31++;
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
      //foreach (int number in pences)
      //{
      //  string tmpString = string.Empty;
      //  int tmpNumber = 0;
      //  int tmpTotal = 0;
      //  int tmpCounter = factorMin;
      //  while (tmpCounter <= factorMax)
      //  {

      //  }
      //}
      //while (true)
      //{
      //  string tmpString = string.Empty;
      //  int tmpTotal = 0;
      //  int tmpCounter = 1;
      //  foreach (int number in pences)
      //  {
      //    while (tmpTotal < searchedValue)
      //    {
      //      tmpTotal += number * tmpCounter;
      //      tmpString = $"{number} x {tmpCounter} + ";
      //    }
      //  }
      //}


      Display("End of problems");
      Console.ReadKey();
    }

    public static string GetSeries14(int number)
    {
      if (number == 1) return "1";
      string result14 = string.Empty;
      while (number != 1)
      {
        result14 += number + "-";
        number = FunctionProblem14(number);
      }

      result14 += number;
      return result14;
    }

    public static int FunctionProblem14(int number)
    {
      if (number % 2 == 0) // even
      {
        return number / 2;
      }
      else
      {
        // number is odd
        return (3 * number) + 1;
      }
    }

    private static long Multiply(string number)
    {
      long result = 1;
      for (int i = 0; i < number.Length; i++)
      {
        result *= long.Parse(number.Substring(i));
      }

      return result;
    }

    private static bool IsPrime(int number)
    {
      bool result = true;
      if (number == 2) return true;

      if (number % 2 == 0)
      {
        return false;
      }

      for (int i = 3; i < number; i = i + 2)
      {
        if (number % i == 0)
        {
          result = false;
          break;
        }
      }

      return result;
    }

    private static bool IsPalindrome(int number)
    {
      return number.ToString() == new string(number.ToString().Reverse().ToArray());
    }

    private static List<long> GetDivisors(long number)
    {
      List<long> result = new List<long>();
      for (long i = 3; i < number; i = i + 2)
      {
        if (number % i == 0)
        {
          result.Add(i);
        }
      }

      return result;
    }
  }
}
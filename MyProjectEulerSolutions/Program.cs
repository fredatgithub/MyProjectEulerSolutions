﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProjectEulerSolutions
{
  class Program
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
        var number = list[i-1] + list[i-2];
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
      long number3 = 600851475143;
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

      Display("End of problems");
      Console.ReadKey();
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
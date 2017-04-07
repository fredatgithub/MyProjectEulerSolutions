using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProjectEulerSolutions
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Project Euler - problème 1");
      /*
       If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
       Find the sum of all the multiples of 3 or 5 below 1000.
       */
      var multipleDeTrois = new List<int>();
      var multipleDeCinq = new List<int>();
      for (int i = 1; i < (1000/3)+1; i++)
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

      Console.WriteLine($"La somme des multiple de 3 et de 5 inférieur à 1000 est de : {somme}");
      Console.WriteLine("Fin des traitements");
      Console.ReadKey();
    }
  }
}
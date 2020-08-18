using System;
using System.Linq;
using System.Collections.Generic;

namespace LearnLinq
{
  class Program
  {
    static void Main()
    {
      List<string> heroes = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
  
      var shortHeroes = from h in heroes
                        where h.Length < 8
                        select h;

      // Printing...
      Console.WriteLine("Your short heroes are...");
      
      foreach (string hero in shortHeroes)
      {
        Console.WriteLine(hero);
      }

      var longHeroes = heroes.Where(n => n.Length > 8);
      Console.WriteLine(longHeroes.Count());

      //Query syntax
      var heroesWithI = from hero in heroes
                        where hero.Contains("i")
                        select hero;
      /* Method Syntax
      var heroesWithI = heroes.Where(h => h.Contains("i"));
      foreach (string h in heroesWithI)
      {
        Console.WriteLine(h);
      }
      */
      var underscored = from hero in heroes
                        select hero.Replace(' ', '_');

      /*
      // Query syntax
      var longLoudheroes = from h in heroes
                           where h.Length > 6
                           select h.ToUpper();

      // Method syntax - separate statements
      var longHeroes = heroes.Where(h => h.Length > 6);
      var longLoudHeroes = longHeroes.Select(h => h.ToUpper());

      // Method syntax - chained expressions
      var longLoudHeroes2 = heroes
        .Where(h => h.Length > 6)
        .Select(h => h.ToUpper());

      var longHeroes = heroes.Where(h => h.Length > 6);
      var longLoudHeroes = longHeroes.Select(h => h.ToUpper());
      var longLoudHeroes = heroes
                          .Where(h => h.Length > 6)
                          .Select(h => h.ToUpper());   
      */

      var lowerHeroes = heroes.Where(h => h.Contains("c"));
      var lowerHeroesWithC = lowerHeroes.Select(h => h.ToLower());
      var sameResult = heroes
      .Where(h => h.Contains("c"))
      .Select(h => h.ToLower());
      foreach(string h in sameResult)
      {
        Console.WriteLine(h);
      }         
      // Method syntax
      var result = heroes.Select(h => $"Introducing...{h}!");
      
      // Query syntax
      var result2 = from h in heroes
        where h.Contains(" ")
        select h.IndexOf(" ");
      
      // Printing...
      Console.WriteLine("'result': ");
      foreach (var v in result)
      {
        Console.WriteLine(v);
      }
      
      Console.WriteLine("\n'result2': ");
      foreach (var v in result2)
      {
        Console.WriteLine(v);
      }

      List<string> heroesList = new List<string> { "D. Va", "Lucio", "Mercy", "Soldier 76", "Pharah", "Reinhardt" };
      var heroesWithSpecialChars = heroesList.Where(h => h.Contains('.') || h.Contains('7'));
      
      foreach (var v in heroesWithSpecialChars)
      {
        Console.WriteLine(v);
      }         
      
      // Query syntax
      var queryResult = from h in heroesList
        where h.Contains("a")
        select $"{h} contains an 'a'";
     
      // Printing...
      Console.WriteLine($"queryResult has {queryResult.Count()} elements");
      
      foreach (string s in queryResult)
      {
        Console.WriteLine(s);
      }
    }
  }
}
using System;

namespace StringTheException
{
  class Program
  {
    static void Main(string[] args)
    {
        // Example 1
        string dog = "chihuahua";
        string tinyDog = dog;
        dog = "dalmation";
        Console.WriteLine(dog);
        // Output: "dalmation"
        Console.WriteLine(tinyDog);
        // Output: "chihuahua"

        // Example 2
        string s1 = "Hello ";
        string s2 = s1;
        s1 += "World";
        System.Console.WriteLine(s1);
        // Output: "Hello World"
        System.Console.WriteLine(s2);
        // Output: "Hello"

        //string s = String.Empty;
        //bool isEmpty = String.IsNullOrEmpty(s);
        string s3 = "";
        Console.WriteLine("Write Something: ");
        s3 = Console.ReadLine();
        Console.WriteLine($"You wrote:\n{s3}");
        if (String.IsNullOrEmpty(s3))
        {
            Console.WriteLine("You didn't enter anything!");
        }
        else
        {
            Console.WriteLine("Thank you for your submission!");
        }

        string lyrics = 
        "Dollie, Dollie, bo-bollie,\n" +
        "Banana-fana fo-follie\n" +
        "Fee-fi-mo-mollie\n" +
        "Dollie!";
      
        // Call `Replace()` here
        lyrics = lyrics.Replace("ollie", "ana");
        
        Console.WriteLine(lyrics);
    }
  }
}

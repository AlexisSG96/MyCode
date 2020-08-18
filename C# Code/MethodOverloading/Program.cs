using System;

namespace MethodOverloading
{
  class Program
  {
    static void Main(string[] args)
    {
      NamePets();
      NamePets("Laika", "Albert");       
      NamePets("Mango", "Puddy", "Bucket");
    }
    static void NamePets(){
      Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
    static void NamePets(string x, string y){
      Console.WriteLine("Your pets {x} and {y} will be joining your voyage across space!");
    }
    static void NamePets(string x, string y, string z){
      Console.WriteLine($"Your pets {x}, {y}, and {z} will be joining your voyage across space!");
    }
  }
}

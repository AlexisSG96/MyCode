using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
      //Forest f = new Forest("Amazon");
      Forest f = new Forest();
      Console.WriteLine(f.Name);
      Console.WriteLine(f.Biome);
      Console.WriteLine(f.Age);
      Console.WriteLine(f.Trees);
      f.Grow();
      Console.WriteLine(f.Trees);
    }
  }
}

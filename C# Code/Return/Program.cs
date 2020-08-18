using System;

namespace Return
{
  class Program
  {
    static void Main(string[] args)
    {
      string output = DecoratePlanet("Jupiter");
      Console.WriteLine(output);
    }
    static string DecoratePlanet(string planetName){
      string fancy = $"Welcome to the planet, {planetName}!";
      return fancy;
    }
	}
}

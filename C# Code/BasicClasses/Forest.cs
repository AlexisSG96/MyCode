using System;

namespace BasicClasses
{
  class Forest
  {
    public int age;
    private string biome;
    
    public Forest(string name, string biome, int age)
    {
      this.Name = name;
      this.Biome = biome;
      this.Age = age;
    }
    
    // More modern way to write constructors
    // public Forest(string name, string biome = "Unknown", int age = 0)
    // {
    //     this.Name = name;
    //     this.Biome = biome;
    //     this.Age = age;
    // }

    public Forest(string name) : this(name, "Unknown", 2)
    { 
        Console.WriteLine("Biome property not specified. Value defaulted to 'Unknown'.");
    }

    public Forest() : this("Uknown", "Unknown", 0)
    { 
        Console.WriteLine("All properties not specified. Value defaulted to 'Unknown'.");
    }
    
    public string Name
    { get; set; }
    
    public int Trees
    { get; set; }
    
    public string Biome
    {
      get { return biome; }
      set
      {
        if (value == "Tropical" ||
            value == "Temperate" ||
            value == "Boreal")
        {
          biome = value;
        }
        else
        {
          biome = "Unknown";
        }
      }
    }
    
    public int Age
    { 
      get { return age; }
      private set { age = value; }
    }
     
    public int Grow()
    {
      Trees += 30;
      Age += 1;
      return Trees;
    }
    
    public int Burn()
    {
      Trees -= 20;
      Age += 1;
      return Trees;
    }
    
  }

}

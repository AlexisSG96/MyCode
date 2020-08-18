using System;

namespace BuildingArrays
{
  class Program
  {
    static void Main(string[] args)
    {
        string[] summerStrut;
        summerStrut = new string[] {"Juice",
                                    "Missing U",
                                    "Raspberry Beret",
                                    "New York Groove",
                                    "Make Me Feel",
                                    "Rebel Rebel",
                                    "Despacito",
                                    "Los Angeles"};
        //This will cause an error
        //summerStrut = {"Juice", "Missing U"};
        int[] ratings = new int[]{1, 2, 3, 4, 5};
        //This also works
        //int[] ratings = {1, 2, 3, 4, 5}
    }
  }
}

using System;

namespace LearnInterfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Sedan s = new Sedan(60);
      Sedan s2 = new Sedan(70);
      Truck t = new Truck(45, 500);
      Console.WriteLine($"First Sedan: Speed: {s.Speed} Wheels: {s.Wheels} LicensePlate = {s.LicensePlate}");
      Console.WriteLine($"Second Sedan: Speed: {s2.Speed} Wheels: {s2.Wheels} LicensePlate = {s2.LicensePlate}");
      Console.WriteLine($"First Truck: Speed: {t.Speed} Wheels: {t.Wheels} LicensePlate = {t.LicensePlate}");
      s.SpeedUp();
      s2.SpeedUp();
      t.SpeedUp();
      Console.WriteLine($"Speed: {s.Speed}");
      Console.WriteLine($"Speed: {s2.Speed}");
      Console.WriteLine($"Speed: {t.Speed}");
    }
  }
}
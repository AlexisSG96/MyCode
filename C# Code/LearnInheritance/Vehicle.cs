using System;

namespace LearnInheritance
{
  abstract class Vehicle
  {
    public string LicensePlate
    { get; private set; }

    public double Speed
    { get; protected set; }

    public int Wheels
    { get; protected set; }

    public virtual void SpeedUp()
    {
      Speed += 5;
    }

    public virtual void SlowDown()
    {
      Speed -= 5;
    }
    
    public void Honk()
    {
      Console.WriteLine("HONK!");
    }

    public Vehicle (double speed)
    {
      Speed = speed;
      LicensePlate = generateLicensePlate(8);
    }

    public string generateLicensePlate(int stringLength){
        Random rd = new Random();
        const string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
        char[] chars = new char[stringLength];

        for (int i = 0; i < stringLength; i++)
        {
            chars[i] = allowedChars[rd.Next(0, allowedChars.Length)];
        }
        return new string(chars);
    }
    public abstract string Describe();
  }
}
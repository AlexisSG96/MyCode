using System;

namespace UTC_Conversion
{
    class Program
    {
        public static void Main()
        {
        DateTime saveNow = DateTime.Now;

        DateTime saveUtcNow = DateTime.UtcNow;
        DateTime myDt;

        DisplayNow("UtcNow: ..........", saveUtcNow);
        DisplayNow("Now: .............", saveNow);
        DisplayNow("12 Hours:.........", saveNow.AddHours(12));
        DisplayNow("12 Hours UTC:.....", saveUtcNow.AddHours(12));
        Console.WriteLine();

        myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Utc);
        Display("Utc: .............", myDt);

        myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Local);
        Display("Local: ...........", myDt);

        myDt = DateTime.SpecifyKind(saveNow, DateTimeKind.Unspecified);
        Display("Unspecified: .....", myDt);
        }

        public static string datePatt = @"M/d/yyyy hh:mm:ss tt";
        public static void Display(string title, DateTime inputDt)
        {
        DateTime dispDt = inputDt;
        string dtString;

        dtString = dispDt.ToString(datePatt);
        Console.WriteLine("{0} {1}, Kind = {2}",
                        title, dtString, dispDt.Kind);

        dispDt = inputDt.ToLocalTime();
        dtString = dispDt.ToString(datePatt);
        Console.WriteLine("  ToLocalTime:     {0}, Kind = {1}",
                        dtString, dispDt.Kind);

        dispDt = inputDt.ToUniversalTime();
        dtString = dispDt.ToString(datePatt);
        Console.WriteLine("  ToUniversalTime: {0}, Kind = {1}",
                        dtString, dispDt.Kind);
        Console.WriteLine();
        }

        public static void DisplayNow(string title, DateTime inputDt)
        {
        string dtString = inputDt.ToString(datePatt);
        Console.WriteLine("{0} {1}, Kind = {2}",
                        title, dtString, inputDt.Kind);
        }
    }
}

using System;

namespace CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"parameter count = {args.Length}");

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg[{i}] = [{args[i]}]");
            }
        }
    }
}

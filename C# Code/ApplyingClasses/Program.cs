using System;

namespace ApplyingClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string mainPhrase = String.Join(" and ", args);
                Console.WriteLine($"My favorite fruits are {mainPhrase}!");
            }
        }
    }
}
/*
Main() is a method of the Program class.
public — The method can be called outside the Program class.
static — The method is called from the class name: Program.Main().
void — The method means returns nothing.
string[] args — The method has one parameter named args, which is an array of strings.
Main() is like any other method you’ve encountered. It has a special use for C#, but that doesn’t mean you can’t treat it like a plain old method!

Each time we run dotnet run, the Main() method is called. We can include arguments on the command line, like dotnet run arg1 arg2 arg3 that will be
converted into an array as the args parameter. In the console, enter:
    
dotnet run mango pineapple lychee
*/
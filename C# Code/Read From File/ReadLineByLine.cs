using System;
using System.IO;
using System.Collections.Generic;

namespace Read_From_File
{
    class ReadLineByLine
    {
        private List<string> s = new List<string>();
        public void doThatThing(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);  
            foreach (string line in lines)
            {
                Console.WriteLine(line);  
                string[] ssize = line.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                foreach (string c in ssize)
                {
                    s.Add(c);
                }
            }
            s.Sort();
            string[] newArray = s.ToArray();
            /*
            foreach(string character in s)
            {
                Console.WriteLine(character);
            }
            */
            Console.WriteLine($"{0}", String.Join(" ", newArray));
            // foreach(string s in newArray)
            // {
            //     Console.WriteLine(s);
            // }
        }
    }
}
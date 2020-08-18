using System;
using System.IO;

namespace Read_From_File
{
    class ReadEntireText
    {
        public void doThatThing(string filePath)
        {
            string text = File.ReadAllText(filePath);  
            Console.WriteLine(text);  
        }
    }
}
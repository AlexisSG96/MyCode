using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Read_From_File
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayBongo BC = new PlayBongo();
        }

        static void Test()
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();
            string FileName = "Sample.txt";
            string FilePath = CurrentDirectory + @"\" + FileName;

            //runStreamReaderClass(FilePath);
            //runReadEntireText(FilePath);
            runReadLineByLine(FilePath);
        }

        static void runStreamReaderClass(string FilePath)
        {
            streamreader_class s = new streamreader_class();
            s.doThatThing(FilePath);
        }
        
        static void runReadEntireText(string FilePath)
        {
            ReadEntireText r = new ReadEntireText();
            r.doThatThing(FilePath);
        }
        
        static void runReadLineByLine(string FilePath)
        {
            ReadLineByLine r = new ReadLineByLine();
            r.doThatThing(FilePath);
        }
    }
}

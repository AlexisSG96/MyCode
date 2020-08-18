using System;
using System.IO;

namespace Read_From_File
{
    class streamreader_class
    {
        public void doThatThing(string filePath)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                using(StreamReader sr = new StreamReader(filePath)){
                    int counter = 0;
                    string ln = "";
                    //Continue to read until you reach end of file
                    while ((ln = sr.ReadLine()) != null)
                    {
                        //write the line to console window
                        Console.WriteLine(ln);
                        counter++;
                    }
                    //close the file
                    sr.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
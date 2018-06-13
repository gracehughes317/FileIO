using System;
using System.Windows;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack overflow below
            string winDir = System.Environment.GetEnvironmentVariable("windir");
            StreamReader reader = new StreamReader(winDir + "\\system.ini");

            Console.WriteLine("Name of data file");
            string fileName = Console.ReadLine();

            //method that retrieves the next line
            //reader.ReadLine();
        }
    }
}

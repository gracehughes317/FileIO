﻿using System;
using System.Windows;
using System.IO;
using System.Collections.Generic;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Name of data file:");
            string fileName = Console.ReadLine();

            DataFile file = new DataFile(fileName);
            List<int> nums = file.GetList();
            SumAndList sumer = new SumAndList();
            sumer.DisplayList(nums);
            Console.WriteLine("Sum: " + sumer.Sum(nums));
            Console.WriteLine("Every 5th Number:");
            Every5 fives = new Every5(nums);
            fives.every5();
            Console.WriteLine("Evens and Odds:");
            evenodd eAndO = new evenodd();
            eAndO.evensodd(nums);

            Console.ReadKey();
        }
    }
}

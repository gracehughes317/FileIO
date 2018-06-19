using System;
using System.IO;
using System.Collections.Generic;

public class SumAndList
{
    public SumAndList()
    {
    }

    public int Sum(List<int> intList)
        {
            int count = 0;
            foreach (int number in intList)
            {
                count += number;
            }
            return count;
        }

        public void DisplayList(List<int> intList)
        {
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
	    }
}

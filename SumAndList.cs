using System;
using System.IO;

public class SumAndList
{
    public SumAndList()
    {
    }
   

        int sum(List<int> intList)
        {
            int count = 0;
            foreach (int number in intList)
            {
                count += number;
            }
            return count;
        }

        void displayList(List<int> intList)
        {
            foreach (int number in intList)
            {
                Console.WriteLine(number);
            }
	    }
}

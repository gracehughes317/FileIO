using System;
using System.Collections.Generic;

public class evenodd
{
	public void evensodd(List<int> x)
	{
        foreach (int i in x)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine(i + " Even");
            }
            if ((i % 2) != 0)
            {
                Console.WriteLine(i + " Odd");
            }
        }
	}
}

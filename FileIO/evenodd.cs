using System;
using System.Collections.Generic;

public class evenodd
{
	public void evensodd(List<int> x)
	{
        for(int i = 0; i < 0; i++)
        {
            if (((x.get(i)) % 2) == 0)
            {
                Console.WriteLine(x.get(i) + " Even");
            }
            if (((x.get(i)) % 2) != 0)
            {
                Console.WriteLine(x.get(i) + " Odd");
            }
        }
	}
}

using System;
using System.Collections.Generic;

public class DivBy3
{
    List<int> list = new List<int>();

    public DivBy3(List<int> list)
	{
        this.list = list;
    }

    public void showAllDivBy3()
    {
        foreach (int i in list)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

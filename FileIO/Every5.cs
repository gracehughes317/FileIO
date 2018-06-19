using System;
using System.Collections.Generic;
using System.Linq;

public class Every5
{
    private List<int> list = new List<int>();

    public Every5(List<int> xList)
    {
        list = xList;
    }

    public void every5()
    {
        for (int x = 0; x < list.Count; x += 5)
        {
            Console.WriteLine(list.ElementAt(x));
        }

    }
}


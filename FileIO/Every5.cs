using System;
using System.Collections.Generic;

public class Every5
{
    List<int> list = new List<int>();

    public Every5(List<int> xList)
    {
        this.list = xList;
    }

    public void every5()
    {
        for (int x = 0; x < list.Count; x += 5)
        {
            Console.WriteLine(list[x]);
        }

    }
}


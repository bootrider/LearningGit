using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Excercise
{
    public long Run(int top)
    {
        var range = Enumerable.Range(2, top - 2);
        var multiples = new ConcurrentBag<long>();
        Parallel.ForEach(range,
        num =>
        {            
            if (this.IsMultiple3or5(num))
            {
                multiples.Add(num);
            }
        });

        return multiples.ToList().Sum();
    }

    public int RunSerialized(int top)
    {
        int suma = 0;
        for (int i = 0; i < top; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                suma += i;
        }

        return suma;
    }

    private bool IsMultiple3or5(int number)
    {
        if (number % 3 == 0 || number % 5 == 0)
        {
            return true;
        }

        return false;
    }
}
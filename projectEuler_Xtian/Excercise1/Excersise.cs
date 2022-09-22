using System;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Collections.Generic;

public class Excercise
{
    public int Run(int top)
    {
        var range = Enumerable.Range(2, top - 2);
        var multiples = new ConcurrentBag<int>();        
        Parallel.ForEach(range,
        num=>{
            if (this.IsMultiple3or5(num))
            {
                multiples.Add(num);
                Console.WriteLine(num);
            }          
        });

        return multiples.ToList().Sum();
    }   

    private bool IsMultiple3or5(int number) 
    {
        if (number % 3 ==0 || number % 5 == 0)
        {
            return true;
        }

        return false;
    }
}
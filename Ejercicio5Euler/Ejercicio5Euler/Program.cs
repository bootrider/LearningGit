using System.Reflection;
using System;

namespace Ejercicio5Euler
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public int numDivisibleForAll(int inicio, int fin)
        {
            bool bandera = true;
            int num = fin;

            while (bandera)
            {
                bandera = false;
                for (int i=1; i<=fin; i++)
                {
                    if (num % i != 0)
                    {
                        num += 1;
                        bandera = true;
                        break;
                    }
                }
            }
            return num;
        }
    }
}
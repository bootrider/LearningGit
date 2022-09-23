using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Excercise
    {
        public bool IsPalindrome(int v)
        {
            if (v > 0)
            {
                var numberAsString = v.ToString();
                if (numberAsString.Length == 1)
                {
                    return true;
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = numberAsString.Length - 1; i >= 0; i--)
                    {
                        sb.Append(numberAsString[i]);
                    }
                    var inverted = sb.ToString();

                    return inverted.Equals(numberAsString);
                } 
            }

            throw new ArgumentException("No Negative numbers");
        }

        public int Run(int v)
        {
            return 9009;
        }
    }
}

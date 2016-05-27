using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPlatform.Course
{
    public class DefaultClass
    {
        static void Main(String[] args)
        {
       
            Int64 n = Int64.Parse(Console.ReadLine());
            System.Console.WriteLine(getFibonacciLastDigit(n));
        }

        public static Int64 getFibonacciLastDigit(Int64 n)
        {
            return calc_fib(n) % 10;
        }

        public static Int64 calc_fib(Int64 n)
        {
            Int64[] fib = new Int64[n+1];
            Int64 retorno = 0;

            for (Int64 x = 0; x < n + 1; x++)
            {

                if (x <= 1)
                {
                    retorno = x;
                }
                else {
                    retorno = (fib[x - 1] + fib[x - 2])%10;
                }

                fib[x] = retorno;
            }

            return retorno;
        }


    }
}

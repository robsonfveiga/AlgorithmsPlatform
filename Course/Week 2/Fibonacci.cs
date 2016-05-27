using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Course.Week_2
{
    class Fibonacci : ITestable
    {
        public void run(StreamReader Console)
        {
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine(calc_fib(n));
        }


        public static long calc_fib(int n)
        {
            List<int> fib = new List<int>(n);
            int retorno = 0;

            for(int x = 0;x < n+1; x++){

                if (x <= 1)
                {
                    retorno = x;
                }
                else {
                    retorno = fib[x - 1] + fib[x - 2];
                }
             
                fib.Add(retorno);
            }

            return retorno;
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms.WorldMay
{
    class DivAndSpan : ITestable
    {
        public void run(StreamReader Console)
        {
            int t = int.Parse(Console.ReadLine());
            int[] values;
            int n,x,y;
            for (int xx = 0;xx< t; xx++) { 
                values  = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
                x = values[0];
                y = values[1];
                n = x + y;
                System.Console.WriteLine(fatorial(n) * n);
            }

        }

        public long fatorial(int n) {
            int c;
            long result = 1;

            for (c = 1; c <= n; c++)
                result = result * c;

            return result;
        }
    }
}

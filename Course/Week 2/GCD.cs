using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Course.Week_2
{
    class GCD : ITestable
    {
        public void run(StreamReader Console)
        {
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            System.Console.Write(gcd(values[0], values[1]));
        }

        private static int gcd(int a, int b)
        {
            int resto;
            while (b != 0)
            {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
    }
}

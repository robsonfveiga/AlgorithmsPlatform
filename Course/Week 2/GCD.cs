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
            throw new NotImplementedException();
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

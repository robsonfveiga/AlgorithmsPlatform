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
            int current_gcd = 1;
            for (int d = 2; d <= a && d <= b; ++d)
            {
                if (a % d == 0 && b % d == 0)
                {
                    if (d > current_gcd)
                    {
                        current_gcd = d;
                    }
                }
            }

            return current_gcd;
        }


    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Course.Week_2
{
    class LCM : ITestable
    {
        private static int lcm(int a, int b)
        {
            int count = Math.Max(a, b);
            do {
                if (count % a == 0 && count % b == 0)
                {
                    return count;
                }
                count++;
            } while (true);
        }

        public void run(StreamReader Console)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int a = input[0];
            int b = input[1];

            System.Console.WriteLine(lcm(a, b));
        }
    }
}

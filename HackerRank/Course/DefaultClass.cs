using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsPlatform.Course
{
    public class DefaultClass
    {
        static void Mainx(String[] args)
        {

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = input[0];
            int b = input[1];

            System.Console.WriteLine(gcd(a, b));
            Console.ReadLine();
        }

        private static int gcd(int a, int b)
        {
            int current_gcd = -1;
            int count = 2;
            while (current_gcd == -1)
            {
                if (count % a == 0 && count % b == 0)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }
    }
}

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

            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int a = input[0];
            int b = input[1];

            System.Console.WriteLine(gcd(a, b));
            Console.ReadLine();
        }

        private static int gcd(int a, int b)
        {
            int resto;
            while (b != 0) {
                resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
    }
}

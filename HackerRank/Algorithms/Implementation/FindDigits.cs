using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class FindDigits : HackerRank
    {
        public void run(StreamReader Console)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < t; x++)
            {
                int n,output;
                int[] intArray;
                string input;
                
                input = Console.ReadLine();
                n = Convert.ToInt32(input);
                intArray = input.Select(i => Convert.ToInt32(i.ToString())).ToArray();

                output = 0;
                foreach (int xx in intArray) {
                    if (xx == 0)
                        continue;

                    if (n % xx == 0)
                        output++;
                }
                System.Console.WriteLine(output);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms.Implementation
{
    class SherlockAndSquares : ITestable
    {
        public void run(StreamReader Console)
        {
            int t;
            Int64[] range;
            t = Convert.ToInt32(Console.ReadLine());
            
            for (int x = 0; x < t; x++)
            {
                range = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse);
                System.Console.WriteLine((Math.Floor(Math.Sqrt(range[1])) - Math.Ceiling(Math.Sqrt(range[0])) + 1));
            }
        }
    }
}

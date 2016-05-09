using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class TimeConversion : HackerRank
    {
        public void run(StreamReader Console)
        {
            DateTime time = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine(time.ToString("HH:mm:ss"));
        }
    }
}

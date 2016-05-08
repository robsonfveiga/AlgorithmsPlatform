using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class SimpleArraySum : HackerRank
    {
        public void run(StreamReader Console)
        {
                string line1 = Console.ReadLine();
                string line2 = Console.ReadLine();
                long sum = 0;

                line2.Split(' ').ToList().ForEach(x=> {
                    sum += long.Parse(x);
                });
                System.Console.WriteLine(sum);
         

        }
    }
}

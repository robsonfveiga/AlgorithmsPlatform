using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms
{
    class Staircase : ITestable
    {
        public void run(StreamReader Console)
        {
            int height = int.Parse(Console.ReadLine())+1;
            string space, degrau;
            for (int x = 0;x< height;x++) {
                space = new String(' ', height-x);
                degrau = new String('#', x);
                System.Console.WriteLine(space+degrau);
            }

        }
    }
}

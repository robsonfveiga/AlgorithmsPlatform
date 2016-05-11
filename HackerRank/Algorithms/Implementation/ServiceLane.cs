using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class ServiceLane : HackerRank
    {
        public void run(StreamReader Console)
        {
            int t,i,j,smaller;
            int[] cAux,width,values;

            cAux = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            t = cAux[1];
        
            width = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            for (int x = 0; x < t; x++) {
                values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                i = values[0];
                j = values[1];

                smaller = width[i];
                for (int xx = i; xx <= j; ++xx) {
                    smaller = Math.Min(smaller, width[xx]);
                }
                System.Console.WriteLine(smaller);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    class KthAncestor : HackerRank
    {
        public void run(StreamReader Console)
        {
            int t,p,x,y,q;
            int[] nodes;
            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++) {

                //Numero de nodes
                p = int.Parse(Console.ReadLine());

                for (int ii = 0; ii < p; ii++) {
                    nodes = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
                    //Pai
                    y = nodes[0];
                    x = nodes[1];
                }

                //Numero de consultas
                q = int.Parse(Console.ReadLine());

            }

        }
    }
}

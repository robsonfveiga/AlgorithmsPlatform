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
            int[] nodes,line;
            Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>();
            t = int.Parse(Console.ReadLine());
            List<int> aux;

            for (int i = 0; i < t; i++)
            {

                //Numero de nodes
                p = int.Parse(Console.ReadLine());


                //Todos Nodes baseado no numero apresentado como entrada 'p'
                for (int ii = 0; ii < p; ii++)
                {
                    nodes = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); 
                    // X = Filho
                    x = nodes[0];
                    //Y = Pai
                    y = nodes[1];

                    if (!grafo.ContainsKey(y))
                    {
                        aux = new List<int>();
                        aux.Add(x);
                        grafo.Add(y, aux);
                    }
                    else {
                        grafo[y].Add(x);
                    }
                }

                //Numero de consultas. 
                q = int.Parse(Console.ReadLine());
                for (int ii = 0; ii < q; ii++)
                {
                    line = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

                    switch (line[0]) {
                        case 0:
                        
                        break;
                        case 1:
                         
                        break;
                        case 2:
                          
                        break;

                    }

                }
            }
        }
    }
}

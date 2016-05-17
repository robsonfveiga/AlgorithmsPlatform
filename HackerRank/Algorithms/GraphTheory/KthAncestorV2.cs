using HackerRank.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.GraphTheory
{
    class KthAncestorV2 : HackerRank
    {
        Dictionary<Int64, LinkedNode<Int64>> grafo = new Dictionary<Int64, LinkedNode<Int64>>();

        public void run(StreamReader Console)
        {
            Int64 t,p,q,l;
            Int64[] nodes,line;
            Int64 x, y;

            t = Int64.Parse(Console.ReadLine());
            

            for (Int64 i = 0; i < t; i++)
            {

                //Numero de nodes
                p = Int64.Parse(Console.ReadLine());


                //Todos Nodes baseado no numero apresentado como entrada 'p'
                for (Int64 ii = 0; ii < p; ii++)
                {
                    nodes = Array.ConvertAll(Console.ReadLine().Split(' '), Int64.Parse); 
                    // X = Filho
                    x = nodes[0];
                    //Y = Pai
                    y = nodes[1];

                    this.addleaf(y, x);

                }

                //Numero de consultas. 
                q = Int64.Parse(Console.ReadLine());
                for (Int64 ii = 0; ii < q; ii++)
                {
                    line = Array.ConvertAll(Console.ReadLine().Split(),Int64.Parse);
                    y = line[1];
                
                    switch (line[0]) {
                        case 0:
                            //Adiciona valor no indice
                            x = line[2];
                            this.addleaf(y, x);
                        break;
                        case 1:
                            //Remove valor do indice
                            this.grafo.Remove(y);
                        break;
                        case 2:
                            //Imprime valor Kth parent of X
                            x = line[1];
                            l = line[2];
                            if (this.grafo.ContainsKey(x))
                            {
                                System.Console.WriteLine(this.getParent(this.grafo[x], 0, l));
                            }
                            else
                            {
                                System.Console.WriteLine(0);
                            }
                            break;
                    }
                }
            }
        }


        public Int64 getParent(LinkedNode<Int64> node,Int64 cont,Int64 limit) {

            if (node == null)
                return 0;

            if (limit!=cont) {
                cont++;
                return this.getParent(node.Previous, cont, limit);
            };
          
            return node.Value;
        }



        public void removeParent(Int64 removeKey)
        {
            this.grafo.Remove(removeKey);
        }


        public void addleaf(Int64 y, Int64 x) {
    
            if (y == 0)
            {
                if (this.grafo.ContainsKey(y))
                {
                    this.grafo[y] = new LinkedNode<Int64>(null, y);
                }
                else {
                    this.grafo.Add(y, new LinkedNode<Int64>(null, y));
                }
            }
            else {
                if (this.grafo.ContainsKey(y))
                {
                    if (this.grafo.ContainsKey(x))
                    {
                        this.grafo[x] = new LinkedNode<Int64>(this.grafo[y], x);
                    }
                    else {
                        this.grafo.Add(x, new LinkedNode<Int64>(this.grafo[y], x));
                    }
                }
                else {
                    this.grafo.Add(y, new LinkedNode<Int64>(null, y));
                    if (this.grafo.ContainsKey(x))
                    {
                        this.grafo[x] = new LinkedNode<Int64>(this.grafo[y], x);
                    }
                    else {
                        this.grafo.Add(x, new LinkedNode<Int64>(this.grafo[y], x));
                    }
                }
            }   
        }
    }
}

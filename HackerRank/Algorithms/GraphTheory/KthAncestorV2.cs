using HackerRank.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms.GraphTheory
{
    class KthAncestorV2 : ITestable
    {
        Dictionary<int, LinkedNode<int>> grafo = new Dictionary<int, LinkedNode<int>>();
        StringBuilder strB = new StringBuilder();

        public void run(StreamReader Console)
        {
            int t, p, x, y, q, l;
            int[]  line;
            string[] nodes;

            t = int.Parse(Console.ReadLine());


            for (int i = 0; i < t; i++)
            {

                //Numero de nodes
                p = int.Parse(Console.ReadLine());


                //Todos Nodes baseado no numero apresentado como entrada 'p'
                for (int ii = 0; ii < p; ii++)
                {
                    nodes = Console.ReadLine().Split(' ');
                    // X = Filho
                    x = nodes[0];
                    //Y = Pai
                    y = nodes[1];

                    this.addleaf(y, x);

                }

                //Numero de consultas. 
                q = int.Parse(Console.ReadLine());
                for (int ii = 0; ii < q; ii++)
                {
                    line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    y = line[1];

                    switch (line[0])
                    {
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
                                strB.Append(this.getParent(this.grafo[x], 0, l) + Environment.NewLine);
                                //System.Console.WriteLine();
                            }
                            else
                            {
                                strB.Append(0 + Environment.NewLine);
                            }
                            break;
                    }
                }
            }
            System.Console.Write(strB);
        }


        public int getParent(LinkedNode<int> node, int cont, int limit)
        {

            bool continuar = true;

            while (continuar)
            {
                if (node.Previous != null && limit > cont && this.grafo.ContainsKey(node.Previous.Value))
                {
                    cont++;
                    node = this.grafo[node.Previous.Value];
                }
                else
                {
                    continuar = false;
                    if (limit > cont)
                        return 0;
                }
            }

            return node.Value;
        }



        public void removeParent(int removeKey)
        {
            this.grafo.Remove(removeKey);
        }


        public void addleaf(int y, int x)
        {

            if (y == 0)
            {
                if (this.grafo.ContainsKey(x))
                {
                    this.grafo[x] = new LinkedNode<int>(this.grafo.ContainsKey(y) ? this.grafo[y] : null, x);
                }
                else
                {
                    this.grafo.Add(x, new LinkedNode<int>(this.grafo.ContainsKey(y) ? this.grafo[y] : null, x));
                }

            }
            else
            {
                if (this.grafo.ContainsKey(y))
                {
                    if (this.grafo.ContainsKey(x))
                    {
                        this.grafo[x] = new LinkedNode<int>(this.grafo[y], x);
                    }
                    else
                    {
                        this.grafo.Add(x, new LinkedNode<int>(this.grafo[y], x));
                    }
                }
                else
                {
                    this.grafo.Add(y, new LinkedNode<int>(null, y));
                    this.grafo.Add(x, new LinkedNode<int>(this.grafo[y], x));
                }
            }

        }
    }
}

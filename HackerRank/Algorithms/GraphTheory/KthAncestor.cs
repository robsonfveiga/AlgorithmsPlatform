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
        Dictionary<int, List<int>> grafo = new Dictionary<int, List<int>>();

        public void run(StreamReader Console)
        {
            int t,p,x,y,q,l;
            int[] nodes,line;
            
            t = int.Parse(Console.ReadLine());
           

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

                    this.addleaf(y, x);

                }

                //Numero de consultas. 
                q = int.Parse(Console.ReadLine());
                for (int ii = 0; ii < q; ii++)
                {
                    line = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
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
                            this.removeParent(y);
                        break;
                        case 2:
                            //Imprime valor Kth parent of X
                            x = line[1];
                            l = line[2];
                            System.Console.WriteLine(this.getParent(x,0,l));
                            break;
                    }
                }
            }
        }


        public int getParent(int ArgKey,int cont,int limit) {
            List<int> values;

            foreach (int key in this.grafo.Keys) {
                values = this.grafo[key];
                if (values.Exists(x => x == ArgKey)&& limit!=cont) {
                    cont++;
                    return getParent(key, cont,limit);
                }
            }
            if (cont != 0)
                return ArgKey;
            else {
                return 0;
            }
        }



        public void removeParent(int removeKey)
        {
            List<int> values;
            foreach (int key in this.grafo.Keys)
            {
                values = this.grafo[key];
                values.RemoveAll(x => x == removeKey);
            }
         
        }


        public void addleaf(int y, int x) {
            List<int> aux;
            if (!grafo.ContainsKey(y))
            {
                aux = new List<int>();
                aux.Add(x);
                grafo.Add(y, aux);
            }
            else
            {
                grafo[y].Add(x);
            }
        }
    }
}

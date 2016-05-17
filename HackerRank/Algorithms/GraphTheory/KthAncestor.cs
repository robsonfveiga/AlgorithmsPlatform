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
           List<int> keys = this.grafo.Keys.ToList();
           int key;
           bool continuar = true;
           bool sair = false;

            while (continuar) {
                for (int x = 0; x < keys.Count; x++)
                {
                    key = keys[x];
                    values = this.grafo[key];
                    if (values.Exists(xx => xx == ArgKey) && limit != cont)
                    {
                        ArgKey = key;
                        sair = true;
                        cont++;
                    }
                }

                if (sair && limit <= cont || ArgKey == 0 || cont==0) {
                    continuar = false;
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
            for(int x = 0;x< this.grafo.Keys.Count;x++)
            {
                values = this.grafo[x];
                values.RemoveAll(xx => xx == removeKey);
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

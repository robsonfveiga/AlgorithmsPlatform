using AlgorithmsPlatform.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms.GraphTheory
{
    class KthAncestorV3 : ITestable
    {
        Dictionary<string, List<string>> grafo = new Dictionary<string, List<string>>();
        Dictionary<string, string> nodeReference = new Dictionary<string, string>();

        List<string> descendentes, novoDescendentes,aux;
        StringBuilder strB = new StringBuilder();
        int t, p, q, l, tamanhoLista;
        string[] nodes;
        string x, y, nodeBuscado, retorno;

        public void run(StreamReader Console)
        {
            t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                //Numero de nodes
                p = int.Parse(Console.ReadLine());

                // Cria Arvore
                //Todos Nodes baseado no numero apresentado como entrada 'p'
                for (int ii = 0; ii < p; ii++)
                {
                    
                    nodes = Console.ReadLine().Split(' ');

                    // X = Filho
                    x = nodes[0];
                    //Y = Pai
                    y = nodes[1];
                    
                    this.addNode(x, y);
                }

                //Numero de consultas. 
                q = int.Parse(Console.ReadLine());
                for (int ii = 0; ii < q; ii++)
                {
                    nodes = Console.ReadLine().Split();
                    y = nodes[1];

                    switch (nodes[0])
                    {
                        case "0":
                            //Adiciona valor no indice
                            x = nodes[2];
                            this.addNode(x, y);
                            break;
                        case "1":
                            //Remove valor do indice
                            this.grafo.Remove(y);
                            break;
                        case "2":
                            //Imprime valor Kth parent of X
                            x = nodes[1];
                            l = int.Parse(nodes[2]);

                            if (this.grafo.TryGetValue(x, out aux))
                            {

                                if (aux == null)
                                {
                                    aux = getPrimeiroPaiComReferencia(x);
                                }

                                tamanhoLista = aux.Count;
                                if (l <= tamanhoLista)
                                {
                                    nodeBuscado = aux[aux.Count - l];
                                    if (this.grafo.TryGetValue(nodeBuscado, out aux))
                                    {
                                        retorno = nodeBuscado;
                                    }
                                    else {
                                        retorno = "0";
                                    }
                                }
                                else {
                                    retorno = "0";
                                }
                                strB.Append(retorno + Environment.NewLine);
                            }
                            else {
                                strB.Append("0" + Environment.NewLine);
                            }
                            
                            break;
                    }
                }
            }
            System.Console.Write(strB);
        }


        public List<string> getPrimeiroPaiComReferencia(string filho) {
          
            y = this.nodeReference[x];
            if (y == null)
                return getPrimeiroPaiComReferencia(y);


            //Inseri o pai
            if (this.grafo.TryGetValue(y, out aux))
            {
                aux.AddRange(aux);
            }
            else {
                aux = new List<string>();
            }

            aux.Add(y);
            return aux;
        }


        public void addNode(string x,string y) {

            this.nodeReference.Add(x, y);

            if (!this.grafo.ContainsKey(x))
            {
                //Adicionar o filho na chave e o pai e seus descedentes no value
                if (this.grafo.TryGetValue(y, out descendentes))
                {
                    tamanhoLista = descendentes != null ? descendentes.Count + 1 : 1;
                    novoDescendentes = new List<string>(tamanhoLista);
                    if(descendentes!=null)
                        novoDescendentes.AddRange(descendentes);

                    novoDescendentes.Add(y);
                    this.grafo.Add(x, novoDescendentes);
                }
                else {
                    //Filho sem pai
                    this.grafo.Add(x, null);
                }
            }
        }

        public string getParent(string[] node, int cont, int limit) { 
        
            bool continuar = true;
            while (continuar)
            {
                if (limit > cont && this.grafo.TryGetValue(node[0], out aux))
                {
                    cont++;
                  
                }
                else
                {
                    continuar = false;
                    if (limit > cont)
                        return "0";
                }
            }

            return node[1];
        }



        public void removeParent(string removeKey)
        {
            this.grafo.Remove(removeKey);
        }

    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SherlockAndTheBeast : HackerRank
    {
        public void run(StreamReader Console)
        {
            int p3, p5,count;
            String valor;
            int t = Convert.ToInt32(Console.ReadLine());
            

            for (int x = 0; x < t; x++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n<3) {
                    System.Console.WriteLine(-1);
                    continue;
                }
             
                //Possibilidades do conjunto {33333}
                p3 = Math.Abs(n / 5);
                //Possibilidades do conjunto {555}
                p5 = Math.Abs(n / 3);

                //adiciona o maximo possivel do conjunto {555}
                valor = String.Concat(Enumerable.Repeat("555", p5));

                if (valor.Length != n)
                {

                    //Coloca valores "X" representativos para que o conjunto de {33333} comece a ser colocado
                    valor = valor + String.Concat(Enumerable.Repeat("X", n - (p5 * 3)));

                    count = 5;
                    for (int xx = 1; xx <= p3; xx++)
                    {
                        //Insere o conjunto {33333}
                        valor = valor.Remove(valor.Length - (count) * xx, 5);
                        valor += "33333";

                        //Verifica se os conjuntos de {555} continuam com a propriedade de multiplos de 3
                        if (valor.Count(y => y.Equals('5')) % 3 == 0)
                        {
                            System.Console.WriteLine(valor);
                            break;
                        }
                    }

                    if (valor.Count(y => y.Equals('X')) != 0 || (valor.Count(y => y.Equals('5')) % 3 != 0 || valor.Count(y => y.Equals('3')) % 5 != 0))
                    {
                        System.Console.WriteLine(-1);
                    }
                }
                else {
                    System.Console.WriteLine(valor);
                }
            }
        }
    }
}

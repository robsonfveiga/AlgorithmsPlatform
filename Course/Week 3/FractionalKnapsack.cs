using AlgorithmsPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmToolbox.Course.Week_3
{
    class FractionalKnapsack : ITestable
    {
        public void run(StreamReader Console)
        {
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int numEle = values[0];
            int capacidade = values[1];
            int valor,peso,unidade;

            List<int> quantidade;
            List<int> quantidadeFinal;

            for (int x = 0; x < numEle; x++) {
                values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                valor = values[0];
                peso = values[1];
            }

        }
    }
}

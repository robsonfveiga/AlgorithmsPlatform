using AlgorithmsPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmToolbox.Course.Week_3
{
    class ChangingMoney : ITestable
    {
        public void run(StreamReader Console)
        {
            int aux;
            int value = int.Parse(Console.ReadLine());
            List<int> coins = new List<int>();

            coins.Add(10);
            coins.Add(5);
            coins.Add(1);

            int retorno = 0;
            while (value > 0) {
                aux = value - coins[0];
                if (aux<0) {
                    coins.RemoveAt(0);
                    continue;
                }
                retorno++;
                value = aux;
            }
            System.Console.WriteLine(retorno);

        }
    }
}

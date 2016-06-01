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
            double[] values = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double numEle = values[0];
            double capacidade = values[1];
            double valor, peso;
            double valorFinal = 0;
            List<ItemKnapsack> itens = new List<ItemKnapsack>();
            for (int x = 0; x < numEle; x++)
            {
                values = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
                valor = values[0];
                peso = values[1];
                itens.Add(new ItemKnapsack(valor, peso));
            }
            itens.Sort();
            double safePass, safePassAux;
            while (capacidade != 0) {
                foreach (ItemKnapsack item in itens) {
                    if (capacidade == 0)
                        break;

                    safePass = item.Peso / capacidade;
                    if (safePass <= 1)
                    {
                        capacidade = capacidade - item.Peso;
                        valorFinal += item.Valor;
                    }
                    else {
                        safePassAux = item.Peso / safePass;
                        valorFinal += (item.Valor/ item.Peso)*safePassAux;
                        capacidade = capacidade - safePassAux;
                    }
                }
            }

            System.Console.Write(string.Format("{0:N4}", valorFinal));

        }
    }

    class ItemKnapsack : IComparable
    {
        double valor;
        double peso;
        public ItemKnapsack(double valor, double peso)
        {
            this.peso = peso;
            this.valor = valor;
        }

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public double Peso
        {
            get
            {
                return peso;
            }

            set
            {
                peso = value;
            }
        }

        public int CompareTo(object obj)
        {
            ItemKnapsack that = (ItemKnapsack)obj;
            if (this.Valor/ this.Peso < that.Valor/ that.Peso) return 1;
            if (this.Valor == that.Valor && this.Peso == that.Peso) return 0;
            return -1;
        }
    }
}

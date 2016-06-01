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
            int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int numEle = values[0];
            int capacidade = values[1];
            int valor, peso, unidade;

            List<ItemKnapsack> itens = new List<ItemKnapsack>();
            for (int x = 0; x < numEle; x++)
            {
                values = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                valor = values[0];
                peso = values[1];
                itens.Add(new ItemKnapsack(valor, peso));
            }
            itens.Sort();

            while (capacidade != 0) {
                foreach (ItemKnapsack item in itens) {
                    capacidade += capacidade
                }
            }

        }
    }

    class ItemKnapsack : IComparable
    {
        int valor;
        int peso;
        public ItemKnapsack(int valor,int peso)
        {
            this.peso = peso;
            this.valor = valor;
        }

        public int Valor
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

        public int Peso
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
            if (this.Valor > that.Valor && this.Peso<that.Peso) return -1;
            if (this.Valor == that.Valor && this.Peso == that.Peso) return 0;
            return 1;
        }
    }
}

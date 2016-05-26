using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms.WorldMay
{
    class RichieRich : ITestable
    {
        public void run(StreamReader Console)
        {
            int n, k,indexMenor,indexMaior,index;
            int[] valuesLineOne = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);  
            k = valuesLineOne[1];
            int alterado = 0;
            bool invalido = false;


            List<int> number = new List<int>();
            Console.ReadLine().ToList().ForEach(x => number.Add(int.Parse(x.ToString())));
            n = valuesLineOne[0];

            for (int x = 0; x < n; x++) {
                if (alterado == k)
                    break;

                index = n - x - 1;
                indexMenor = number[x];
                indexMaior = number[index];

                if (indexMenor != indexMaior) {

                    if (indexMenor==0 || indexMaior==0) {
                        number[x] = 9;
                        number[index] = 9;
                    }
                    else if (indexMenor > indexMaior) { 
                        number[index] = indexMenor;
                    }
                    else { 
                        number[x] = indexMaior;
                    }
                    alterado++;
                }
            }
          
            for (int x = 0; x < k - alterado; x++)
            {
                if (x >= number.Count)
                    break;

                index = n - x - 1;
                number[x] = 9;
                number[index]= 9;
            }

            for (int x = 0; x < n; x++)
            {
             
                index = n - x - 1;
                indexMenor = number[x];
                indexMaior = number[index];

                if (indexMenor != indexMaior)
                {
                    invalido = true;
                    break;
                }
            }
            if (invalido)
            {
                System.Console.Write("-1");
            }
            else {
                System.Console.Write(String.Join("", number.ToArray()));
            }
        }
    }
}

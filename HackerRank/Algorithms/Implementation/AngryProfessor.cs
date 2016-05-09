using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class AngryProfessor : HackerRank
    {
        public void run(StreamReader Console)
        {
            int numberTestCase,threshold, count;
            string[] aux;
            
            numberTestCase = int.Parse(Console.ReadLine());

            for (int x = 0; x < numberTestCase; x++) {
                aux = Console.ReadLine().Split(' ').ToArray();
                threshold = int.Parse(aux[1]);
                count = 0;
                Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse).ToList().ForEach(t=> {
                    if (t <= 0)
                        count++;
                }) ;
                
                if (count >= threshold)
                    System.Console.WriteLine("NO");
                else
                    System.Console.WriteLine("YES");
            }
        }
    }
}

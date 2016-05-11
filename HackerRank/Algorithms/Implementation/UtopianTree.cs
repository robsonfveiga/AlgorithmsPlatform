using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class UtopianTree : HackerRank
    {
        public void run(StreamReader Console)
        {
            int t, n,arvore;
            t = int.Parse(Console.ReadLine());
            
            //Number of test case
            for (int x = 0;x < t;x++) {
                n = int.Parse(Console.ReadLine());

                //Plantou
                arvore = 1;

                for (int xx = 0; xx < n; xx++)
                {
                    //Ciclo 1
                    arvore = arvore * 2;
                    xx++;

                    if (xx >= n)
                        break;

                    //Ciclo 2
                    arvore += 1;
                    
                }
                System.Console.WriteLine(arvore);
            }
        }
    }
}

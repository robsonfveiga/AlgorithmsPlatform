using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30daysChallange
{
    class IntroToConditionalStatements : HackerRank
    {
        public void run(StreamReader Console)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                if (n > 6 && n <= 20)
                {
                    System.Console.WriteLine("Weird");
                }
                else {
                    System.Console.WriteLine("Not Weird");
                }
            }
            else {
                //Impar
                System.Console.WriteLine("Weird");
            }
        }
    }
}

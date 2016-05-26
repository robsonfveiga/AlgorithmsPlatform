using AlgorithmsPlatform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlgorithmsPlatform.Algorithms
{
    class ComparetheTriplets : ITestable
    {
        public void run(StreamReader Console)
        {
            int alicePoints, bobPoints;
            int[] alice = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] bob = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            alicePoints = 0;
            bobPoints = 0;

            for(int x=0;x<alice.Count(); x++) {
                if (alice[x] == bob[x])
                    continue;

                if (alice[x] > bob[x]) {
                    alicePoints = alicePoints + 1;
                }else {
                    bobPoints = bobPoints+1;
                }
            }
            System.Console.WriteLine(alicePoints+" "+bobPoints);
        }
    }
}

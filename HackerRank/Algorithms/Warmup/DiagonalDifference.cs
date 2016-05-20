using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms
{
    class DiagonalDifference : ITestable
    {
        public void run(StreamReader Console)
        {
            string line1 = Console.ReadLine();
            string line = "";

            int[][] arr = new int[int.Parse(line1)][];
            string[] lineArr;

            int countY, countX, diagonal1, diagonal2;
            countY = countX = diagonal1 = diagonal2 = 0;
   

            line = Console.ReadLine();
            do {
                countX = 0;
                lineArr = line.Split(' ');
                arr[countY] = new int[lineArr.Count()];
            
                lineArr.ToList().ForEach(x => {
                    arr[countY][countX] = int.Parse(x);
                    countX++;
                });
                countY++;
                line = Console.ReadLine();
            } while (line != null);

            int arraySize = arr.Count();
            for (int x = 0; x < arraySize; x++)
                diagonal1 += arr[x][x];

            for (int x = (arraySize); x > 0 ; --x)
                diagonal2 += arr[arraySize - x ][x-1];


            if(diagonal1> diagonal2)
                System.Console.Write(diagonal1 - diagonal2);
            else
                System.Console.Write(diagonal2 - diagonal1);


        }
    }
}

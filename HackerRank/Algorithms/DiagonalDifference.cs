using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    class DiagonalDifference : HackerRank
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


            for (int x = 0; x < arr.Count(); x++)
                diagonal1 += arr[x][x];

            for (int x = arr.Count(); x > 0 ; x++)
                diagonal2 += arr[x][x];

            System.Console.Write(diagonal1- diagonal2);
        }
    }
}

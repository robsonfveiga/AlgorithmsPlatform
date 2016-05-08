using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30daysChallange
{
    class DataTypes : HackerRank
    {
        public void run(StreamReader Console)
        {
            //https://www.hackerrank.com/challenges/30-data-types

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int line1;
            double line2;
            string line3;
            // Read and save an integer, double, and String to your variables.
            line1 = int.Parse(Console.ReadLine());
            line2 = double.Parse(Console.ReadLine());
            line3 = Console.ReadLine();


            // Print the sum of both integer variables on a new line.
            System.Console.WriteLine(i + line1);


            // Print the sum of the double variables on a new line.
            line2 = d + line2;
            System.Console.WriteLine("{0:F1}", line2);
            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.
            System.Console.WriteLine(s + line3);

        }
    }
}

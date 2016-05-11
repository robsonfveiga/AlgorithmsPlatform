using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30daysChallange
{
    class Operators : HackerRank
    {
        public void run(StreamReader Console)
        {
            double cost = double.Parse(Console.ReadLine());
            double tipPercenttipPercent = (double.Parse(Console.ReadLine())/100)  * cost;
            double taxPercenttaxPercent = (double.Parse(Console.ReadLine())/100) * cost;
            double final = cost + tipPercenttipPercent + taxPercenttaxPercent;
            System.Console.WriteLine("The total meal cost is " + Math.Round(final) + " dollars.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30daysChallange
{
    class HelloWorld : HackerRank
    {
        public void run(StreamReader Console)
        {
            //https://www.hackerrank.com/challenges/30-hello-world

            String inputString; // declare a variable to hold our input
            inputString = Console.ReadLine(); // get a line of input from stdin and save it to our variable

            // Your first line of output goes here
            System.Console.WriteLine("Hello, World.");

            // Write the second line of output
            System.Console.WriteLine(inputString);
        }
    }
}

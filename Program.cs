using AlgorithmToolbox.Course.Week_3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmToolbox
{
    class Program
    {
        static void Mainx(string[] args)
        {
            new FractionalKnapsack().run(new StreamReader("input.txt"));
            Console.ReadLine();
        }
    }
}

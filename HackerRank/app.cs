
using AlgorithmsPlatform.Algorithms;
using AlgorithmsPlatform.Algorithms.GraphTheory;
using AlgorithmsPlatform.Algorithms.Implementation;
using AlgorithmsPlatform.Algorithms.WorldMay;
using AlgorithmsPlatform.Course.Week_2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform
{
    class app
    {
        static void xMain(String[] args)
        {
            StreamReader input = new StreamReader("Tester/InputFiles/input.txt");
            ITestable algorithm = new Fibonacci();
            algorithm.run(input);
            Console.ReadLine();

        }
    }
}

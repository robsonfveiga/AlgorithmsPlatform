﻿using HackerRank._30daysChallange;
using HackerRank.Algorithms;
using HackerRank.Algorithms.GraphTheory;
using HackerRank.Algorithms.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class app
    {
        static void Main(String[] args)
        {
            StreamReader input = new StreamReader("input2txt");
            HackerRank hackerRank = new KthAncestorV3();
            
            hackerRank.run(input);

            Console.ReadLine();

        }
    }
}

﻿using HackerRank.Algorithms;
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
            StreamReader input = new StreamReader("input.txt");
            HackerRank hackerRank = new Algorithms.Implementation.SherlockAndTheBeast();
            hackerRank.run(input);

            Console.ReadLine();

        }
    }
}

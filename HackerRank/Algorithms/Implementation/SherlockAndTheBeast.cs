using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Implementation
{
    class SherlockAndTheBeast : HackerRank
    {
        public void run(StreamReader Console)
        {
            double value,final;
            string strValue;
            int t = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < t; x++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                value = Double.Parse(new String('5', n));

                Lif (value % 3 == 0 || value % 5 == 0) {
                    System.Console.WriteLine(value);
                }

                for (int xx = 0; xx < n; xx++) {
                    
                }
            }
           
        }
    }
}

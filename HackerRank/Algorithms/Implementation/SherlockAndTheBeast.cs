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
            string three, five,final;
            int limit;
            int t = Convert.ToInt32(Console.ReadLine());


            for (int x = 0; x < t; x++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 3)
                {
                    System.Console.WriteLine(-1);
                }
                else if (n == 3)
                {
                    System.Console.WriteLine("555");
     
                }
                else if (n == 5)
                {
                    System.Console.WriteLine("33333");

                }
                else
                {
                    three = new String('3', n);
                    final = three;
                    limit = -1;
                    for (int xx = 1; xx < n; xx++)
                    {
                        if (three.Length != 5)
                        {
                            three = three.Remove(0, xx);
                        }
                        else {
                            if(limit==-1)
                                limit = xx;
                        }

                        five = new String('5', xx);
                    
                        if (three.Length % 5 == 0 && five.Length % 3 == 0) {
                            final = five + three;
                        }
                    }
                    if (limit != -1)
                    {
                        System.Console.WriteLine(final.Remove(0, limit - 1));
                    }
                    else {
                        System.Console.WriteLine(final);
                    }
                }
            }
        }
    }
}

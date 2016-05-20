using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPlatform.Algorithms
{
    class PlusMinus : ITestable
    {
        public void run(StreamReader Console)
        {
            int arraySize = int.Parse(Console.ReadLine());
            double value,positive,negative,zero;
            positive = negative = zero = 0;

            Console.ReadLine().Split(' ').ToList().ForEach(
                x =>
                {
                    if(double.TryParse(x,out value)) {
                        if (value > 0)
                            positive++;
                        else if (value < 0)
                            negative++;
                        else
                            zero++;
                    }
                }
            );

            System.Console.WriteLine("{0:F7}", positive / arraySize);
            System.Console.WriteLine("{0:F7}",negative/arraySize);
            System.Console.WriteLine("{0:F7}",zero /arraySize);
        }

    }
}

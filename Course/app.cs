using Course.DynamicConnectivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class app
    {
        static void Main(String[] args)
        {
            Tester test = new Course.DynamicConnectivity.UnionFindTester();
            test.letsRock();
        }
    }
}

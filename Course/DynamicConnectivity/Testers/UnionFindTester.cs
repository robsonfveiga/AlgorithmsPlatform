using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Course.DynamicConnectivity
{
    class UnionFindTester : Tester
    {
        public override void letsRock()
        {
            this.readConsole(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)+ @"\DynamicConnectivity\Testers\inputs\UnionFind1.txt");
            System.Console.Write(this.Console.ReadLine());
            System.Console.Read();
        }
    }
}

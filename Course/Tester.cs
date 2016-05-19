using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DynamicConnectivity
{
    abstract class Tester
    {
        StreamReader console;

        public StreamReader Console
        {
            get
            {
                return console;
            }
        }

        public void readConsole(string fileName) {
            this.console = new StreamReader(fileName);
        }

        public abstract void letsRock();
    }
}

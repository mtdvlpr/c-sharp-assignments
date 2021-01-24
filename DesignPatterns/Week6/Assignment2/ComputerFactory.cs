using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;

namespace Assignment2
{
    class ComputerFactory
    {
        public virtual IProcessor MakeProcessor()
        {
            return new CheapProcessor();
        }

        public virtual IHardDisk MakeHardDisk()
        {
            return new CheapHardDisk();
        }

        public virtual IMonitor MakeMonitor()
        {
            return new ExpensiveMonitor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ComputerShop
    {
        public void AssembleMachine()
        {
            MakeProcessor().PerformOperation();
            MakeHardDisk().StoreData();
            MakeMonitor().Display();
        }

        protected virtual IProcessor MakeProcessor()
        {
            return new CheapProcessor();
        }

        protected virtual IHardDisk MakeHardDisk()
        {
            return new CheapHardDisk();
        }

        protected virtual IMonitor MakeMonitor()
        {
            return new ExpensiveMonitor();
        }
    }
}

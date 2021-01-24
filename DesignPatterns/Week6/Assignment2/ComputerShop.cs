using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ComputerShop
    {
        ComputerFactory factory;

        public ComputerShop(ComputerFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleMachine()
        {
            factory.MakeProcessor().PerformOperation();
            factory.MakeHardDisk().StoreData();
            factory.MakeMonitor().Display();
        }
    }
}

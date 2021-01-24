using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class LowBudgetFactory : ComputerFactory
    {
        public override IMonitor MakeMonitor()
        {
            return new CheapMonitor();
        }
    }
}

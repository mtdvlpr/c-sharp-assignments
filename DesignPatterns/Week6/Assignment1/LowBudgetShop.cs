using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class LowBudgetShop : ComputerShop
    {
        protected override IMonitor MakeMonitor()
        {
            return new CheapMonitor();
        }
    }
}

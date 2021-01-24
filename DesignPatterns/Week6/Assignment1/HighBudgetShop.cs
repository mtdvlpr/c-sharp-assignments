using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class HighBudgetShop : ComputerShop
    {
        protected override IProcessor MakeProcessor()
        {
            return new ExpensiveProcessor();
        }

        protected override IHardDisk MakeHardDisk()
        {
            return new ExpensiveHardDisk();
        }
    }
}

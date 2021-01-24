using Assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class HighBudgetFactory : ComputerFactory
    {
        public override IProcessor MakeProcessor()
        {
            return new ExpensiveProcessor();
        }

        public override IHardDisk MakeHardDisk()
        {
            return new ExpensiveHardDisk();
        }
    }
}

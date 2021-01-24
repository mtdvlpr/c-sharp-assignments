using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Payment
    {
        public void Execute()
        {
            EnterInformation();
            ProcessPayment();
            ConfirmPayment();
        }

        private void EnterInformation()
        {
            Console.WriteLine("Entering information...");
        }

        protected abstract void ProcessPayment();

        private void ConfirmPayment()
        {
            Console.WriteLine("Sending confirmation mail...");
        }
    }
}

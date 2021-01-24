using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class NoCashState : IATMState
    {
        private ATMMachine machine;

        public NoCashState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("There is no cash left in the machine!");
        }

        public void InsertCard()
        {
            Console.WriteLine("There is no cash left in the machine!");
        }

        public void RejectCard()
        {
            Console.WriteLine("There is no cash left in the machine!");
        }

        public void SetAmountInMachine(uint amount)
        {
            machine.AmountInMachine = amount;

            if (amount > 0)
            {
                machine.SetMachineState(machine.GetNoCardState());
                Console.WriteLine("The new amount has been set.");
            }
            else
            {
                Console.WriteLine("The amount in the machine is still 0.");
            }
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("There is no cash left in the machine!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class NoCardState : IATMState
    {
        private ATMMachine machine;

        public NoCardState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("Please insert your card first!");
        }

        public void InsertCard()
        {
            machine.SetMachineState(machine.GetCardPresentState());
            Console.WriteLine("Please enter your pincode:");
            Console.WriteLine();
        }

        public void RejectCard()
        {
            Console.WriteLine("There is no card to be rejected!");
        }

        public void SetAmountInMachine(uint amount)
        {
            Console.WriteLine("Please insert your card first!");
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("PLease insert your card first!");
        }
    }
}

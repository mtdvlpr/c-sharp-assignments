using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CorrectPinState : IATMState
    {
        private ATMMachine machine;

        public CorrectPinState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            Console.WriteLine("You have already entered your pincode!");
        }

        public void InsertCard()
        {
            Console.WriteLine("A card has already been inserted!");
        }

        public void RejectCard()
        {
            machine.SetMachineState(machine.GetNoCardState());
            Console.WriteLine("You card has been rejected.");
        }

        public void SetAmountInMachine(uint amount)
        {            
            Console.WriteLine("The new amount has been set.");
            machine.AmountInMachine = amount;

            if (amount == 0)
            {
                machine.SetMachineState(machine.GetNoCashState());
            }
        }

        public void WithdrawCash(uint amount)
        {
            if (amount <= machine.AmountInMachine)
            {
                machine.AmountInMachine -= amount;
                Console.WriteLine($"{amount} withdrawn from machine.");
            }
            else
            {
                Console.WriteLine("Not enough cash available in machine!");
            }
        }
    }
}

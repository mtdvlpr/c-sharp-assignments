using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class CardPresentState : IATMState
    {
        private ATMMachine machine;

        public CardPresentState(ATMMachine machine)
        {
            this.machine = machine;
        }

        public void EnterPincode(uint pin)
        {
            machine.SetMachineState(machine.GetCorrectPinState());
            Console.WriteLine("You have entered the correct pincode.");
        }

        public void InsertCard()
        {
            Console.WriteLine("There is already a card present!");
        }

        public void RejectCard()
        {
            machine.SetMachineState(machine.GetNoCardState());
            Console.WriteLine("Your card has been rejected.");
            Console.WriteLine();
        }

        public void SetAmountInMachine(uint amount)
        {
            Console.WriteLine("Please enter your pincode first!");
        }

        public void WithdrawCash(uint amount)
        {
            Console.WriteLine("Please enter your pincode first!");
        }
    }
}

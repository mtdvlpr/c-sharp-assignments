using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ATMMachine
    {
        private IATMState machineState;
        private IATMState cardPresent;
        private IATMState correctPinCode;
        private IATMState noCard;
        private IATMState noCash;

        public uint AmountInMachine { get; set; }

        public ATMMachine(uint initialAmount)
        {
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            AmountInMachine = initialAmount;

            if (AmountInMachine > 0)
            {
                machineState = noCard;
            }
            else
            {
                machineState = noCash;
            }
        }

        public void EnterPincode(uint pin)
        {
            machineState.EnterPincode(pin);
        }

        public IATMState GetCardPresentState()
        {
            return cardPresent;
        }

        public IATMState GetCorrectPinState()
        {
            return correctPinCode;
        }

        public IATMState GetNoCardState()
        {
            return noCard;
        }

        public IATMState GetNoCashState()
        {
            return noCash;
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void SetAmountInMachine(uint amount)
        {
            machineState.SetAmountInMachine(amount);
        }

        public void SetMachineState(IATMState newState)
        {
            machineState = newState;
        }

        public void WithdrawCash(uint amount)
        {
            machineState.WithdrawCash(amount);
        }
    }
}

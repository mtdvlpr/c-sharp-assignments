using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    interface IATMState
    {
        void EnterPincode(uint pin);

        void InsertCard();

        void RejectCard();

        void SetAmountInMachine(uint amount);

        void WithdrawCash(uint amount);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    interface IAttacker
    {
        void AssignDriver(string driver);
        void DriveForward();
        void UseWeapon();
    }
}

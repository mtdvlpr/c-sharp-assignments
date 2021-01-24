using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Tank  :IAttacker
    {
        private Random generator = new Random();

        public void AssignDriver(string driver)
        {
            Console.WriteLine(generator + " is steering the tank.");
        }

        public void DriveForward()
        {
            int steps = generator.Next(0, 6);
            Console.WriteLine($"Tank moves {steps} positions forward.");
        }

        public void UseWeapon()
        {
            Console.WriteLine("Tank causes damage.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Robot
    {
        private Random generator = new Random();

        public void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands.");
        }

        public void MoveByPerson(string person)
        {
            Console.WriteLine($"Robot is moved by {person}.");
        }

        public void WalkForward()
        {
            int steps = generator.Next(0,6);
            Console.WriteLine($"Robot walks {steps} steps forward.");
        }
    }
}

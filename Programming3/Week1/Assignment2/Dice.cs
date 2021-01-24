
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Dice
    {
        public int value;
        public Random rnd;

        public Dice(Random rnd)
        {
            this.rnd = rnd;
        }

        public void Throw()
        {
            value = rnd.Next(1, 7);
        }

        public void DisplayValue()
        {
            Console.Write(value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class Literature
    {
        public string title;
        public double price;

        public Literature(string title, double price)
        {
            this.title = title;
            this.price = price;
        }

        public abstract void Print();
    }
}

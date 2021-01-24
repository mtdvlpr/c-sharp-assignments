using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Magazine : Literature
    {
        DayOfWeek dayOfRelease;

        public Magazine(string title, DayOfWeek dayOfRelease, double price) : base(title, price)
        {
            this.dayOfRelease = dayOfRelease;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {title} - release day: {dayOfRelease}, {price.ToString("0.00")}");
        }
    }
}

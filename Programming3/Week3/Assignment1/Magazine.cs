using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Magazine : BookStoreItem
    {
        public DayOfWeek dayOfRelease { get; set; }

        public Magazine(string title, DayOfWeek dayOfRelease, double price, int count) : base(title, price, count)
        {
            this.dayOfRelease = dayOfRelease;
        }

        public override void Print()
        {
            Console.WriteLine($"[Magazine] {Title} - release day: {dayOfRelease}, {Price.ToString("0.00")} ({Count}x)");
        }
    }
}

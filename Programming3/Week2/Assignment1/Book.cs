using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Book : Literature
    {
        public string author;

        public Book(string title, string author, double price) : base(title, price)
        {
            this.author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"[Book] '{title}' by {author}, {price.ToString("0.00")}");
        }
    }
}

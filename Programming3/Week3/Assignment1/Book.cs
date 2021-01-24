using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        public string author { get; private set; }

        public Book(string title, string author, double price, int count) : base(title, price, count)
        {
            this.author = author;
        }

        public override void Print()
        {
            Console.WriteLine($"[Book] '{Title}' by {author}, {Price.ToString("0.00")} ({Count}x)");
        }
    }
}

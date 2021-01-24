using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Book : BookStoreItem
    {
        public string Author { get; set; }

        public Book(string title, float price, int numberOfItems, string author) 
            : base(title, price, numberOfItems)
        {
            Author = author;
        }

        public override string ToString()
        {
            return $"[Book] {Author} - {Title}, {Price:0.00} ({NumberOfItems}x)";
        }
    }
}

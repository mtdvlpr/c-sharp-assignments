using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class BookStoreItem
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public double TotalPrice
        {
            get
            {
                return Price * Count;
            }
        }

        public BookStoreItem(string title, double price, int count)
        {
            this.Title = title;
            this.Price = price;
            this.Count = count;
        }

        public abstract void Print();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BookStore
    {
        private readonly List<BookStoreItem> items;

        public BookStore()
        {
            items = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem item)
        {
            items.Add(item);
        }

        public void PrintAllItems()
        {
            foreach (BookStoreItem item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}

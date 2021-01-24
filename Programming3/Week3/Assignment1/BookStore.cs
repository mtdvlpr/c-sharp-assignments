using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BookStore
    {
        List<BookStoreItem> BookStoreItem;

        public BookStore()
        {
            BookStoreItem = new List<BookStoreItem>();
        }

        public void Add(BookStoreItem BookStoreItem)
        {
            this.BookStoreItem.Add(BookStoreItem);
        }

        public void PrintCompleteStock()
        {
            double totalPrice = 0;
            foreach (BookStoreItem BookStoreItem in BookStoreItem)
            {
                BookStoreItem.Print();
                totalPrice += BookStoreItem.TotalPrice;
            }
            Console.WriteLine();
            Console.WriteLine("Total sales price: " + totalPrice.ToString("0.00"));
        }
    }
}

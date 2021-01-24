using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BookStore
    {
        List<Literature> literature;

        public BookStore()
        {
            literature = new List<Literature>();
        }

        public void Add(Literature literature)
        {
            this.literature.Add(literature);
        }

        public void PrintCompleteStock()
        {
            double totalPrice = 0;
            foreach (Literature literature in literature)
            {
                literature.Print();
                totalPrice += literature.price;
            }
            Console.WriteLine();
            Console.WriteLine("Total sales price: " + totalPrice.ToString("0.00"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double VAT = 0.21;

            Console.Write("Enter a price: ");

            double price = double.Parse(Console.ReadLine());
            double vat = Math.Round(price * VAT, 2);
            double total = Math.Round(price + vat, 2);

            Console.WriteLine("Price: {0}, VAT: {1}, total: {2}", price, vat, total);

            Console.WriteLine("");
            Console.WriteLine("Press any key to close the program...");
            _ = Console.ReadKey();
        }
    }
}

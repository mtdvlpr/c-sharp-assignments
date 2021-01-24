using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            float price;
            float total;
            float vat;
            int percentage;
            Console.Write("Enter a price: ");
            if(float.TryParse(Console.ReadLine(), out price))
            {
                Console.Write("Enter a VAT percentage (e.g. 21): ");

                if(int.TryParse(Console.ReadLine(), out percentage))
                {
                    vat = VAT(price, percentage);
                    total = price + vat;
                    Console.WriteLine("Price: {0}, VAT: {1}, total: {2}", price.ToString("0.00"), vat.ToString("0.00"), total.ToString("0.00"));
                }
                else
                {
                    Console.WriteLine("That was not a valid VAT percentage!");
                }

            }
            else
            {
                Console.WriteLine("That was not a valid price!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
            
        }

        static float VAT(float price, float vat)
        {
            price *= vat/100;
            return price;
        }
    }
}

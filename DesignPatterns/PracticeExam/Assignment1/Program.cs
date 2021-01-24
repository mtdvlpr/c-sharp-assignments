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
            PrintHeader("[CreditCard]");
            Payment ccPayment = new CreditCardPayment();
            ccPayment.Execute();

            PrintHeader("[PayPal]");
            Payment ppPayment = new PayPalPayment();
            ppPayment.Execute();

            PrintHeader("[PIN]");
            Payment pinPayment = new PINPayment();
            pinPayment.Execute();

            Console.ReadKey();
        }

        static void PrintHeader(string header)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.ResetColor();
        }
    }
}

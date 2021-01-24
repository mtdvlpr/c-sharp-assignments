using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter number of failures in a year: ");
            int failures = int.Parse(Console.ReadLine());

            if (hours > 10000 || years >= 7 || failures > 25)
            {
                Console.WriteLine();
                Console.WriteLine("The machine needs to be replaced.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("The machine does NOT need to be replaced.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

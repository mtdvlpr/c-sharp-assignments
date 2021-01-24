using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;

            while (year != 0)
            {
                Console.Write("Enter a year: ");
                if (int.TryParse(Console.ReadLine(), out year))
                {
                    if (year < 0)
                    {
                        Console.WriteLine("The year must be positive!");
                    }
                    else if (year > 0 && (year % 4 == 0 && year % 100 != 0 || (year % 400 == 0 && year % 100 == 0)))
                    {
                        Console.WriteLine("{0} is a leap year.", year);
                    }
                    else if (year > 0)
                    {
                        Console.WriteLine("{0} is NOT a leap year.", year);
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                    year = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

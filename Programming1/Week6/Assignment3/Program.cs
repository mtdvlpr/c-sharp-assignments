using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 1;

            while (year != 0)
            {
                Console.Write("Enter a year (0 is the stop value): ");
                if (int.TryParse(Console.ReadLine(), out year) && year >=0)
                {
                    if (year == 0)
                    {
                        Console.WriteLine("End of program");
                    }
                    else if(IsLeapYear(year))
                    {
                        Console.WriteLine(year + " is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine(year + " is NOT a leap year.");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid year!");
                    year = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }

        static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && (year % 100 != 0 || (year % 100 == 0 && year % 400 == 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

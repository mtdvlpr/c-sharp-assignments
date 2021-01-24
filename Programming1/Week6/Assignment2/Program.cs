using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num != 0)
            {
                Console.Write("Enter a number (0 is the stop value): ");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    if (num < 0)
                    {
                        Console.WriteLine(num + " is a negative number.");
                    }
                    else if (num == 0)
                    {
                        Console.WriteLine("End of program");
                    }
                    else if (IsPrimeNumber(num))
                    {
                        Console.WriteLine(num + " is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine(num + " is not a prime number.");
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid number!");
                    num = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }

        static bool IsPrimeNumber(int num)
        {
            bool prime = true;
            if (num == 1)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        i = num;
                    }
                }
            }
            return prime;
        }
    }
}

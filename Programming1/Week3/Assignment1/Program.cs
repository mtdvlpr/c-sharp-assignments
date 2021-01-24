using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numFirst;
            int numSecond;

            Console.Write("Enter first number: ");
            if (int.TryParse(Console.ReadLine(), out numFirst))
            {
                Console.Write("Enter second number: ");
                if (int.TryParse(Console.ReadLine(), out numSecond))
                {
                    int highest;
                    int lowest;

                    if (numFirst > numSecond)
                    {
                        highest = numFirst;
                        lowest = numSecond;
                    }
                    else
                    {
                        highest = numSecond;
                        lowest = numFirst;
                    }

                    Console.WriteLine("");
                    Console.WriteLine("Highest value is: {0}", highest);
                    Console.WriteLine("Lowest value is: {0}", lowest);
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                }
            }
            else
            {
                Console.WriteLine("That was not a number!");
            }

            Console.WriteLine("");
            Console.WriteLine("Press any key to close the program...");
            _ = Console.ReadKey();
        }
    }
}

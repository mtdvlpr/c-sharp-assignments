using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int third = int.Parse(Console.ReadLine());

            if(first > third & second > third)
            {
                Console.WriteLine("The third number is the smallest of the three.");
            }
            else if (first == third | second == third)
            {
                Console.WriteLine("The third number is one of the smallest of the three.");

            }
            else
            {

                Console.WriteLine("The third number is NOT the smallest of the three.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

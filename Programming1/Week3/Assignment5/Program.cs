using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = int.Parse(Console.ReadLine());

            if (first % second == 0)
            {
                Console.WriteLine("Number 1 is a multiple of number 2");
            }
            else if (second % first == 0)
            {
                Console.WriteLine("Number 2 is a multiple of number 1");
            }
            else
            {
                Console.WriteLine("The numbers are no multiples");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the progam...");
            _ = Console.ReadKey();
        }
    }
}

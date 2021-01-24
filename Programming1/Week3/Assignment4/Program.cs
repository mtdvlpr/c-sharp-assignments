using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double second = double.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            double third = double.Parse(Console.ReadLine());

            double sum = first + second + third;
            double avg = (first + second + third) / 3;
            double product = first * second * third;
            double highest;
            double lowest;

            if (first >= third && second >= third)
            {
                lowest = third;
                if (first > second)
                {
                    highest = first;
                }
                else
                {
                    highest = second;
                }
            }
            else if (first >= second)
            {
                lowest = second;
                if (first > third)
                {
                    highest = first;
                }
                else
                {
                    highest = third;
                }
            }
            else
            {
                lowest = first;
                if (second > third)
                {
                    highest = second;
                }
                else
                {
                    highest = third;
                }
            }

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Average = {0}", avg.ToString("0.##"));
            Console.WriteLine("Product = {0}", product);
            Console.WriteLine("Highest = {0}", highest);
            Console.WriteLine("Lowest = {0}", lowest);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

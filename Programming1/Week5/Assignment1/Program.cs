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
            Random rnd = new Random();

            int[] elements = new int[20];
            double sum = 0;
            double avg;

            for (int i=0;i<20;i++)
            {
                elements[i] = rnd.Next(0, 200);
                Console.WriteLine("Element {0} is: {1}", i, elements[i]);
                sum += elements[i];
            }

            avg = sum / 20;

            Console.WriteLine();
            Console.WriteLine("The average is: {0}", avg.ToString("0.##"));
            Console.WriteLine();

            for (int i=0;i<20;i++)
            {
                double diff = Math.Abs(avg - elements[i]);
                Console.WriteLine("The difference between the average and element {0} is: {1}", i, diff.ToString("0.##"));
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

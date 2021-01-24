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
            Random rnd = new Random();

            int[] elements = new int[20];
            int occurence = 0;

            for (int i=0;i<20;i++)
            {
                elements[i] = rnd.Next(0, 150);
                Console.WriteLine("Element {0} = {1}", i, elements[i]);
            }

            int smallest = elements.Min();

            foreach (int element in elements)
            {
                if(smallest == element)
                {
                    occurence++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The smallest number = " + smallest);
            Console.WriteLine("The number of occurences = {0}", occurence);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

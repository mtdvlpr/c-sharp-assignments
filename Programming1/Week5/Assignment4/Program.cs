using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int timer = 0;
            int occurence = 0;
            int[] numbers = new int[20];

            while (num != 0 && timer<20)
            {
                Console.Write("Enter a number (0=stop): ");
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    numbers[timer] = num;
                    timer++;
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                    num = 1;
                }
            }

            if (timer==20)
            {
                Console.WriteLine();
                Console.WriteLine("You have reached the maximum of 20 numbers!");
            }

            Console.WriteLine();
            Console.Write("Enter a searchvalue: ");
            if(int.TryParse(Console.ReadLine(), out num))
            {
                for (int i=0;i<timer;i++)
                {
                    if (num == numbers[i])
                    {
                        occurence++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Number of occurences of the searchvalue ({0}) is: {1}", num, occurence);
            }
            else
            {
                Console.WriteLine("That was not a valid search value!");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

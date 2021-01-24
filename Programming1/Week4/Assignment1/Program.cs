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
            double num = 1;
            double timer = 0;
            double sum = 0;

            while (num != 0)
            {
                Console.Write("Enter a number: ");
                if(double.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0)
                    {
                        timer++;
                        sum += num;
                    }
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                    num = 1;
                }
            }

            if (timer == 0)
            {
                timer = 1;
            }

            double avg = sum / timer;
            Console.WriteLine("The average of all the positive numbers is: {0}", avg.ToString("0.###"));

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

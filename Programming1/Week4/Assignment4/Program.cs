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
            ulong num1 = 1;
            ulong num2 = 1;
            ulong num3;
            int timer;

            Console.Write("How many numbers of the Fibonacci sequence do you want? ");
            if (int.TryParse(Console.ReadLine(), out timer))
            {
                if (timer <1)
                {
                    Console.WriteLine("You have to choose a number higher than 0!");
                }
                else if (timer == 1)
                {
                    Console.WriteLine("The first number in the Fibonacci sequence is: 1");
                }
                else if (timer > 100000)
                {
                    Console.WriteLine("You have to choose a number lower than or equal to 100,000!");
                }
                else
                {
                    timer -= 2;
                    Console.WriteLine();
                    Console.WriteLine("The first {0} numbers in the Fibonacci sequence are: ", timer + 2);
                    Console.Write("1, 1");

                    while (timer > 0)
                    {
                        num3 = num1 + num2;
                        num1 = num2;
                        num2 = num3;
                        Console.Write(", {0}", num3);
                        timer--;
                    }
                }
            }
            else
            {
                Console.WriteLine("That is not a number!");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

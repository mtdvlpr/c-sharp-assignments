using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            int timer = 1;

            while (num != 0)
            {
                Console.Write("Enter number {0}: ", timer);
                if(int.TryParse(Console.ReadLine(), out num))
                {
                    if (timer % 5 == 0)
                    {
                        sum += num;
                    }
                    timer++;
                }
                else
                {
                    Console.WriteLine("That was not a number!");
                    num = 1;
                }
            }

            timer -= 2;
            int amount = timer / 5 - 1;
            int t = 10;

            if (amount == 0)
            {
                Console.Write("The 5th number is: {0}", sum);
            }
            else
            {
                Console.Write("The sum of the 5th");
                while (amount > 0)
                {
                    Console.Write(" and {0}th", t);
                    t += 5;
                    amount--;
                }
                Console.Write(" number is: {0}", sum);
            }            

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

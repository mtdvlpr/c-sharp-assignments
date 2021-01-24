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
            Console.Write("Enter target number: ");

            int num = 1;
            int equal = 0;
            int target;
            if(int.TryParse(Console.ReadLine(), out target))
            {
                while (num != 0)
                {
                    Console.Write("Enter a number: ");
                    if(int.TryParse(Console.ReadLine(), out num))
                    {
                        if (num == target)
                        {
                            equal++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was not a number!");
                        num = 1;
                    }
                }

                Console.Write("The amount of numbers equal to the target number is: {0}", equal);
            }
            else
            {
                Console.WriteLine("That was not a number!");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

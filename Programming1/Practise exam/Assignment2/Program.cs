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
            int num = 1;

            while (num > 0)
            {
                Console.Write("Enter a number: ");

                if(int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0)
                    {
                        for (int i = 0; i < num / 2; i++)
                        {
                            Console.Write("*");
                        }
                        for (int i = 0; i < num - num / 2; i++)
                        {
                            Console.Write("!");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("End of program");
                    }
                    
                }
                else
                {
                    Console.WriteLine("That was not a valid integer!");
                    num = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

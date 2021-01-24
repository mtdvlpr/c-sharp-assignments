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
            int factorial;
            Random rnd = new Random();

            while (num != 0)
            {
                num = rnd.Next(0, 11);
                if (num != 0)
                {
                    factorial = Factorial(num);
                    Console.WriteLine("Factorial of {0} is {1}", num, factorial);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("End of progam");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }

        static int Factorial(int num)
        {
            int factorial = 1;
            for (int i = 2; i <= num; i++)
            {
                factorial *= i; 
            }
            return factorial;
        }
    }
}

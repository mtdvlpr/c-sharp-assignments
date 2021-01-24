using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int num1 = rnd.Next(101, 10000);
            int num2 = rnd.Next(101, 10000);
            int num3 = rnd.Next(101, 10000);
            int num4 = rnd.Next(101, 10000);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            int answer = num1 + num2 + num3 + num4;

            Console.WriteLine("The sum of the numbers is: {0}", answer);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program...");

            Console.ReadKey();
        }
    }
}

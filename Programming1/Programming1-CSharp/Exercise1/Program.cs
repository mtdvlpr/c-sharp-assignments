using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is:  " + name);
            Console.WriteLine("Your age is: " + age);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _= Console.ReadKey();
        }
    }
}

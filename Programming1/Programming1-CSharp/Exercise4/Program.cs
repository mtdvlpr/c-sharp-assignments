using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            bool answer;
            answer = (age > 65);
            if (answer)
            {
                Console.WriteLine("Your are too old.");
            }
            else
            {
                Console.WriteLine("Your age is good.");
            }

            Console.ReadKey();
        }
    }
}

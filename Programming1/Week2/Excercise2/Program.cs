using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number: ");
            float second = float.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number: ");
            float third = float.Parse(Console.ReadLine());

            float average = (first + second + third) / 3;

            Console.WriteLine("The average of the numbers is: {0}", average);

            Console.WriteLine("");
            Console.WriteLine("Press any key to close the programm...");
            _ = Console.ReadKey();
        }
    }
}

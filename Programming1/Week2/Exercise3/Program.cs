using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            int sec = int.Parse(Console.ReadLine());

            int hour = sec / 3600;
            sec %= 3600;
            int min = sec / 60;
            sec %= 60;

            Console.WriteLine("{0}:{1}:{2}", hour, min, sec);
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

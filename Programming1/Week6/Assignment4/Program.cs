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
            Console.Write("Enter a text> ");
            SearchText(Console.ReadLine(), out int FullStops, out int Commas, out int SemiColons);

            Console.WriteLine();
            Console.WriteLine("Result: {0} full stops, {1} commas and {2} semicolons", FullStops, Commas, SemiColons);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }

        static void SearchText(string txt, out int f, out int c, out int s)
        {
            f = txt.Count(ch => ch == '.');
            c = txt.Count(ch => ch == ',');
            s = txt.Count(ch => ch == ';');
        }
    }
}

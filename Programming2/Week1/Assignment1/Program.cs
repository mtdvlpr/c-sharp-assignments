using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program MyProgram = new Program();
            MyProgram.Start();
        }

        void Start()
        {
            PrintMonth(Month.January);
            PrintMonths();
            Month month = ReadMonth("Enter a month number: ");
            PrintMonth(month);
            EndProgram();
        }

        void PrintMonth (Month month)
        {
            Console.WriteLine(month);
        }

        void PrintMonths()
        {
            for (Month i = Month.January; i <= Month.December; i++)
            {
                Console.WriteLine("{0,2}. {1}", (int) i, i);
            }
        }

        Month ReadMonth(string question)
        {
            Console.Write(question);
            int month = int.Parse(Console.ReadLine());

            while(!Enum.IsDefined(typeof(Month), month))
            {
                Console.Write(month + " is not a valid value.");
                Console.Write(question);
                month = int.Parse(Console.ReadLine());
            }
            return (Month) month;
        }

        void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

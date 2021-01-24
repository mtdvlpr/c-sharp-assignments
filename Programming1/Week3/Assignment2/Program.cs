using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number between 1 and 4: ");
            int num = int.Parse(Console.ReadLine());
            string txt;

            switch (num)
            {
                case 1:
                    txt = "Clubs";
                    break;
                case 2:
                    txt = "Diamonds";
                    break;
                case 3:
                    txt = "Hearts";
                    break;
                case 4:
                    txt = "Spades";
                    break;
                default:
                    txt = "Incorrect number!";
                    break;
            }

            Console.WriteLine(txt);

            Console.WriteLine(
                );
            Console.WriteLine("Press any key to exit the program");
            _ = Console.ReadKey();

        }
    }
}

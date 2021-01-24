using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            if (score > 100)
            {
                Console.WriteLine("You can't have a score higher than 100!");
            }
            else if (90 <= score && score <= 100)
            {
                Console.WriteLine("Grade: A");
                Console.WriteLine("Course passed");
            }
            else if (80 <= score && score < 90)
            {
                Console.WriteLine("Grade: B");
                Console.WriteLine("Course passed");
            }
            else if (70 <= score && score < 80)
            {
                Console.WriteLine("Grade: C");
                Console.WriteLine("Course passed");
            }
            else if (60 <= score && score < 70)
            {
                Console.WriteLine("Grade: D");
                Console.WriteLine("Course not passed");
            }
            else if (0 <= score && score < 60)
            {
                Console.WriteLine("Grade: F");
                Console.WriteLine("Course not passed");
            }
            else
            {
                Console.WriteLine("You can't have a score lower than 0!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

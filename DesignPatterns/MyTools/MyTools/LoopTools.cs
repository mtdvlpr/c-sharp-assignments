using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class LoopTools
    {
        public static bool LoopProgram()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Do you want to run the program again? ");
            string answer = Console.ReadLine();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Answer with 'yes' or 'no' please.");
                Console.Write("Do you want to run the program again? ");
                answer = Console.ReadLine();
            }
            if (answer == "no")
            {
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }

        public static bool LoopGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Do you want to play again? ");
            string answer = Console.ReadLine();
            while (answer != "yes" && answer != "no")
            {
                Console.WriteLine("Answer with 'yes' or 'no' please.");
                Console.Write("Do you want to play again? ");
                answer = Console.ReadLine();
            }
            if (answer == "no")
            {
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ReadTools
    {
        public static int ReadInt(string question)
        {
            int num = 0;
            Console.Write(question);
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("That was not a valid value.");
                Console.Write(question);
            }
            return num;
        }

        public static int ReadInt(string question, int min, int max)
        {
            int num = 0;
            Console.Write(question);
            while (!int.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            {
                if (num < min)
                {
                    Console.WriteLine("That number was too low.");
                }
                else if (num > max)
                {
                    Console.WriteLine("That number was too high.");
                }
                else
                {
                    Console.WriteLine("That was not a valid value.");
                }
                Console.Write(question);
            }
            return num;
        }

        public static string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}

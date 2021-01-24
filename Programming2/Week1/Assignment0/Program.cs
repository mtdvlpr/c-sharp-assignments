using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment0
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {
            int value = ReadInt("Enter a value: ");
            Console.WriteLine("You entered {0}.", value);

            int age = ReadInt("How old are you? ", 0, 120);
            Console.WriteLine("You are {0} years old.", age);

            string name = ReadString("What is your name? ");
            Console.WriteLine("Nice meeting you {0}.", name);

            _= Console.ReadKey();
        }

        int ReadInt(string question)
        {
            int num = 0;
            int stop = 0;
            while (stop == 0)
            {
                Console.Write(question);
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    stop = 1;
                }
                else
                {
                    num = 0;
                    Console.WriteLine("That was not a valid value.");
                }
            }
            return num;
            
        }

        int ReadInt(string question, int min, int max)
        {
            int num = 0;
            int stop = 0;
            while (stop == 0)
            {
                Console.Write(question);
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if(num >= min && num <= max)
                    {
                        stop = 1;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid value.");
                    }
                }
                else
                {
                    num = 0;
                    Console.WriteLine("That was not a valid value.");
                }
            }
            return num;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}

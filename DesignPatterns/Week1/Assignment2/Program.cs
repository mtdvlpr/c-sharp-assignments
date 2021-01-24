using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();
            while (run)
            {
                run = program.Start();
            }
        }

        bool Start()
        {
            IStack myStack = new ArrayStack(10);
            AddValues(myStack, 20);
            Console.WriteLine();
            ProcessValues(myStack);
            Console.WriteLine();
            AddValues(myStack, 10);
            Console.WriteLine();
            CheckValues(myStack);

            return LoopTools.LoopProgram();
        }

        void AddValues(IStack stack, int amount)
        {
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int value = rnd.Next(100);

                try
                {
                    stack.Push(value);
                    Console.WriteLine($"Pushed {value}, new count: { stack.Count}.");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }                
            }
        }
        void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                try
                {
                    int value = stack.Pop();
                    Console.WriteLine($"Popped {value}, new count: {stack.Count}.");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }            
            }
        }

        void CheckValues(IStack stack)
        {
            int value = 0;
            while (value != -1)
            {
                value = ReadTools.ReadInt("Search for a value (stop = -1): ", -1, 100);
                if(value != -1)
                {
                    if (stack.Contains(value))
                    {
                        Console.WriteLine($"The stack does contain {value}.");
                    }
                    else
                    {
                        Console.WriteLine($"The stack does not contain {value}.");
                    }
                }
            }
        }
    }
}

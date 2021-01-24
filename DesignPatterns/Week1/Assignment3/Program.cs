using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

namespace Assignment3
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
            string message = "";
            Pencil pencil = new Pencil(20);
            PencilSharpener pencilSharpener = new PencilSharpener();

            while(message != "stop")
            {
                message = ReadTools.ReadString("Enter a message: ");

                switch (message)
                {
                    case "stop":
                        break;
                    case "sharpen":
                        pencilSharpener.Sharpen(pencil);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Sharpening the pencil...");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        pencil.Write(message);
                        break;
                }

                Console.ResetColor();
            }

            return LoopTools.LoopProgram();
        }
    }
}

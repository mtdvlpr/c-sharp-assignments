using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Programmer
    {
        string name;
        Specialty specialty;

        public Programmer(string name, Specialty specialty)
        {
            this.name = name;
            this.specialty = specialty;
        }

        public Programmer(string name) : this (name, Specialty.Unknown)
        {
        }

        public void Print()
        {
            Console.Write($"Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(name);
            Console.ResetColor();
            Console.Write(", Specialty: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(specialty);
            Console.ResetColor();
        }
    }
}

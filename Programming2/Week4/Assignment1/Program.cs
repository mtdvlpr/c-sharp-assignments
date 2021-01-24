using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MyTools;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();

            while (run)
            {
                Console.Clear();
                run = program.Start();
            }
        }

        bool Start()
        {
            Person person = new Person();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (File.Exists($"{name}.txt"))
            {
                Console.WriteLine($"Nice to see you again, {name}!");
                Console.WriteLine($"We have the following information about you:");
                person = ReadPerson($"{name}.txt");
                DisplayPerson(person);
            }
            else
            {
                Console.WriteLine($"Welcome {name}!");
                person = ReadPerson();
                WritePerson(person, $"{person.name}.txt");
                Console.WriteLine("Your data is written to file.");
            }

            return ProgramTools.LoopProgram();
        }

        Person ReadPerson(string filename)
        {
            Person person = new Person();
            StreamReader reader = new StreamReader(filename);

            person.name = reader.ReadLine();
            person.city = reader.ReadLine();
            person.age = int.Parse(reader.ReadLine());

            reader.Close();

            return person;
        }

        void WritePerson(Person p, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);

            writer.WriteLine(p.name);
            writer.WriteLine(p.city);
            writer.WriteLine(p.age);

            writer.Close();
        }

        Person ReadPerson()
        {
            Person person = new Person();
            person.name = ReadString("Enter your name: ");
            person.city = ReadString("Enter your city: ");
            person.age = ReadInt("Enter your age: ", 0, 150);

            return person;
        }

        void DisplayPerson(Person p)
        {
            Console.WriteLine("{0,-10} : {1}", "Name", p.name);
            Console.WriteLine("{0,-10} : {1}", "City", p.city);
            Console.WriteLine("{0,-10} : {1}", "Age", p.age);
        }

        int ReadInt(string question)
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

        int ReadInt(string question, int min, int max)
        {
            int num = 0;
            Console.Write(question);
            while (!int.TryParse(Console.ReadLine(), out num) || num < min || num > max)
            {
                if(num < min)
                {
                    Console.WriteLine("That number was too low.");
                }
                else if(num > max)
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

        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
    }
}

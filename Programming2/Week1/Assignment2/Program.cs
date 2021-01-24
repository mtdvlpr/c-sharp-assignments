using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.Start();
        }

        void Start()
        {
            Person person1 = new Person();
            person1.FirstName = "Peter";
            person1.LastName = "Boyle";
            person1.Age = 18;
            person1.City = "Alkmaar";

            Person[] persons = new Person[3];
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i] = ReadPerson();
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < persons.Length; i++)
            {
                PrintPerson(persons[i]);
                Console.WriteLine();
            }

            PrintPerson(person1);
            CelebrateBirthday(ref person1);
            Console.WriteLine();
            PrintPerson(person1);

            EndProgram();
        }

        void CelebrateBirthday(ref Person p)
        {
            p.Age += 1;
        }

        GenderType ReadGender(string question)
        {
            int stop = 0;
            GenderType gender = GenderType.Male;
            Console.Write(question);
            string input = Console.ReadLine();
            while (stop == 0)
            {
                if (input == "m")
                {
                    gender = GenderType.Male;
                    stop = 1;
                }
                else if (input == "f")
                {
                    gender = GenderType.Female;
                    stop = 1;
                }
                else
                {
                    Console.WriteLine("That was not a valid value.");
                    Console.Write(question);
                    input = Console.ReadLine();
                }
            }
            return gender;
        }

        void PrintGender(GenderType gender)
        {
            if (gender == GenderType.Male)
            {
                Console.WriteLine("(m)");
            }
            else
            {
                Console.WriteLine("(f)");
            }
        }

        Person ReadPerson()
        {
            Person person = new Person();
            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.Age = ReadInt("Enter age: ", 1, 150);
            person.City = ReadString("Enter city: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            return person;
        }

        void PrintPerson(Person p)
        {
            Console.Write("{0} {1} ", p.FirstName, p.LastName);
            PrintGender(p.Gender);
            Console.WriteLine("{0} years old, {1}", p.Age, p.City);
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
                    if (num >= min && num <= max)
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

        void EndProgram()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

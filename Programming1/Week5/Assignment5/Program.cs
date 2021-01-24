using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            double avg;
            double sum = 0;
            int age = 1;
            int timer = 1;
            int timerPre = 0;
            int timerChild = 0;
            int timerAdult = 0;
            int[] pre = new int[50];
            int[] child = new int[50];
            int[] adult = new int[50];

            while (age != 0)
            {
                Console.Write("Enter an age (0=stop): ");
                if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                {
                    if(age > 0 && age < 4)
                    {
                        pre[timerPre] = age;
                        timerPre++;
                    }
                    else if (age > 0 && age <18)
                    {
                        child[timerChild] = age;
                        timerChild++;
                    }
                    else if (age >= 18)
                    {
                        adult[timerAdult] = age;
                        timerAdult++;
                    }
                }
                else
                {
                    Console.WriteLine("That was not a valid age!");
                    age = 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRESCHOOLERS");

            for (int i = 0; i < timerPre; i++)
            {
                Console.WriteLine("Preschooler {0} is {1} years old", timer, pre[i]);
                timer++;
                sum += pre[i];
            }
            avg = sum / timerPre;
            max = pre.Max();

            Console.WriteLine("The average preschooler is {0} years old", avg.ToString("0.##"));
            Console.WriteLine("The oldest preschooler is {0} years old", max);

            Console.WriteLine();
            Console.WriteLine("CHILDREN");

            sum = 0;
            timer = 1;
            for (int i=0;i <timerChild;i++)
            {
                Console.WriteLine("Child {0} is {1} years old", timer, child[i]);
                timer++;
                sum += child[i];
            }
            avg = sum / timerChild;
            max = child.Max();

            Console.WriteLine("The average preschooler is {0} years old", avg.ToString("0.##"));
            Console.WriteLine("The oldest preschooler is {0} years old", max);

            Console.WriteLine();
            Console.WriteLine("ADULTS");

            sum = 0;
            timer = 1;
            for (int i = 0; i < timerAdult; i++)
            {
                Console.WriteLine("Adult {0} is {1} years old", timer, adult[i]);
                timer++;
                sum += adult[i];
            }
            avg = sum / timerAdult;
            max = adult.Max();

            Console.WriteLine("The average preschooler is {0} years old", avg.ToString("0.##"));
            Console.WriteLine("The oldest preschooler is {0} years old", max);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the course name: ");
            string course = Console.ReadLine();

            Console.Write("Enter the number of students: ");
            int num;
            double sum = 0;

            if(int.TryParse(Console.ReadLine(), out num))
            {
                string[] students = new string[num];
                double[] grades = new double[num];

                for(int i=0;i<3;i++)
                {
                    Console.Write("Enter name of student {0}: ", i+1);
                    students[i] = Console.ReadLine();
                }
                Console.WriteLine();

                for(int i=0;i<num;i++)
                {
                    Console.Write("Enter the grade of {0}: ", students[i]);
                    if(double.TryParse(Console.ReadLine(), out grades[i]) && grades[i]>=1 && grades[i] <= 10)
                    {
                        sum += grades[i];
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid grade!");
                        i--;
                    }
                }

                double avg = sum / num;
                
                Console.WriteLine();
                Console.WriteLine("The average is: " + avg.ToString("0.##"));

                int max = 0;

                for (int i = 1; i < num; i++)
                {
                    if (grades[i] > grades[max])
                    {
                        max = i;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Student {0} has the highest grade, which is: {1}", students[max], grades[max]);
                Console.WriteLine();

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Grade for student {0} (course: {1}) is: {2}", students[i], course, grades[i]);
                }
            }
            else
            {
                Console.WriteLine("The number of students should be an integer!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

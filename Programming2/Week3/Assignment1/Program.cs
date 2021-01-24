using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Program program = new Program();

            while(run)
            {
                Console.Clear();
                run = program.Start();
            }
        }

        bool Start()
        {
            Course course = new Course();
            List<Course> report = new List<Course>();

            report = ReadReport(3);
            DisplayReport(report);

            return LoopProgram();
        }

        bool LoopProgram()
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
                return true;
            }
        }

        List<Course> ReadReport(int nrofCourses)
        {
            List<Course> report = new List<Course>();
            for (int i = 0; i < nrofCourses; i++)
            {
                Course course = new Course();
                report.Add(ReadCourse(course));
            }
            return report;
        }

        void DisplayReport(List<Course> report)
        {
            int courses = 0;
            int retakes = 0;
            int cumLaude = 0;
            foreach (Course course in report)
            {
                courses++;
                DisplayCourse(course);
                if(!course.Passed())
                {
                    retakes++;
                }
                if(course.CumLaude())
                {
                    cumLaude++;
                }
            }
            if(retakes > 0)
            {
                Console.WriteLine($"Too bad, you did not graduate, you got {retakes} retakes.");
            }
            else if(cumLaude == courses)
            {
                Console.WriteLine("Great job, you graduated Cum Laude!");
            }
            else
            {
                Console.WriteLine("Good job, you graduated.");
            }
        }

        PracticalGrade ReadPracticalGrade(string question)
        {
            Console.Write(question);
            int grade = int.Parse(Console.ReadLine());
            while (!Enum.IsDefined(typeof(PracticalGrade), grade))
            {
                Console.WriteLine(grade + " is not a valid value.");
                Console.Write(question);
                grade = int.Parse(Console.ReadLine());
            }
            return (PracticalGrade)grade;
        }

        Course ReadCourse(Course course)
        {
            string question;
            Console.WriteLine("Enter a course.");
            course.Name = ReadString("Name of the course: ");
            question = "Grade for " + course.Name + ": ";
            course.Grade = ReadInt(question, 0, 100);
            for (PracticalGrade i = PracticalGrade.None; i <= PracticalGrade.Good; i++)
            {
                int num = (int)i;
                Console.Write("{0}. {1} ", num, i);
            }
            Console.WriteLine();
            question = "Practical grade for " + course.Name + ": ";
            course.Practical = ReadPracticalGrade(question);
            Console.WriteLine();
            return course;

        }

        void DisplayCourse(Course course)
        {
            Console.WriteLine("{0,-15} : {1,-3} {2}", course.Name, course.Grade, course.Practical);
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Enter length (cm): ");
            double length = double.Parse(Console.ReadLine()) / 100;

            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            if (gender == "male" || gender == "female")
            {
                double bmi = weight / (length * length);
                Console.WriteLine("BMI-value: {0}", bmi.ToString("0.#"));

                double weightMin;
                double weightMax;

                if (gender == "male")
                {
                    Console.WriteLine("Normal BMI-values: 20 - 25");
                    weightMin = 20 * length * length;
                    weightMax = 25 * length * length;
                }
                else
                {
                    Console.WriteLine("Normal BMI-values: 19 - 24");
                    weightMin = 19 * length * length;
                    weightMax = 24 * length * length;
                }

                Console.WriteLine("Healthy weight range: {0} - {1}", weightMin.ToString("0.#"), weightMax.ToString("0.#"));
            }
            else
            {
                Console.WriteLine("Your gender should be 'male' or 'female'!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit the program...");
            _ = Console.ReadKey();
        }
    }
}

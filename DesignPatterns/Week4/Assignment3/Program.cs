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
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            // create a tank (and assign it to a driver)
            IAttacker attacker1 = new Tank();
            attacker1.AssignDriver("Frank");

            // create a robot (and let it move by a person)
            IAttacker attacker2 = new RobotAdapter(new Robot());
            attacker2.AssignDriver("Mark");

            Console.WriteLine();

            // create attackers list, and add tank and robot
            List<IAttacker> attackers = new List<IAttacker>();
            attackers.Add(attacker1);
            attackers.Add(attacker2);
            
            // process all attackers
            foreach (IAttacker attacker in attackers)
            {
                attacker.DriveForward();
                attacker.UseWeapon();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

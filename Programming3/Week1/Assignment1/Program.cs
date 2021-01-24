using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;

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
                run = program.Start();
            }
        }

        bool Start()
        {
            Programmer p1 = new Programmer("Hank", Specialty.PHP);
            Programmer p2 = new Programmer("Peter", Specialty.Java);
            Programmer p3 = new Programmer("Samantha", Specialty.HTML);
            Programmer p4 = new Programmer("Astrid");

            p1.Print();
            Team team = new Team();
            team.AddProgrammer(p1);
            team.AddProgrammer(p2);
            team.AddProgrammer(p3);
            team.AddProgrammer(p4);
            team.PrintAllTeamMembers();

            return ProgramTools.LoopProgram();
        }
    }
}

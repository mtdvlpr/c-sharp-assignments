using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Team
    {
        List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void PrintAllTeamMembers()
        {
            foreach(Programmer p in programmers)
            {
                p.Print();
            }
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }
    }
}

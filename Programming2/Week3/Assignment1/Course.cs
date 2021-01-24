using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Course
    {
        public string Name;
        public int Grade;
        public PracticalGrade Practical;

        public bool Passed()
        {
            if (Grade >= 55 && (Practical == PracticalGrade.Sufficient || Practical == PracticalGrade.Good))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CumLaude()
        {
            if (Grade >= 80 && Practical == PracticalGrade.Good)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

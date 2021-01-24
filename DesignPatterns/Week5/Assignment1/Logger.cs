using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Logger
    {
        private int numberOfLines;
        private static Logger uniqueInstance;

        private Logger()
        {
            numberOfLines = 1;
        }

        public static Logger GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Logger();
            }

            return uniqueInstance;
        }

        public void Log(string location, string log)
        {
            Console.WriteLine($"{numberOfLines} - [{location}] {log}");
            numberOfLines++;
        }
    }
}

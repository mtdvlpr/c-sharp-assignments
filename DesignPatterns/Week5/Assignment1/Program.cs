using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        private readonly Logger logger = Logger.GetInstance();
        private readonly MainSystem mainSystem = new MainSystem();

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            logger.Log("main", "starting");
            mainSystem.DoSomeMainWork();
            logger.Log("main", "finishing");

            _ = Console.ReadKey();
        }
    }
}

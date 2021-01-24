using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MainSystem
    {
        private readonly SubSystem subSystem;
        private readonly Logger logger;

        public MainSystem()
        {
            subSystem = new SubSystem();
            logger = Logger.GetInstance();
        }

        public void DoSomeMainWork()
        {
            logger.Log("MainSystem", "doing some main work");
            subSystem.DoSomeWork();
            subSystem.DoSomeMoreWork();
        }
    }
}

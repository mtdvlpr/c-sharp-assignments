using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            CallDataLoader callDataLoader = new CallDataLoader();
            TwitterDataLoader twitterDataLoader = new TwitterDataLoader();
            SensorDataLoader sensorDataLoader = new SensorDataLoader();
            BatchProcessor batchProcessor = new BatchProcessor();

            batchProcessor.Add(callDataLoader);
            batchProcessor.Add(twitterDataLoader);
            batchProcessor.Add(sensorDataLoader);

            batchProcessor.ProcessAll();

            return LoopTools.LoopProgram();
        }
    }
}

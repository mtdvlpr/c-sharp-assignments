using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class BatchProcessor
    {
        List<BigDataLoader> bigDataLoaders;

        public BatchProcessor()
        {
            bigDataLoaders = new List<BigDataLoader>();
        }

        public void Add(BigDataLoader bigDataLoader)
        {
            bigDataLoaders.Add(bigDataLoader);
        }

        public void ProcessAll()
        {
            foreach (BigDataLoader bigDataLoader in bigDataLoaders)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[ETL-Proces started]");
                Console.ResetColor();

                bigDataLoader.ReadData();

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("[ETl-proces finished]");
                Console.ResetColor();

                Console.WriteLine();
            }
        }
    }
}

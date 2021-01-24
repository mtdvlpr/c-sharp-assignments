using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class SensorDataLoader : BigDataLoader
    {
        protected override void ExtractData()
        {
            Console.WriteLine("Extracting sensor data...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Transforming sensor data...");
        }

        protected override void LoadData()
        {
            Console.WriteLine("Loading sensor data...");
        }
    }
}

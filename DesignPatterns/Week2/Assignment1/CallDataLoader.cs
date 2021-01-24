using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class CallDataLoader : BigDataLoader
    {
        protected override void ExtractData()
        {
            Console.WriteLine("Extracting call data...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Transforming call data...");
        }

        protected override void LoadData()
        {
            Console.WriteLine("Loading call data...");
        }
    }
}

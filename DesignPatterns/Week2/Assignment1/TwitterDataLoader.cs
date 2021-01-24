using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TwitterDataLoader : BigDataLoader
    {
        protected override void ExtractData()
        {
            Console.WriteLine("Extracting twitter data...");
        }

        protected override void TransformData()
        {
            Console.WriteLine("Transforming twitter data...");
        }

        protected override void LoadData()
        {
            Console.WriteLine("Loading twitter data...");
        }
    }
}

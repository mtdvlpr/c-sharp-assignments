using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    abstract class BigDataLoader
    {
        public void ReadData()
        {
            ExtractData();
            TransformData();
            LoadData();
        }

        protected abstract void ExtractData();

        protected abstract void TransformData();

        protected abstract void LoadData();
    }
}

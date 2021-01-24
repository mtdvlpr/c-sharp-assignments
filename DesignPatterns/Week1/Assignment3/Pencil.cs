using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Pencil : IPencil
    {
        private readonly int maxToWrite;
        private int nrOfCharsWritten;

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
        }

        public bool CanWrite
        {
            get
            {
                return nrOfCharsWritten < maxToWrite;
            }
        }

        public void Write(string message)
        {
            foreach (char character in message)
            {
                if(CanWrite)
                {
                    Console.Write(character);
                    nrOfCharsWritten++;
                }
                else
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }
    }
}

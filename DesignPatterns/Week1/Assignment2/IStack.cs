using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    interface IStack
    {
        void Push(int value);

        int Pop();

        bool Contains(int value);

        int Count { get; }

        bool IsEmpty { get; }
    }
}

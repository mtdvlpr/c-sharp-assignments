using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class ArrayStack : IStack
    {
        private int[] stack;

        public int Count { get; set; }

        public bool IsEmpty
        {
            get
            {
                return Count == 0;
            }
        }

        public ArrayStack(int maximum)
        {
            stack = new int[maximum];
            Count = 0;
        }

        public void Push(int value)
        {
            if (Count < stack.Length)
            {
                stack[Count] = value;
                Count++;
            }
            else
            {
                throw new Exception($"Couldn't push {value}, because the stack is full!");
            }
        }

        public int Pop()
        {
            if (!IsEmpty)
            {
                int value = stack[Count - 1];
                stack[Count - 1] = 0;
                Count--;

                return value;
            }
            else
            {
                throw new Exception($"Couldn't pop the last value, because the stack is empty!");
            }
        }

        public bool Contains(int value)
        {
            for (int i = 0; i < stack.Length; i++)
            {
                if (value == stack[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}

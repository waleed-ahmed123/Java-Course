using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class IntStack
    {
        private const int maxsize = 10;
        private int top = 0;
        private int[] array = new int[maxsize];

        public void Push(int value)
        {
            // insert code here 
            array[top] = value;
            top++;
        }

        public int Pop()
        {
            top--;
            return array[top];
            
        }

        public int Peek()
        {
            // insert code here
            return 0;
        }

        public bool IsEmpty()
        {
            if (top == 0)
            {
                return true; // insert code here
            }

            return false;
        }

        public bool IsFull()
        {
            if(top == maxsize)
            {
                return true;
            }
            //return top == maxsize;
            return false;
        }

        public string Print()
        {
            StringBuilder output = new StringBuilder();
            for (int i = top - 1; i >= 0; i--)
                output.Append(array[i] + Environment.NewLine);
            return output.ToString();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar1b_StackOfObjects
{
    class jobStack
    {
        private const int maxsize = 10; //size of array
        private int top = 0;
        private Job[] array = new Job[maxsize];

        public void Push(Job value)
        {
            // insert code here 
           if(!IsFull())
            {
                array[top] = value;
                top++;
            }
            
        }

        public Job Pop()
        {
            if(!IsEmpty())
            {
                return array[--top];
            }
            return null;
        }

        public Job Peek()
        {
            if (!IsEmpty())
            {
                return array[top-1];
            }
            return null;

        }

        public bool IsEmpty()
        {
            return // insert code here
        }

        public bool IsFull()
        {
            return top == maxsize;
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

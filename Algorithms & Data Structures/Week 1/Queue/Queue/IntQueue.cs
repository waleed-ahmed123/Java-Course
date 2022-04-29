using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Queue
{
    class IntQueue
    {
        private readonly int maxsize=10;
        private int[] store;
        private int head = 0;
        private int tail = 0;
        private int numItems;

        public IntQueue()
        {
            store = new int[maxsize];
        }

        public IntQueue(int maxsize)
        {
           // maxsize = size;
            store = new int[maxsize];
        }

        public void Enqueue(int value)
        {

            numItems++;
            store[tail] = value;
            //tail++;

            if (++tail == maxsize)
            {
                tail = 0;
                numItems--;
            }
            //tail++;
        }


        public int Dequeue()
        {
            // insert code
            int headItem;
            numItems--;
            headItem = store[head];
            

            if (++head == maxsize)
            {
                head = 0;
                numItems = maxsize;
            }
            //head++;
            return headItem;
        }

        public int Peek()
        {
            return store[head];
        }

        public bool IsEmpty()
        {
            if (head == tail)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public bool IsFull()
        {
            if (tail == maxsize)
            {
                numItems = maxsize;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int NumberOfItems()
        {
            return numItems;
        }

        public string Print()
        {
            string buffer = "";
            //IntQueue temp = myQueue;
            for(int i = head; i<=maxsize-1;  i++)
            {
                Console.WriteLine(store[i]);
            }
            //return buffer;
            return buffer;
        }

    }


}


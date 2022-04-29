using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_A
{
    class IntQueue
    {
        private readonly int maxsize = 10;
        private string[] store;
        private int head = -1;
        private int tail = -1;
        private int numItems;

        public IntQueue()
        {
            store = new string[maxsize];
            head = -1;
            tail = -1;
        }

       
        public void Enqueue(string value)
        {
            if (IsFull())
            {
                
            }

            if(head == -1)
            {
                head = 0;
            }

            if(tail == store.Length-1)
            {
                tail = 0;
            }

            else
            {
                tail = tail + 1;
            }

            store[tail] = value;
        }


        public string Dequeue()
        {
            if (IsEmpty())
            {

            }

            string headItem = store[head];

            if(head == tail)
            {
                head = -1;
                tail = -1;
            }

            else if(head == store.Length-1)
            {
                head = 0;
            }
            else
            {
                head = head + 1;
            }
            return headItem;
        }



        public string Peek()
        {
            if (IsEmpty())
            {

            }

            return store[head];
        }

        public bool IsEmpty()
        {
            return (head == -1);
        }

        public bool IsFull()
        {
            return ((head == 0 && tail == store.Length - 1)) || (head == tail + 1);
        }

        public int NumberOfItems()
        {
            if (IsEmpty())
            {
                return 0;
            }
            if (IsFull())
            {
                return store.Length;
            }
            int i = head;
            int numItems = 0;

            if(head <= tail)
            {
                while(i <= tail)
                {
                    numItems++;
                    i++;
                }
            }

            else
            {
                while (i <= store.Length - 1)
                {
                    numItems++;
                    i++;
                }

                i = 0;
                while (i <= tail)
                {
                    numItems++;
                    i++;
                }
            }

            return numItems;
        }


        public string Print()
        {
            string buffer = " ";

            if (IsEmpty())
            {
                return buffer;
            }

            int i = head;
            if(head <= tail)
            {
                while(i <= tail)
                {
                    buffer = buffer + store[i++] + ", ";
                }
            }
            else
            {
                while(i <= store.Length - 1)
                {
                    buffer = buffer + store[i++] + ", ";
                }

                i = 0;
                while(i <= tail)
                {
                    buffer = buffer + store[i++] + ", ";
                }
            }

            return buffer;
        }
    }
}

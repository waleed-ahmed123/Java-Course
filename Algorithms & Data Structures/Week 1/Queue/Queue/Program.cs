using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            IntQueue myQueue = new IntQueue();

            Console.WriteLine(myQueue.IsEmpty());
            Console.WriteLine(myQueue.IsFull());

            myQueue.Enqueue(4);
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
            myQueue.Enqueue(7);
            myQueue.Enqueue(8);
            myQueue.Enqueue(9);
            myQueue.Enqueue(10);
            myQueue.Enqueue(11);
            myQueue.Enqueue(12);
            myQueue.Enqueue(13);
            myQueue.Enqueue(14);
            //Console.WriteLine(myQueue.Peek());
            //Console.WriteLine(myQueue.IsFull());
            //Console.WriteLine(myQueue.IsEmpty());

            //Console.WriteLine(myQueue.Dequeue());
            //myQueue.Dequeue();
            //myQueue.Dequeue();

            Console.WriteLine( myQueue.Print());
            Console.WriteLine(myQueue.NumberOfItems());


            System.Console.ReadKey();
        }
    }
}

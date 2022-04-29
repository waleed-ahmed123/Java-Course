using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStack mystack = new IntStack();

            mystack.Push(10);
            //System.Console.WriteLine(mystack.Pop());
            //System.Console.WriteLine(mystack.Print());



            mystack.Push(20);
            mystack.Push(30);
            mystack.Push(40);

            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());
            System.Console.WriteLine(mystack.Pop());


            System.Console.WriteLine(mystack.Print());
            System.Console.WriteLine(mystack.IsEmpty());


            System.Console.ReadKey();
        }

    }
}

﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Link myList = new Link(5, null);

            myList = new Link(6, myList);
            myList = new Link(8, new Link(7, myList));

            Link temp = myList;
            while (temp != null)
            {

                Console.WriteLine(temp.Data);
                temp = temp.Next;

             
            }

           
            Console.ReadKey();
        }


   


    }
}

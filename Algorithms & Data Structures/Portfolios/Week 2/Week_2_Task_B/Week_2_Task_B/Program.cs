using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList<Book> myList = new LinkList<Book>();
           

            myList.AddItem(new Book("creeper", "mark", 2078));
            myList.AppendItem(new Book("insidious", "bob", 1764));
            myList.AppendItem(new Book("scary", "john", 1563));

            myList.RemoveItem(new Book("insidious", "bob", 1764));

            myList.SortData();

            Console.Write(myList.DisplayList());
            Console.WriteLine(myList.NumberOfItems());

            Console.ReadKey();

        }
    }
}

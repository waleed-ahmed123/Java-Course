using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<Book> books = new LinkedList<Book>();
            


            Book[] books = new Book[3];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");

            books[1] = new Book("my book");
            books[1] = new Horror("The Creeping");
            //books[1].Genres = new Genre("horror", "the creeping");

            books[2] = new Book("my book 2");
            books[2] = new Horror("Insidious");
            books[2].Author = new Person("David Clarke");

            for (int i = 0; i < 3; i++)
                Console.WriteLine("{0}  {1} ", books[i].Author.Name, books[i].Title); 
            

            Console.ReadKey();
        }

    }
}

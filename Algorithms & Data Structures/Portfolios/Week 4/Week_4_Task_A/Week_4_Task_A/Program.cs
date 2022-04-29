using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to construct an array of Book

            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns",
                "ZZ"};
            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284" };

            Book[] library = new Book[10];


            // fill an array of books
            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);

            }



            // call SelectSortGen to sort the array library (choose to sort the books by using either title, author or isbn)
            //display sorted array so you can check that the sorting method works also for an array of Book


            SelectionSort<Book>(library);

            Console.WriteLine("Selection sort of Books");

            for (int i = 0; i < library.Length; i++)
            {
                Console.WriteLine(library[i]);
            }


            // create an array of int
            // call SelectSortGen to sort the array of int
            ////display sorted array so you can check that the sorting method works also for an array of int

            int min = 0;
            int max = 200;

            int[] test2 = new int[10];

            Random randNum = new Random();

            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(min, max);
            }

            SelectionSort<int>(test2);

            Console.WriteLine("Selection sort of integers");

            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }

            // create an array of string
            // call SelectSortGen to sort the array of string 
            ////display sorted array so you can check that the sorting method works also for an array of string

            //string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };

            Console.WriteLine("Selection sort of strings");

            SelectionSort<string>(authors);
            for (int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine(authors[i]);
            }

            Console.ReadKey();
        }




        static void SelectionSort<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest]) < 0)
                        smallest = j;
                }
                Swap(ref a[i], ref a[smallest]);
            }
        }


        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_4a
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 93;
            int y = 44;

            Console.WriteLine("before swap: ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            swap(ref x, ref y);
            Console.WriteLine("after swap: ");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("****************");


            int min = 0;
            int max = 200;

            int[] test2 = new int[10];

            Random randNum = new Random();

            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(min, max);
            }
            /*Console.WriteLine("bubble sort - before swap");

            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }

            bubbleSort(test2);
            Console.WriteLine("bubble sort - after swap");
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }*/




            Console.WriteLine("****************");


            Console.WriteLine("selection sort - before swap");

            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }

            selectionSort(test2);
            Console.WriteLine("selection sort - after swap");
            for (int i = 0; i < test2.Length; i++)
            {
                Console.WriteLine(test2[i]);
            }

            Console.WriteLine("****************");
            string[] titles = { "de", "abc", "fg" };
            string[] author = { "a", "d", "f" };
            string[] isbn = { "23", "56", "67" };

            Book[] library = new Book[3];
            for(int i=0; i<library.Length; i++)
            {
                library[i] = new Book(titles[i], author[i], isbn[i]);
            }


            Console.WriteLine("selection sort for an array of books");
            selectionSort(library);
            foreach(Book book in library)
            {
                Console.WriteLine(book);
            }

            Console.ReadKey();
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }


        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }



        static void bubbleSort(int[] numbers)
        {
            bool swapped = true;

            int upper = numbers.Length - 1;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < upper; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        swap(ref numbers[i], ref numbers[i + 1]);
                        swapped = true;
                    }
                }
                upper--;
            }
        }



        static public void selectionSort(int[] a)
        {
            for(int i=0; i<a.Length; i++)
            {
                //find smallest from a[i] to a[a.length -1]
                //swap with the begginig of the array

                int smallest = i;
                for(int j=i+1; j<a.Length; j++)
                {
                    if(a[j] < a[smallest])
                    {
                        smallest = j;
                    }
                }
                swap(ref a[i], ref a[smallest]);
            }
        }

        static public void selectionSort(Book[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                //find smallest from a[i] to a[a.length -1]
                //swap with the begginig of the array

                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest])<0)
                    {
                        smallest = j;
                    }
                }
                swap(ref a[i], ref a[smallest]);
            }
        }

    }
}

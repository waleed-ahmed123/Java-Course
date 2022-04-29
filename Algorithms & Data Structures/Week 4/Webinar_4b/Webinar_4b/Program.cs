using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webinar_4b
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 200;

            int[] test2 = new int[10];

            Random randNum = new Random();

            for(int i=0; i<test2.Length; i++)
            {
                test2[i] = randNum.Next(min, max);
            }


            quickSortDD2(test2, 0, test2.Length - 1);

            Console.WriteLine("Quick Sort");
            for(int i=0; i<test2.Length-1; i++)
            {
                Console.WriteLine(test2[i]);
            }

            Console.WriteLine("********************");

            Console.WriteLine("how many types?");
            int numEx = Convert.ToInt32(Console.ReadLine());

            Exercise[] arrayex = new Exercise[numEx];

            for(int i=0; i!=arrayex.Length; i++)
            {
                Exercise e = new Exercise();
                Console.WriteLine("exercise name ");
                e.Name = Console.ReadLine();

                Console.WriteLine("number of credits");
                e.Credits = Convert.ToInt32(Console.ReadLine());

                arrayex[i] = e;

            }


            for(int i =0; i!=arrayex.Length; i++)
            {
                Console.WriteLine("Exercise name: " + arrayex[i].Name + " number of credits: " + arrayex[i].Credits);
            }

            Console.WriteLine("num of credits?");
            int totalCredits = Convert.ToInt32(Console.ReadLine());

            miniExercises(arrayex, totalCredits);

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

        static void quickSortDD2(int[] items, int left, int right)
        {
            int i, j;
            i = left;
            j = right;

            int pivot = items[left];
            while (i <= j)
            {
                // partioning of the array

                //movement of i index
                for (; (items[i] < pivot) && (i < right); i++) ;
                //movement of j index
                for (; (pivot < items[j]) && (j > left); j--) ;

                if (i <= j)
                {
                    swap(ref items[i++], ref items[j--]);
                }

                // recursive call
                if(left<j)
                quickSortDD2(items, left, j);
                
                if(i<right)
                quickSortDD2(items, i, right);
            }
        }






        static void miniExercises(Exercise[] arrayex, int n)
        {
            int sum = 0;
            //will sort in descending order

            //50, 25, 10, 5, 1

            quickSortDD2(arrayex, 0, arrayex.Length - 1);

            while (sum != n)
            {
                Exercise x;
                int i = -1;
                do
                {
                    i++;
                    x = arrayex[i];
                } while (x.Credits + sum > n);

                sum = sum + x.Credits;
                Console.WriteLine("exercise: " + x.Name + " credits: " + x.Credits);
            }

        }



        static void quickSortDD2(Exercise[] items, int left, int right)
        {
            int i, j;
            i = left;
            j = right;

            Exercise pivot = items[left];
            while (i <= j)
            {
                // partioning of the array

                //movement of i index
                for (; (items[i].CompareTo(pivot)<0) && (i < right); i++) ;
                //movement of j index
                for (; (pivot.CompareTo(items[j])<0) && (j > left); j--) ;

                if (i <= j)
                {
                    swap(ref items[i++], ref items[j--]);
                }

                // recursive call
                if (left < j)
                    quickSortDD2(items, left, j);

                if (i < right)
                    quickSortDD2(items, i, right);
            }
        }
    }
}

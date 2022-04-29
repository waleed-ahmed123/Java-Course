using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //printNumbers(5);
            //range(5, 10);
            //getNumberString(3);
            //Console.WriteLine( Power(2, 4));
            Console.WriteLine(multiply(8, 4));
            Console.ReadLine();
        }



        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }

            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);

        }

        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            if (start == stop)
            {
                /* stopping condition - what needs to be done? */
                Console.WriteLine(start);
            }
            else if(start > stop)
            {
                range(stop, start);
            }

            else
            {
                /* recursive call and print start*/
                Console.WriteLine(start);
                range(start+1, stop);
               
             }
        }

        static string getNumberString(int n)
        {
            if (n == 0)
                return "0";
            else
            {
                return Convert.ToString(getNumberString(n-1));
                //return Convert.ToString(n);
            }
        }


        static int Power(int x, int y) //x to the power of y
        {
            if( y== 0)
            {
                return 1;
            }
            else if (y == 1)
            {
                return x;
            }
            else
            {
              return x * Power(x, y - 1);
            }

        }


        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
               return x +  multiply(x, y - 1);

    }

    }
}

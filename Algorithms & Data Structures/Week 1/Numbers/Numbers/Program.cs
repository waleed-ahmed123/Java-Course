using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float average;
            int numbers, nextNum;
            int total = 0;
            int count = 0;
            string input;
            Console.WriteLine("How Many Numbers?: ");
            //Console.WriteLine("Enter 1st Number :");
            input = Console.ReadLine();  //waits for user to hit return
            numbers = Convert.ToInt32(input);
            while (count < numbers)
            {
                Console.WriteLine("Enter A Number: ");
                input = Console.ReadLine();
                total = total + Convert.ToInt32(input);
                count++;
            }

            average = (float) total / (float)numbers;
            Console.WriteLine("Average is : {0} ", average);


            //num1 = Convert.ToInt32(input);
            //Console.WriteLine("Enter 2nd Number :");
            //input = Console.ReadLine();
            //num2 = Convert.ToInt32(input);
            //Console.WriteLine("Sum is : {0}, power is : {1} ", sum(num1, num2), power(num1, num2));
            //{0} takes 1st argument and substitutes into string


            Console.ReadKey();  //waits for a key to press before ending
        }

        static int sum(int x, int y)
        {
            return x + y;
        }

        static int power(int x, int y)
        {
            int result = 1;
            for(int i=0; i<y; i++)
            {
                result = x * result;
            }

            return result;
        }

    }
}

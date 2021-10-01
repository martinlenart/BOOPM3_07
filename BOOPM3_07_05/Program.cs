using System;

namespace BOOPM3_07_05
{
    class Program
    {
        static void CountDownIterative(int number)
        {
            for (int i = number; i >= 0; i--)
            {
                Console.Write($"{i,3}");
            }
        }
        static void CountDownRecursive(int number)
        {
            //base case
            if (number < 0) return;

            //action case
            Console.Write($"{number,3}");

            //recursive case
            CountDownRecursive(number - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\nCount Down Iterative");
            CountDownIterative(10);

            Console.WriteLine("\n\nCount Down Recursive");
            CountDownRecursive(10);
        }
    }
}

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
            if (number < -10) return;

            //recursive case
            CountDownRecursive(number - 2);

            //action case
            Console.Write($"{number,3}");
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

//Exercise
//1.    In CountDownRecursive move the action case to happen after the recursive case. Compile and execute.
//      - Can you explain what happens and why the number sequence changes

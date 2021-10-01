using System;

namespace BOOPM3_07_06
{
    class Program
    {
        static long FactorialIterative(long number)
        {
            var factor = number;
            for (long i = number - 1; i > 0; i--)
            {
                //action case
                factor *= i;
            }

            return factor;
        }
        static long FactorialRecursive(long number)
        {
            //base case, Viewpoint A
            if (number <= 0) return 1;

            //action case and recursive case, Viewpoint B
            var factor = number * FactorialRecursive(number - 1);

            // Viewpoint C
            return factor;
        }

        static void Main(string[] args)
        {
            long number = 3;
            Console.WriteLine("FactorialIterative");
            var result = FactorialIterative(number);
            Console.WriteLine($"{number}! = {result}");

            Console.WriteLine("\n\nFactorialRecusrsive");
            result = FactorialRecursive(number);
            Console.WriteLine($"{number}! = {result}");
        }
    }
}

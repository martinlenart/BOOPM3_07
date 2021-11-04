using System;

namespace BOOPM3_07_06
{
    class Program
    {
        //3! = 3*2*1
        //5! = 5*4*3*2*1
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
//Exercises:
//1.    Modify the action case in FactorialRecursive so that 5*5*4*4*3*3*2*2*1 is calculated instead of 5*4*3*2*1
//      for FactorialRecursive(5) a call
//2.    Bring in a parameter in FactorialRecursive(..) that indicates how many time a numer should be multiplied by itself.
//      So, for example, if the paramater is 3 the calculation should be 5*5*5*4*4*4... etc.

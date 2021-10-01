using System;

namespace BOOPM3_07_07
{
    class Program
    {
        static long DoubleSumIterative(long[] array)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
                sum += array[i];
            }
            return sum;
        }

        static long DoubleSumRecursive(long[] array, int index = 0)
        {
            //base case
            if (index >= array.Length) return 0;

            //action case
            array[index] *= 2;

            //recursive case
            long sum = array[index] + DoubleSumRecursive(array, index + 1);
            return sum;
        }

        static void Main(string[] args)
        {
            long[] startArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("DoubleSumIterative");
            Console.WriteLine($"Sum: {DoubleSumIterative(startArray)}");

            startArray = new long[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nDoubleSumRecursive");
            Console.WriteLine($"Sum: {DoubleSumRecursive(startArray)}");
        }
    }
}

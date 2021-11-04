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

        static long DoubleSum(long[] array, long[] array2)
        {
            return DoubleSumRecursive(array, array2, 0);
        }
        static long DoubleSumRecursive(long[] array, long[] array2, int index)
        {
            //base case
            if (index >= array.Length) return 0;

            //action case
            //            array[index] *= 2;
            var s = array[index] + array2[index];

            //recursive case
            long sum = s + DoubleSumRecursive(array, array2, index + 1);
            return sum;
        }

        static void Main(string[] args)
        {
            long[] startArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("DoubleSumIterative");
            Console.WriteLine($"Sum: {DoubleSumIterative(startArray)}");

            startArray = new long[] { 1, 2, 3, 4, 5 };
            long[] startArray2 = new long[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nDoubleSumRecursive");
            Console.WriteLine($"Sum: {DoubleSum(startArray, startArray2)}");
        }
    }
}
//Exercise
//1.    Make a recursive method SumArraysRecursive that takes two double[] as parameters and adds the two arrays element by element,
//      returning one double bvalue at the end

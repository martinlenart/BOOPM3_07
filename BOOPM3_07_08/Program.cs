using System;

namespace BOOPM3_07_08
{
    class Program
    {
        static int CountSpaceIterative(string myString)
        {
            int count = 0;
            foreach (var c in myString)
            {
                if (c == ' ')
                    count++;
            }
            return count;
        }

        static int CountSpaceRecursive(string mystring, int idx = 0)
        {
            //base case
            if (idx >= mystring.Length)
                return 0;

            //action
            var sum = mystring[idx] == ' ' ? 1 : 0;

            //recursive case
            return sum + CountSpaceRecursive(mystring, idx + 1);
        }

        static void Main(string[] args)
        {
            var startString = "the quick brown fox catches the rabbit";
            Console.WriteLine("CountSpaceIterative");
            Console.WriteLine($"Nr of spaces: {CountSpaceIterative(startString)}");

            Console.WriteLine("\nCountSpaceRecursive");
            Console.WriteLine($"Nr of spaces: {CountSpaceRecursive(startString)}");
        }
    }
}

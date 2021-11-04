using System;

namespace BOOPM3_07_11
{
    class Program
    {
        static long NrOfPaths(long nrOfStairs)
        {
            //base case
            if (nrOfStairs <= 0)
                return 0;
            if (nrOfStairs == 1)
                return 1;
            if (nrOfStairs == 2)
                return 2;
            if (nrOfStairs == 3)
                return 4;

            return NrOfPaths(nrOfStairs - 1) + NrOfPaths(nrOfStairs - 2) + NrOfPaths(nrOfStairs - 3);
        }

        static void Main(string[] args)
        {
            long nrOfStairs = 20;
            Console.WriteLine($"Nr of ways to climb the staircase: {NrOfPaths(nrOfStairs):N0}");
        }
    }
}

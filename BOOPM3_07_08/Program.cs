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
            //var sum = mystring[idx] == ' ' ? 1 : 0;
            var sum = 0;
            if (mystring[idx] == ' ')
                sum = 1;

            //recursive case
            return sum + CountSpaceRecursive(mystring, idx + 1);
        }

        static int CountWordRecursive(string[] mySentence, string word, int idx = 0)
        {
            //base case
            if (idx >= mySentence.Length)
                return 0;

            //action case
            var sum = 0;
            if (mySentence[idx] == word)
                sum = 1;

            //recursive
            return sum + CountWordRecursive(mySentence, word, idx + 1);
        }

        static void Main(string[] args)
        {
            var startString = "the quick brown fox catches the rabbit";
            Console.WriteLine("CountSpaceIterative");
            Console.WriteLine($"Nr of spaces: {CountSpaceIterative(startString)}");

            Console.WriteLine("\nCountSpaceRecursive");
            Console.WriteLine($"Nr of spaces: {CountSpaceRecursive(startString)}");

            Console.WriteLine("\nCountWordRecursive");
            string[] sentence = "The quick quick brown fox catches another fox".Split(' ');
            string find = "black";

            Console.WriteLine($"Nr of {find}: {CountWordRecursive(sentence, find)}");

        }
    }
}
//Exercises:
//1.    Make a method that takes a string[] as parameter and recursively counts the number of occurances of a particular string in the array.
//2.    Make a method that takes a string[] as parameter and recursively search for an occurances of a particular string
//      in the array and returns true or false depending on success. Index of the found string should be given as out parameter


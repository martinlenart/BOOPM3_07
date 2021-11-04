using System;
using System.IO;

namespace BOOPM3_07_09
{
    class Program
    {
        static void FindDirectoriesIterative(string myDirectory)
        {
            //Get first level directories
            Console.WriteLine(myDirectory);
            foreach (var dir1 in Directory.EnumerateDirectories(myDirectory))
            {

                Console.WriteLine($"{dir1}");

                
                #region get second level directories
                try
                {
                    //Get second level directories, where I have access control
                    foreach (var dir2 in Directory.EnumerateDirectories(dir1))
                    {
                        Console.WriteLine($"{dir2}");
                
                        #region get third level directories
                        try
                        {
                            //Get third level directories, where I have access control
                            foreach (var dir3 in Directory.EnumerateDirectories(dir2))
                            {
                                Console.WriteLine($"{dir3}");
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            continue;
                        }
                        #endregion
                
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }
                #endregion
                
            }
        }

        static void FindDirectoriesRecursive(string myDirectory, int nr_levels)
        {
            //base case
            if (nr_levels <= 0)
                return;

            //action case
            Console.WriteLine(myDirectory);

            //recursive case
            try
            {
                foreach (var dir1 in Directory.EnumerateDirectories(myDirectory))
                {
                    FindDirectoriesRecursive(dir1, nr_levels - 1);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }

            //base case also when the above foreach loop has concluded
        }


        static void Main(string[] args)
        {
            var startDirectory = @"C:\Users\marti";
            Console.WriteLine("FindDirectoriesIterative");
            FindDirectoriesIterative(startDirectory);

            Console.WriteLine("\n\nFindDirectoriesRecursive");
            FindDirectoriesRecursive(startDirectory, 6);

        }
    }
}

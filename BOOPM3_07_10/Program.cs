using System;
using System.IO;

namespace BOOPM3_07_10
{
    class Program
    {
        static int CountDirectoriesIterative(string myDirectory)
        {
            //Found myDirectory
            int nrDirs = 1;

            //Get first level directories
            foreach (var dir1 in Directory.EnumerateDirectories(myDirectory))
            {
                nrDirs++;

                #region get second level directories
                try
                {
                    //Get second level directories, where I have access control
                    foreach (var dir2 in Directory.EnumerateDirectories(dir1))
                    {
                        nrDirs++;

                        #region get third level directories
                        try
                        {
                            //Get third level directories, where I have access control
                            foreach (var dir3 in Directory.EnumerateDirectories(dir2))
                            {
                                nrDirs++;
                            }
                        }
                        catch
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
            return nrDirs;
        }

        static int CountDirectoriesRecursive(string myDirectory, int nr_levels)
        {
            //base case - no new directories - return 0
            if (nr_levels <= 0)
                return 0;

            //action case - found myDirectory
            int nrDirs = 1;

            //recursive case - add nr of recursively found directories
            try
            {
                foreach (var dir1 in Directory.EnumerateDirectories(myDirectory))
                {
                    nrDirs += CountDirectoriesRecursive(dir1, nr_levels - 1);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }

            //base case also when the above foreach loop has concluded
            return nrDirs;
        }


        static void Main(string[] args)
        {
            var startDirectory = @"C:\Users\marti";
            Console.WriteLine("FindDirectoriesIterative");
            var nrDirs = CountDirectoriesIterative(startDirectory);
            Console.WriteLine($"Found {nrDirs} directories");

            Console.WriteLine("\n\nFindDirectoriesRecursive");
            nrDirs = CountDirectoriesRecursive(startDirectory, 4);
            Console.WriteLine($"Found {nrDirs} directories");
        }
    }
}

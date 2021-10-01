using System;

namespace BOOPM3_07_03
{
    class Program
    {
        static double SafeDivision(double x, double y)
        {
            if ((x, y) == (0, 0))
                throw new DivideByZeroException("What a strange division");
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }
        static void Main(string[] args)
        {
            // Input for test purposes. Change the values to see
            // exception handling behavior.
            double a = 10, b = 0;
            double result;

            try
            {
                Console.WriteLine("Code in the try block");
                result = SafeDivision(a, b);
                Console.WriteLine($"{a} divided by {b} = {result}");
            }
            catch (DivideByZeroException ex) when (ex.Message == "What a strange division")
            {
                Console.WriteLine("Attempted divide by zero.");
                Console.WriteLine($"Message: {ex.Message}");
                //throw; // test rethrow same exception
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Attempted divide by zero.");
            }
            finally
            {
                Console.WriteLine("Code here will always be executed");
            }
        }

        //Exercises:
        //1.    run the code with a=0 and test the exception filter
        //2.    in the exception filter rethrow the exception. What happend to code in the finally clause?
        //3.    Explore the exception object properties such as StackTrace, Message and InnerException
    }
}

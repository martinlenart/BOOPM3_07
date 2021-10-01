﻿using System;

namespace BOOPM3_07_04
{
    class Program
    {
        public class MyOwnException : Exception
        {
            public MyOwnException() { }
            public MyOwnException(string message) : base(message) { }
            public MyOwnException(string message, Exception inner) : base(message, inner) { }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //Exercises:
    //1.    In BOOPM3_07_03 make a custom exception for a 0 by 0 division and handle it
}

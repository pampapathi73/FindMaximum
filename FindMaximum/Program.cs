using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum number");
            int max = FindMaximumFromThree.MaximumIntegerNumber(4, 7, 6);
            Console.WriteLine("The maximum value is :" + max);
        }
    }
}

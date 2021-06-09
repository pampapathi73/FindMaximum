using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum number");
            int max = FindMaximumFromThree.MaximumIntegerNumber(7, 4, 3);
            Console.WriteLine("The maximum value is :" + max);
        }
    }
}

using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Find maximum number");
            int max = FindMaximumFromThree.MaximumIntegerNumber(4, 6, 4);
            Console.WriteLine("The maximum value is :" + max);
            double maxFloat = FindMaximumFromThree.MaximumFloatNumber(4.4, 4.9, 5.2);
            Console.WriteLine("The maximum value is :" + maxFloat);
            string maxString = FindMaximumFromThree.MaximumStringNumber("Apple", "Peach", "Banana");
            Console.WriteLine("The maximum String value is :" + maxString);
        }
    }
}

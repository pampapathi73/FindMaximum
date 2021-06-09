using System;

namespace FindMaximum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 3, 5, 6 };
            GenericMaximum1<int> genericMaximum = new GenericMaximum1<int>(intArray);
            genericMaximum.FindMaximum();
            double[] doubleArray = { 4.5, 7.2, 9.7 };
            GenericMaximum1<double> genericDouble = new GenericMaximum1<double>(doubleArray);
            genericDouble.FindMaximum();
            string[] stringArray = { "Apple", "Peach", "Banana" }; 
            GenericMaximum1<string> genericString = new GenericMaximum1<string>(stringArray);
            genericString.FindMaximum();
        }
    }
}

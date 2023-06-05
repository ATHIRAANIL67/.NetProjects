using System;
namespace Generics
{
    class Printer
    {
        public static void PrintArray<T>(T[] array)
        {
            foreach (T element in array)
            {
                Console.WriteLine(element);
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3 };
            string[] stringArray = { "Hello", "World" };

            Printer.PrintArray(intArray);
            Printer.PrintArray(stringArray);
        }
    }
}
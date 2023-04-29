using System;
namespace PQ5Swap
{
    public class Swap
    {
        public static int[] get(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            return new int[] { a, b };
        }
        public static void Main()
        {
            int a, b;
            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());
            int[] swapped = get(a, b);
            Console.WriteLine("After Swapping");
            Console.WriteLine(swapped[0] + " " + swapped[1]);
        }
    }
}


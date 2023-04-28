using System;

namespace PQ4CountSmallerElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            int count = countOfElements(arr, n, x);
            Console.WriteLine(count);

        }
        static int countOfElements(int[] arr, int n, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= x)
                    count++;
            }
            return count;
        }
    }
}

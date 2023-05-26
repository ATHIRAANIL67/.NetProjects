using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of the array:");
            size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array is");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}

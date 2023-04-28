using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ3MissingNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[10];
            int n = arr.Length;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum1 = 0;
            for(int i=0; i < n;i++)
            {
                sum1 += arr[i];
            }
            Console.WriteLine("Sum of elements in the given array: "+sum1);
            int sum2 = 0;
            for( int i=1; i <=5; i++)
            {
                sum2 += i;
            }
            Console.WriteLine("Sum of range of elements: "+sum2);
            Console.WriteLine("Missing Number: "+(sum2-sum1));
        }
    }
}

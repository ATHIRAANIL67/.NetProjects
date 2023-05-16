using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 8, 7 };
            int n= arr.Length;
            int sum = 0;
            /*for(int i=n-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }*/
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
        }
    }
}

//Write a Code Block to compute the sum of the two given integer values.
//If the two values are the same, then return triple their sum.

using System;

namespace SumInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, sum;
            Console.WriteLine("Input a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input b: ");
            b = int.Parse(Console.ReadLine());
            sum = CalcSum(a, b);
            Console.WriteLine("Sum is: {0}", sum);

        }
        static int CalcSum(int aa, int bb)
        {
            if (aa == bb)
            {
                return 3 * (aa + bb);
            }
            else
            {
                return aa + bb;
            }
        }
    }
}

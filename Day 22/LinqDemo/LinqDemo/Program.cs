using System;
using System.Linq;

namespace LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 3, 5, 6, 5, 8, 10, 2 };
            Array.Sort(ar);
            foreach (int i in ar)
                if (i % 2 == 0)
                    Console.Write(i + " ");
            Console.WriteLine();


            //linq
            var num = from i in ar
                      where i % 2 == 0
                      select i;
            foreach (int x in num)
                Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}

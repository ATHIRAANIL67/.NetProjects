using System;

namespace NaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0;
            Console.WriteLine("Enter n1:");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter n2:");
            n2 = int.Parse(Console.ReadLine());
            if (n1 < n2)
            {
                for (int i = n1; i <= n2; i++)
                {
                    Console.Write("{0}\t", i);
                }
            }
            else
                Console.WriteLine("{0} is greater than {1}", n1, n2);
            Console.WriteLine();
        }
    }
}

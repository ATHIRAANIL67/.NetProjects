using System;

namespace EvenNaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit=0;
            Console.WriteLine("Enter the limit: ");
            limit=int.Parse(Console.ReadLine());
            for(int i=1; i<limit; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0}\t", i);
            }

        }
    }
}

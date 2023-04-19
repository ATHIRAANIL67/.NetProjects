using System;
namespace AnonymousMethodDemo
{
    delegate void CountIt();
    class AnonMethDemo
    {
        static void Main()
        {
            CountIt count = delegate
            {
                for (int i = 0; i <= 10; i++)
                    Console.WriteLine(i); ;
            };
            count();
        }
    }
}

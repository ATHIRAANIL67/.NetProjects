using System;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long i = 123;
            Object o = i;
            //boxing and it is always implicit

            long x = (long) o;
            //unboxing requires Typecasting
            Console.WriteLine(x);
        }
    }
}

using System;
namespace Inheritance2
{ 
    internal class Program
    {
        public class Arithmetic
        {
            public int Add(int x, int y)
            {
                return x + y;
            }
        }
        public class Adder : Arithmetic
        { }
        static void Main(string[] args)
        {
            Adder adder = new Adder();
            int result = adder.Add(42, 13);
            Console.WriteLine("My superclass is:Arithmetic");
            Console.WriteLine("Sum is " + result);
        }
    }
}
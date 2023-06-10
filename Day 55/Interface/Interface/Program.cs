using System;
namespace Interface
{
    interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
    class MyCalculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator myCalculator = new MyCalculator();
            Console.WriteLine("I implemented: " + myCalculator.GetType().Name);
            int n = 6;
            Console.WriteLine(myCalculator.divisorSum(n));
        }
    }
}
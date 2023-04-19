using System;

namespace AnonymousDelegateCombo
{
    class Program
    {
        public delegate int AddIt(int a, int b);
        static void Main(string[] args)
        {
            int sum;
            AddIt add = delegate (int n, int m)
            {
                return m + n;
            };
            sum = add(10, 20);
            Console.WriteLine(sum);

        }
    }
}

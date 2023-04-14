using System;

namespace DectoBin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans;
            string res;

            Console.WriteLine("Input a number");
            ans = Console.ReadLine();

            int num = Convert.ToInt32(ans);
            res = "";
            while (num > 1)
            {
                int rem = num % 2;
                Console.WriteLine(rem);      //illustrate debugging
                res = Convert.ToString(rem) + res;
                num = num / 2;
            }
            res = Convert.ToString(num) + res;
            Console.WriteLine("Binary: {0}", res);
        }
    }
}

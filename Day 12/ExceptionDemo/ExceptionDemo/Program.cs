
using System;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10,i = 0;
            try
            {
                i = int.Parse(Console.ReadLine());
                k = k / i;
                System.Console.WriteLine("Hiiiii");
            }
            catch(Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}

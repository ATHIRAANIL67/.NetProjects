using System;

namespace MulTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter the number: ");
            num=int.Parse(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}",num,i,num*i);
            }
        }
    }
}

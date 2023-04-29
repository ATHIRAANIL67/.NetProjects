using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQ5Amstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, temp;
            n=int.Parse(Console.ReadLine());
            temp = n;
            int result=AmstrongNumber(temp);
            if(result == n)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static int AmstrongNumber(int temp1)
        {
            int d = 0;
            while (temp1 > 0)
            {
                int a = temp1 % 10;
                d = d + (a * a * a);
                temp1 = temp1 / 10;
            }
            return d;
        }
    }
}

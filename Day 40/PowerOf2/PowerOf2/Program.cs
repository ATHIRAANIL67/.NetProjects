using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number=int.Parse(Console.ReadLine());
            Inner.Private ip = new Inner.Private();
            ip.powerOf2(number);
            
        }
        public class Inner
        {
            public class Private
            {
                public void powerOf2(int num)
                {
                    int temp,flag=0;
                    temp = num;
                    if (num == 0)
                        Console.WriteLine("Enter a number greater than 2"); ;

                    while (num != 1)
                    {
                        if (num % 2 != 0)
                            flag = 1;
                        num = num / 2;
                    }
                    if (flag != 1)
                        Console.WriteLine("{0} is a power of 2", temp);
                    else
                        Console.WriteLine("{0} is not a power of 2", temp);
                }
            }
        }
    }
}

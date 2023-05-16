using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b = 0; int[] a = new int[5];
            try
            {
                int i = 10 / b;
                a[10] = 9;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero error");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of bounds");
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("Remaining program");
        }
    }
}

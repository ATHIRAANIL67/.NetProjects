using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseQuestionDay3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int N = 0;
            int S = 0;
            int sum = 0;
            Console.WriteLine("Enter N:");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter S:");
            S = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            for (int i = 0; i < N; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Array;");
            for (int i = 0; i < N; i++)
                Console.Write(a[i]);
            for (int i = 0; i < N; i++)
            {
                a[i] = a[i] + a[i + 1];
                if (a[i] == S)
                {
                    
                }
            }
        }
    }
}

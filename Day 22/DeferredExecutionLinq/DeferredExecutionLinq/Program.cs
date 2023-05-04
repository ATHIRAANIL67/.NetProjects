using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeferredExecutionLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Linq query is not executrd when it is framed
            it is executed only when it is iterated upon.*/
            int[] a = { 1, 5, 2, 15, 19, 30, 21, 6, 4 };
            var query=from n in a
                      where n%2==0
                      select n;
            foreach(var n in query)
                Console.Write(n + " ");
            Console.WriteLine();
            a[2] = 7; //Earlier a[2] = 2
            foreach (var n in query)
                Console.Write(n + " ");
            Console.WriteLine();
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr1 = new ArrayList()
            {
                1,"Bill","Gates",10000,
            };
            arr1.Add(2);
            arr1.Add("hi");
            //arr1.Remove(2);
            //arr1.RemoveAt(4);
            /*foreach (var i in arr1)
            {
                Console.WriteLine(i);
            }*/
            /*ArrayList range=arr1.GetRange(0, 3);
            foreach (var i in range)
            {
                Console.WriteLine(i);
            }*/
            foreach(var i  in arr1.GetRange(0,3))
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine(arr[3]);
        }
    }
}

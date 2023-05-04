using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try101LinqSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> ls = Products.GetAllProducts();
            foreach(Product p in ls)
            {
                Console.WriteLine(p);
            }
        }
    }
}

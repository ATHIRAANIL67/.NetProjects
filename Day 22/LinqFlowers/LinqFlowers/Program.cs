using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LinqFlowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lotus", "lily", "hibiscus", "daffodil" };
            Console.WriteLine("Flower names starting with 'd' ");
            var fQuery1 = from flower in flowers
                         where (flower.StartsWith("d"))
                         select flower;
            foreach (string f in fQuery1)
                Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("Flower names ending with 's' ");
            var fQuery2 = from flower in flowers
                         where (flower.EndsWith("s"))
                         where(flower.Length > 5)  //multiple where blocks can be created
                         select flower;
            foreach (string f in fQuery2)
                Console.WriteLine(f);
            Console.WriteLine();

            Console.WriteLine("Flower names with length > 5 and length < 7");
            var fQuery3 = from flower in flowers
                          let len = flower.Length //scope of len will be only inside the query
                          where(len>5 && len<7)
                          select flower;
            foreach (string f in fQuery3)
                Console.WriteLine(f);

        }
    }
}

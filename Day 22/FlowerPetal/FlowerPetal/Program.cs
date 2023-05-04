using System;
using System.Collections.Generic;
using System.Linq;
namespace FlowerPetal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Flower> FlowerList = new List<Flower>();
            FlowerList.Add(new Flower("dahlia", 5));
            FlowerList.Add(new Flower("lily", 7));
            FlowerList.Add(new Flower("lotus", 20));
            FlowerList.Add(new Flower("rose", 10));
            FlowerList.Add(new Flower("daffodil", 14));
            var Fquery = from Flower in FlowerList
                         orderby Flower.Petal
                         group Flower by Flower.Petal;
            foreach (var fwr in Fquery)
            {
                Console.WriteLine("Flowers with " + fwr.Key + " Petals:");
                foreach (var fwrPetal in fwr)
                {
                    Console.WriteLine(fwrPetal.Flowers);
                }
            }
        }
    }
}
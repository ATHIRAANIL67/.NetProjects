using System;
using System.Collections;

namespace DictDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add("Maharastra       ", "Mumbai");
            s.Add("Karnataka        ", "Banglore");
            s.Add("Kerala           ", "Trivandrum");
            s.Add("Tamilnadu        ", "Chennai");
            s.Add("Andhra Pradesh   ", "Hyderabad");
            Console.WriteLine("Elements in the SortedList: ");

            //Printing Only Keys
            foreach(var item in s.Keys)
                Console.WriteLine(item);
            Console.WriteLine();

            //Printing Only Values
            foreach (var item in s.Values)
                Console.WriteLine(item);
            Console.WriteLine();

            //Printing both key and value
            IDictionaryEnumerator e = s.GetEnumerator();
            while(e.MoveNext())
                Console.WriteLine(e.Key +"\t"+ e.Value);
        }
    }
}

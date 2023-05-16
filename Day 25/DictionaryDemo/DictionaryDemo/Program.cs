using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(1, "Athira");
            dic.Add(2, "Aleena");
            dic.Add(3, "Nabeela");
            foreach(KeyValuePair<int,string> kvp in dic)
            {
                Console.WriteLine("Key:{0} Value:{1} ",kvp.Key,kvp.Value);
            }
            Console.WriteLine();
            SortedDictionary<int,string> dic2 = new SortedDictionary<int,string>();
            dic2.Add(2, "ABC");
            dic2.Add(1, "DEF");
            dic2.Add(3, "GHI");
            Console.WriteLine("Key  Value");
            foreach (KeyValuePair<int,string> kvp in dic2)
            {
                Console.WriteLine(kvp.Key+"     "+kvp.Value);
            }
        }
    }
}

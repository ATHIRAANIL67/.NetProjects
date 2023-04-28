using System;
using System.Collections.Generic;


namespace SongGroupReq5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Song> ls = new List<Song>();
            Console.WriteLine("Enter number of songs");
            int n=int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] str=Console.ReadLine().Split(',');
                string name = str[0];
                string artist = str[1];
                string songType = str[2];
                DateTime dateDownloaded = DateTime.ParseExact(str[3], "dd-MM-yyyy", null);
                double rating = double.Parse(str[4]);
                int noOfDownloads = int.Parse(str[5]);
                
                Song s=new Song(name, artist, songType, dateDownloaded, rating, noOfDownloads);
                ls.Add(s);
            }
            SortedDictionary<string, int> sd = new SortedDictionary<string, int>();
            sd=Song.CalculateTypeCount(ls);
            Console.WriteLine("{0} {1,15}", "Song type", "Count");
            foreach(var item in sd)
            {
                Console.WriteLine("{0} {1,15}",item.Key,item.Value);
            }

        }
    }
}

using SongGroupReq4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq4
{
    internal class SongRepo
    {

        static List<Song> songs = new List<Song>
        {
            new Song("Shape of You","\t\tEdsheeran","Pop",4.8,10000,DateTime.Parse("12-01-2018")),
            new Song("Perfect", "\t\t\tEdsheeran","Pop",4.5,120500,DateTime.Parse("06-08-2017")),
            new Song("Something just like this","Coldplay","Melody",4.5,105421,DateTime.Parse("05-07-1997")),
            new Song("Mercy","\t\t\tShawn Mendes","Jazz",4.6,50000,DateTime.Parse("03-09-2016"))
        };
        public static List<Song> GetAllSongs()
        {
            return songs;
        }
    }
}

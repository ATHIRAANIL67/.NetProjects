using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupReq3
{
    internal class SongRepo
    {

        static List<Song> songs = new List<Song>
        {
            new Song("Shape of You","Edsheeran","Pop",4.8,10000,DateTime.Parse("12-01-2018")),
            new Song("Perfect", "Edsheeran","Pop",4.5,120500,DateTime.Parse("06-08-2017")),
            new Song("Mercy","Shawn Mendes","Jazz",4.6,50000,DateTime.Parse("03-09-2016"))

        };
        public static List<Song> GetAllSongs()
        {
            return songs;
        }
        /*songs.Add(new Song() { Name = "",Artist = "",SongType = "",Rating = "",});*/
    }
}

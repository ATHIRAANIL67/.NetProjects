using System;
using System.Collections.Generic;

namespace SongGroupReq4
{
    public class PopularityComparer : IComparer<Song>
    {
        int IComparer<Song>.Compare(Song x, Song y)
        {
            return y.NumberOfDownloads.CompareTo(x.NumberOfDownloads);
        }
    }
}

using System;
using System.Collections.Generic;

namespace SongGroupReq4
{
    public class RatingComparer: IComparer<Song>
    {
        int IComparer<Song>.Compare(Song x, Song y)
        {
            return y.Rating.CompareTo(x.Rating);
        }
    }
}

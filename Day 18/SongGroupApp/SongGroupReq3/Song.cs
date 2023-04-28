using System;

namespace SongGroupReq3
{
    class Song: IComparable<Song>
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }

        private string _songType;
        public string SongType
        {
            get
            {
                return _songType;
            }
            set { _songType = value; }
        }

        private double _rating;
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                _rating = value;
            }
        }

        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get
            {
                return _numberOfDownloads;
            }
            set
            {
                _numberOfDownloads = value;
            }
        }

        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get
            {
                return _dateDownloaded;
            }
            set
            {
                _dateDownloaded = value;
            }
        }
        public Song() { }
        public Song(string name,string artist,string songType,double rating,int numberOfDownloads,DateTime dateDownloaded)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
        }
        public override string ToString()
        {
            /*return string.Format( "Name:\n{0}\tArtist:\n{1}\tSongType:\n{2}\tRating:\n{3}" +
            "\tNumberOfDownLoads:\n{4}\tDateDownLoaded:\n{5}",_name,_artist,_songType,
            _rating.ToString("0.0"),_numberOfDownloads,_dateDownloaded);*/
            return string.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}", _name, _artist, _songType,
            _rating.ToString("0.0"), _numberOfDownloads, _dateDownloaded);

        }
        //this CompareTo method is for sorting of songs list in order of names
        //Default Comparer
        public int CompareTo(Song other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}

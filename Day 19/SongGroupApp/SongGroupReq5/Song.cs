using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SongGroupReq5
{
    class Song
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

        public int NoOfDownloads { get; }

        public Song() { }
        public Song(string name, string artist, string songType,  DateTime dateDownloaded , double rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
        }


        /*        public override string ToString()
       {
           return string.Format("{0}\t{1}\t{2}\t{3}\t\t{4}\t{5}", _name, _artist, _songType,
           _rating.ToString("0.0"), _numberOfDownloads, _dateDownloaded.ToString("dd-MM-yyyy"));

       }
       //this CompareTo method is for sorting of songs list in order of names
       //Default Comparer
       public int CompareTo(Song other)
       {
           return this.Name.CompareTo(other.Name);
       }*/
        public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary <string,int> sd1=new SortedDictionary<string,int>();
            foreach(var item in list)
            {
                if (sd1.ContainsKey(item.SongType))
                    sd1[item.SongType]++;
                else
                    sd1.Add(item.SongType, 1);
          
            }
            return sd1;
        }
    }
}

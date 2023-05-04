using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLinqQueries
{
    internal class Standard
    {
        private int _standardID;

        public int StandardID
        {
            get { return _standardID; }
            set { _standardID = value; }
        }
        private string _standardName;

        public string StandardName
        {
            get { return _standardName; }
            set { _standardName = value; }
        }
        public Standard() { }
        public Standard(int _standardID, string _standardName)
        {
            _standardID = StandardID; 
            _standardName=StandardName;
        }
        public static List<Standard> GetStandard()
        {
            IList<Standard> standardList = new List<Standard>() {
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };
            return (List<Standard>)standardList;
        }
    }
}

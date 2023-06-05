using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeChlng2
{
    internal class Player
    {
        public string Name { get; }
        public int Score { get; }

        public Player(string name, int score)
        {
            Name = name;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} {Score}";
        }
    }

    class Checker : IComparer<Player>
    {
        public int Compare(Player a, Player b)
        {
            if (a.Score != b.Score)
            {
                // Sort in decreasing order of score
                return b.Score.CompareTo(a.Score);
            }
            else
            {
                // Sort alphabetically by name if scores are equal
                return a.Name.CompareTo(b.Name);
            }
        }
    }
}

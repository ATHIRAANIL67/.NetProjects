using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChlng2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Player[] players = new Player[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int score = int.Parse(input[1]);
                players[i] = new Player(name, score);
            }

            Array.Sort(players, new Checker());

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }

}

using System;

namespace VotingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            Console.WriteLine("Enter your age: ");
            age=int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("You are eligible for voting!");
            }
            else
            {
                Console.WriteLine("You are not eligible for voting");
            }
        }
    }
}

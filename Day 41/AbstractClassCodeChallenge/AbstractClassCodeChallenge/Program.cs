using System;
namespace AbstractClassCodeChallenge
{
    public abstract class Book
    {
        protected string title;
        public abstract void SetTitle(string s);
        public string GetTitle()
        {
            return title;
        }
    }
    public class MyBook : Book
    {
        public override void SetTitle(string s)
        {
            title = s;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            MyBook b = new MyBook();
            b.SetTitle("A tale of two cities");
            Console.WriteLine("The title is: " + b.GetTitle());
        }
    }
}










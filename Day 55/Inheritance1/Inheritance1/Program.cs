using System;
namespace Inheritance1
{
    internal class Program
    {
        public class Animal
        {
            public void walk()
            {
                Console.WriteLine("I am walking");
            }
        }
        public class Bird : Animal
        {
            public void fly()
            {
                Console.WriteLine("I am flying");
            }
            public void Sing()
            {
                Console.WriteLine("I am singing");
            }
        }
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.walk();
            bird.fly();
            bird.Sing();
        }
    }
}
using System;

namespace NameSpaceDemo
{
    class Demo1
    {
        public static void display()
        {
            System.Console.WriteLine("Helloooooooooo");

        }
    }
}

class Demo2
{

    public static void Main(String[] args)
    {
        NameSpaceDemo.Demo1.display();

    }
}


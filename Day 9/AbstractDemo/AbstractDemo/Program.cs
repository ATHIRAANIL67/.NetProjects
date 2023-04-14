using System;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure fig1= new Square();
            fig1.Dimension = 10;
            Console.WriteLine("----Square----");
            Console.WriteLine(fig1.Area());
            Console.WriteLine(fig1.Perimeter());

            Figure fig2 = new Circle();
            fig2.Dimension = 5;
            Console.WriteLine("----Circle----");
            Console.WriteLine(fig2.Area());
            Console.WriteLine(fig2.Perimeter());
        }
    }
}

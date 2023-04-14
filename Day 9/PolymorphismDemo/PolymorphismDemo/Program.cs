using System;

namespace PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.DrawShape();                //Shape
            Circle c1 = new Circle();
            c1.DrawShape();                //Circle

            Rectangle r1 = new Rectangle();
            r1.DrawShape();               //Rectangle
            Shape s2 = new Circle();      //UPCASTING
            s2.DrawShape();               //Circle

            Shape s3 = new Rectangle();
            s3.DrawShape();               //rectangle


            //Array of references of base class referencing Derived class object(UPCASTING).

            Shape[] p =
            {
                new Circle(),
                new Rectangle(),
                new Circle(),
                new Rectangle(),
                new Circle(),
            };
            for (int i = 0; i < p.Length; i++) 
            { 
                p[i].DrawShape(); 
            }

            Shape t = null;
            Console.WriteLine("Enter Shape: ");
            string shape=Console.ReadLine();
            if (shape.ToLower() == "circle")      //ToLower : case insensitive
                t = new Circle();
            else if (shape.ToLower() == "rectangle")
                t = new Rectangle();
            t.DrawShape();
        }
    }
}

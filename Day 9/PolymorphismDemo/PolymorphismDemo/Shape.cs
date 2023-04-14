using System;

namespace PolymorphismDemo
{
    public class Shape
    {
        public virtual void DrawShape()           //function which you want to take as an execution
        {
            Console.WriteLine("Drawing Shape");
        }
    }
    public class Circle : Shape
    {
        public override void DrawShape()         //function which you want to take as an action
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void DrawShape()         //function which you want to take as an action
        {
            Console.WriteLine("Drawing Rectangle");
        }
    }
}

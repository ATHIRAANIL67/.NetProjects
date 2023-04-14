//Program to calculate the Area of Circle
using System;

namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0, area;
            Console.WriteLine("Enter the Radius:");
            r = double.Parse(Console.ReadLine());
            area = CalcArea(r);
            Console.WriteLine("Area of Circle having radius {0} is {1}", r, area);
            //HELOOOOO
            //HOW ARE YOU
        }

        static double CalcArea(double rr)
        {
            double area = 0.0;
            area = 3.14 * rr * rr;
            return area;
        }
    }
}

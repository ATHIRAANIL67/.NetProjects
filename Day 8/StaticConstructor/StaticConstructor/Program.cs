using System;
namespace StaticDemo
{
    class sample
    {
        public static int y;
        public static int m;
        public static int d;
        static sample()
        {
            DateTime dt;
            dt = DateTime.Now;
            y = dt.Year;
            m = dt.Month;
            d = dt.Day;
        }
        public static void showdate()
        {
            Console.WriteLine("Year:" + y);
            Console.WriteLine("Month:" + m);
            Console.WriteLine("Day:" + d);
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            sample.showdate();
        }
    }
}

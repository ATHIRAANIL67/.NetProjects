using System;

namespace DateTimeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            Console.WriteLine(DateTime.Now.DayOfYear);
            DateTime dt1 = new DateTime(2023, 4, 21,5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.DayOfYear);
            Console.WriteLine(dt1.Year);
            Console.WriteLine(dt1.Month);
            Console.WriteLine(dt1.Day);
            Console.WriteLine(dt1.Hour);
            Console.WriteLine(dt1.Minute);
            Console.WriteLine(dt1.Second);
            Console.WriteLine(dt1.Millisecond);
            Console.WriteLine(dt1.ToLongDateString());

            DateTime dt2 = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);
            DateTime newDate = dt2.Add(ts);
            Console.WriteLine(newDate);//1/1/2016 1:20:55 AM


        }
    }
}

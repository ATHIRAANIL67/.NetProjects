//Write a C# Sharp program that takes distance and time as input and displays the speed in 
//kilometres per hour and miles per hour.

using System;

namespace SpeedPgm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dist = 0.0, time = 0.0, speedKm,speedMiles;
            Console.WriteLine("Input Distance: ");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("Input Time: ");
            time = double.Parse(Console.ReadLine());
            speedKm = CalcSpeedKm(dist, time);
            Console.WriteLine("Speed in kilometres per hour is: {0}", speedKm);
            speedMiles = CalcSpeedMiles(dist, time);
            Console.WriteLine("Speed in miles per hour is: {0}", speedMiles);

        }
        static double CalcSpeedKm(double dist1, double time1)
        {
            return dist1 / time1;
            
        }
        static double CalcSpeedMiles(double dist2, double time2)
        {
            return (dist2 / time2) * 0.6213711922;
        }
    }
}

//Write a program to enter an amount and find out minimum number of notes required to make that amount.
//1  2  5  10  20  50  100  200  500  2000

using System;

namespace AmountNotes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amt = 0,q,rem;
            Console.WriteLine("Enter an amount");
            amt=int.Parse(Console.ReadLine());
            q = amt / 2000;
            amt = amt % 2000;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.2000", q);

            q = amt / 500;
            amt = amt % 500;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.500", q);

            q = amt / 200;
            amt = amt % 200;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.200", q);

            q = amt / 100;
            amt = amt % 100;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.100", q);

            q = amt / 50;
            amt = amt % 50;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.50", q);

            q = amt / 20;
            amt = amt % 20;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.20", q);

            q = amt / 10;
            amt = amt % 10;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.10", q);

            q = amt / 5;
            amt = amt % 5;
            Console.WriteLine("{0}\t\t{1}", q, amt);
            Console.WriteLine("{0} * Rs.5", q);
        }
    }
}

using System;
namespace RatioNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int pCount = 0;
            int nCount = 0;
            int zCount = 0;
            foreach (int num in arr)
            {
                if (num > 0)
                    pCount++;
                else if (num < 0)
                    nCount++;
                else
                    zCount++;
            }
            double pRatio = (double)pCount / n;
            double nRatio = (double)nCount / n;
            double zRatio = (double)zCount / n;
            Console.WriteLine(pRatio.ToString("F6"));
            Console.WriteLine(nRatio.ToString("F6"));
            Console.WriteLine(zRatio.ToString("F6"));
        }
    }
}
using System;
namespace PQ4isBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = null;
            str = Console.ReadLine();
            int value = isBinary(str);
            if (value == 1)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
        public static int isBinary(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '0' && str[i] != '1')
                {
                    return 0;
                }
            }
            return 1;
        }
    }
}

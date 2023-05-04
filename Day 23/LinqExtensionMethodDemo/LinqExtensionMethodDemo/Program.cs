using System;
namespace LinqExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "India is great!";
            int wc = s.GetWordCount();  //when we type s. then GetWordCount() will be automatically available
            Console.WriteLine("Count: "+wc);
            Console.WriteLine(s.mUpper());
        }
    }
    public static class MyFun
    {
        public static int GetWordCount(this string str)  //this is written
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
        public static string mUpper(this string str)
        {
            return str.ToUpper();
        }
    }
}


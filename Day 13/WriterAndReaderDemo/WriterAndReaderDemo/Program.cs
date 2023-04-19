using System;
using System.IO;
using System.Text;

namespace WriterAndReaderDemo
{
    class WriterAndReader
    {
        static string file = @"D:\.NetUST\Day 13\poem.txt";
        static void Main(string[] args)
        {
            Write();
            Read();
        }
        static void Write()
        {
            StreamWriter fileStream = new StreamWriter(file);
            fileStream.WriteLine("Blaaa Blaaaa Blaaaaa!!!!");
            fileStream.WriteLine("Again blaaa blaaa");
            fileStream.Close();
        }

        static void Read()
        {
            StreamReader fileStream= new StreamReader(file);
            string s = null;
            while ((s = fileStream.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            fileStream.Close();
        }

    }
}

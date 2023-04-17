using System;

namespace IndexerDemo
{
    public class array
    {
        float[] arr = new float[] { 12.5f, 34.3f, 5.2f, 6.1f, 7.5f, 88.8f, 22.9f };
        public float this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            array a;
            a = new array();
            a[3] = 43.2f;
            Console.WriteLine(a[3]);
        }
    }
}

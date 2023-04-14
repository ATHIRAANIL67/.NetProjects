//Sorting a string in ascending order
using System;
public class StringSort
{
    public static void Main()
    {
        string str;
        char[] arr;
        char ch;
        int i, j, l;
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        l = str.Length;
        arr = str.ToCharArray(0, l);

        for (i = 1; i < l; i++)
            for (j = 0; j < l - i; j++)

                if (arr[j] > arr[j + 1])
                {
                    ch = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = ch;
                }
        Console.Write("After sorting: \n");
        foreach (char c in arr)
        {
            ch = c;
            Console.Write("{0} ", ch);
        }
        Console.WriteLine("\n");
    }
}
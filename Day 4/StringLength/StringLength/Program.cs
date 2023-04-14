//length of a string
/*using System;
public class StringLength
{
    public static void Main()
    {
        string str;
        int c = 0;
        System.Console.WriteLine("Enter the string");
        str = Console.ReadLine();
        Console.Write("The string you entered is : {0}\n", str);
        for (int i = 0; i < str.Length; i++)
        {
            c++;
        }
        Console.WriteLine(c);
    }
}


using System;
public class StringLength
{
    public static void Main()
    {
        string str;
        int c = 0;
        System.Console.WriteLine("Enter the string");
        str = Console.ReadLine();
        Console.Write("The string you entered is : {0}\n", str);
        for (int i = 0; i <= str.Length - 1; i++)
        {
            Console.Write(" {0} ", str[i]);
        }
    }
}

using System;
public class StringLength
{
    public static void Main()
    {
        string str;
        int alp = 0;
        int dig = 0;
        int spl = 0;
        System.Console.WriteLine("Enter the string");
        str = Console.ReadLine();
        Console.Write("The string you entered is : {0}\n", str);
        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z'))
            {
                alp++;
            }
            else if (str[i] >= '0' && str[i] <= '9')
            {
                dig++;
            }
            else
            {
                spl++;
            }
        }
        Console.WriteLine("{0}{1}{2}", alp, dig, spl);
    }
}*/

using System;
public class Array
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int temp=0;
        Console.WriteLine("Enter array");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Before sorting: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        for(int i=0;i<arr.Length; i++)
        {
            for(int j = 0; j < arr.Length-i-1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    temp = arr[j+1];
                    arr[j+1] = arr[j];
                    arr[j] = temp;

                }
            }
        }
        Console.WriteLine("\n\nAfter sorting: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
    }
}


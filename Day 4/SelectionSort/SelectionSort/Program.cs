using System;
public class Array
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];
        int temp = 0;
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
        for (int j = 0; j < arr.Length; j++)
        {
            for (int i = j; i < arr.Length - 1; i++)
            {
                if (arr[j] > arr[i + 1])
                {
                    temp = arr[j];
                    arr[j] = arr[i+1];
                    arr[i+1] = temp;

                }
            }
            Console.WriteLine("\n\nIteration{0}: ", j);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
        Console.WriteLine("\n\nAfter sorting: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.Write("\n");
    }
}
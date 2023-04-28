using System;
public class Program
{
    public static void Sort012(int[] arr, int n)
    {
        int low = 0, mid = 0, high = n - 1;
        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                Swap(arr, low, mid);
                low++;
                mid++;
            }
            else if (arr[mid] == 1)
            {
                mid++;
            }
            else if (arr[mid] == 2)
            {
                Swap(arr, mid, high);
                high--;
            }
        }
    }
    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    public static void Main()
    {
        int[] arr=new int[10];
        int n = arr.Length;
        n=int.Parse(Console.ReadLine());
        for(int i = 0;i< n;i++)
            arr[i] = int.Parse(Console.ReadLine());
        Sort012(arr, n);
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}
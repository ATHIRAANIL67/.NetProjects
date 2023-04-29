using System;
namespace PQ4PalindromicArray
{
    class Solution
    {
        public int PalinArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int num = arr[i];
                int reversed = 0;
                int original = num;
                // reverse the number
                while (num > 0)
                {
                    int digit = num % 10;
                    reversed = reversed * 10 + digit;
                    num /= 10;
                }
                // check if the reversed number is equal to the original number
                if (original != reversed)
                {
                    return 0;
                }
            }
            // all elements are palindromes
            return 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Solution s = new Solution();
            Console.WriteLine(s.PalinArray(arr, n)); // Output: 1
        }
    }
}
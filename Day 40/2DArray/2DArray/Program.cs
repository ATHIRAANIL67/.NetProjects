﻿using System;
public class Solution
{
    public static int HourglassSum(int[][] arr)
    {
        int maxSum = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                     arr[i + 1][j + 1] +
                     arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                maxSum = Math.Max(maxSum, sum);
            }
        }
        return maxSum;
    }
    public static void Main(string[] args)
    {
        int[][] arr = new int[6][];
        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }
        int result = HourglassSum(arr);
        Console.WriteLine(result);
    }
}














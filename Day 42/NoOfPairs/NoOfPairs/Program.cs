using System;

using System.Collections.Generic;
using System.Linq;

class Result

{

    /*

     * Complete the 'solve' function below.

     *

     * The function is expected to return a LONG_INTEGER.

     * The function accepts INTEGER_ARRAY arr as parameter.

     */

    public static long solve(List<int> arr)

    {

        Dictionary<int, int> countMap = new Dictionary<int, int>();

        long pairsCount = 0;

        // Count the occurrences of each number in the array

        foreach (int num in arr)

        {

            if (countMap.ContainsKey(num))

                countMap[num]++;

            else

                countMap[num] = 1;

        }

        // Calculate the pairs count

        foreach (var kvp in countMap)

        {

            int count = kvp.Value;

            pairsCount += count * (count - 1) / 2;

        }

        return pairsCount;

    }

}

class Solution

{

    public static void Main(string[] args)

    {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        long result = Result.solve(arr);

        Console.WriteLine(result);

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
   class AnagramChecker
    {
        static bool AreAnagrams(string str1, string str2)
        {
            // Convert both strings to lowercase
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            // Create dictionaries to store character frequencies
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();
            // Count character frequencies in the first string
            foreach (char c in str1)
            {
                if (char.IsLetter(c))
                {
                    if (dict1.ContainsKey(c))
                        dict1[c]++;
                    else
                        dict1[c] = 1;
                }
            }
            // Count character frequencies in the second string
            foreach (char c in str2)
            {
                if (char.IsLetter(c))
                {
                    if (dict2.ContainsKey(c))
                        dict2[c]++;
                    else
                        dict2[c] = 1;
                }
            }
            // Compare the character frequencies
            if (dict1.Count != dict2.Count)
                return false;
            foreach (char key in dict1.Keys)
            {
                if (!dict2.ContainsKey(key) || dict1[key] != dict2[key])
                    return false;
            }
            return true;
        }
        static void Main()
        {
            // Read the input strings
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            // Check if the strings are anagrams
            if (AreAnagrams(str1, str2))
                Console.WriteLine("Anagrams");
            else
                Console.WriteLine("Not Anagrams");
        }
   }
}

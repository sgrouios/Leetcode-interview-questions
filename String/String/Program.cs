using System;
using System.Collections.Generic;
using System.Linq;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nonRepeat = "loveleetcode";
            //int index = FirstUniqueChar(nonRepeat);
            //Console.WriteLine(nonRepeat[index]);

            //IsAnagram
            //Console.WriteLine(IsAnagram("anagram", "nagaram"));

            //IsPalindrome
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }

        private static char[] ReverseString(char[] s)
        {
            int a_pointer = 0;
            int b_pointer = s.Length - 1;
            while(a_pointer <= b_pointer)
            {
                char temp = s[a_pointer];
                s[a_pointer] = s[b_pointer];
                s[b_pointer] = temp;
                
                a_pointer++;
                b_pointer--;
            }
            return s;
        }

        private static int Reverse(int x)
        {
            long result = 0;
            while(x != 0)
            {
                result = result * 10 + x % 10;
                if(result > int.MaxValue || result < int.MinValue)
                {
                    return 0;
                }
                x /= 10;
            }
            return (int)result;
        }

        private static int FirstUniqueChar(string s)
        {
            Dictionary<char, int> charIndex = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (charIndex.ContainsKey(s[i]))
                {
                    charIndex[s[i]]++;
                }
                else
                {
                    charIndex.Add(s[i], 1);
                }
            }
            for(int i = 0; i < s.Length; i++)
            {
                var count = 0;
                charIndex.TryGetValue(s[i], out count);
                if (count == 1)
                    return i;
            }
            return -1;
        }

        private static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            int[] charCount = new int[26];
            for(int i = 0; i < s.Length; i++)
            {
                //subtract 97 from char ASCII value to find position in array
                charCount[s[i] - 97]++;
                charCount[t[i] - 97]--;
            }
            foreach (int i in charCount)
            {
                if (i != 0)
                    return false;
            }
            return true;
        }

        private static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while (i < j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                if (i < j && char.ToLower(s[i++]) != char.ToLower(s[j--]))
                    return false;
            }
            return true;
        }
    }
}

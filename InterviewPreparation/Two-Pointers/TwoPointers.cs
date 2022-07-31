using System.Collections.Generic;

namespace DataStructures.Two_Pointers
{
    public class TwoPointers
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length < 2)
            {
                return s.Length;
            }

            var left = 0;
            var right = 0;
            var longestSub = 0;

            var seenLetters = new HashSet<char>();

            while (right < s.Length) {
                if(!seenLetters.Contains(s[right]))
                {
                    seenLetters.Add(s[right]);

                    if (seenLetters.Count > longestSub)
                    {
                        longestSub = seenLetters.Count;
                    }
                } 
                else {
                    //Find location of duplicate before current index
                    var current = right-1;
                    while (s[current] != s[right])
                    {
                        current--;
                    }

                    seenLetters.Clear();

                    left = current+1;
                    right = left;
                    seenLetters.Add(s[left]);
                }

                right++;
            }

            return longestSub;
        }
    }
}

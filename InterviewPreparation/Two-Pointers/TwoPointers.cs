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

            while (right < s.Length)
            {
                if(!seenLetters.Contains(s[right]))
                {
                    seenLetters.Add(s[right]);

                    if (seenLetters.Count > longestSub)
                    {
                        longestSub = seenLetters.Count;
                    }
                } else {
                    //if (seenLetters.Count > longestSub)
                    //{
                    //    longestSub = seenLetters.Count;
                    //}

                    seenLetters.Clear();

                    left = right;
                    seenLetters.Add(s[right]);
                }

                right++;
            }

            return longestSub;
        }
    }
}

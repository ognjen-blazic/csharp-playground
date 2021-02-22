using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /*
            Given a string s, find the length of the longest substring without repeating characters.

            Example 1:

            Input: s = "abcabcbb"
            Output: 3
            Explanation: The answer is "abc", with the length of 3.

            Example 2:

            Input: s = "bbbbb"
            Output: 1
            Explanation: The answer is "b", with the length of 1.

            Example 3:

            Input: s = "pwwkew"
            Output: 3
            Explanation: The answer is "wke", with the length of 3.
            Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.

            Example 4:

            Input: s = ""
            Output: 0
 

            Constraints:

            0 <= s.length <= 5 * 104
            s consists of English letters, digits, symbols and spaces.
         */
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;

            var substring = new HashSet<char>();
            var max = 0;

            for(var i = 0; i < s.Length; i++)
            {
                var present = substring.Add(s[i]);

                if (!present)
                {
                    max = Math.Max(max, substring.Count);
                    substring.Clear();
                    substring.Add(s[i]);
                }
            }

            return Math.Max(max, substring.Count);
        }
    }
}

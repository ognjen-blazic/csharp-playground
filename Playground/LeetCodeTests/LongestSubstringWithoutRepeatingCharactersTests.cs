using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class LongestSubstringWithoutRepeatingCharactersTests
    {
        private LongestSubstringWithoutRepeatingCharacters subject = new LongestSubstringWithoutRepeatingCharacters();

        [Test]
        public void Example1Test()
        {
            var actual = subject.LengthOfLongestSubstring("abcabcbb");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Example2Test()
        {
            var actual = subject.LengthOfLongestSubstring("bbbbb");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Example3Test()
        {
            var actual = subject.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Example4Test()
        {
            var actual = subject.LengthOfLongestSubstring("");
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Example5Test()
        {
            var actual = subject.LengthOfLongestSubstring("12345");
            Assert.AreEqual(5, actual);
        }
    }

}

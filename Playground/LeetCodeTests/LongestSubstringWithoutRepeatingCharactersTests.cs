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

        [Test]
        public void Example6Test()
        {
            var actual = subject.LengthOfLongestSubstring("dvdf");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Example7Test()
        {
            var actual = subject.LengthOfLongestSubstring("123542183");
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Example8Test()
        {
            var actual = subject.LengthOfLongestSubstring("5 7 8 9 0");
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Example9Test()
        {
            var actual = subject.LengthOfLongestSubstring("11");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Example10Test()
        {
            var actual = subject.LengthOfLongestSubstring("111222333");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Example11Test()
        {
            var actual = subject.LengthOfLongestSubstring("!");
            Assert.AreEqual(1, actual);
        }

        [Test]
        public void Example12Test()
        {
            var actual = subject.LengthOfLongestSubstring("bababababababab");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Example13Test()
        {
            var actual = subject.LengthOfLongestSubstring("baba");
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void Example14Test()
        {
            var actual = subject.LengthOfLongestSubstring("1   3   5   67891  0 42 3");
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Example15Test()
        {
            var actual = subject.LengthOfLongestSubstring("1111   9@8$7!6 5(4_");
            Assert.AreEqual(12, actual);
        }
    }

}

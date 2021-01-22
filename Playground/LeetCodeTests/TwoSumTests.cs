using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class TwoSumTests
    {
        private TwoSum subject = new TwoSum();

        [Test]
        public void Example1Test()
        {
            var actual = subject.Result(new int[] { 2, 7, 11, 15 }, 9);
            Assert.AreEqual(new int[] { 0, 1 }, actual);
        }

        [Test]
        public void Example2Test()
        {
            var actual = subject.Result(new int[] { 3, 2, 4 }, 6);
            Assert.AreEqual(new int[] { 1, 2 }, actual);
        }

        [Test]
        public void Example3Test()
        {
            var actual = subject.Result(new int[] { 3, 3 }, 6);
            Assert.AreEqual(new int[] { 0, 1 }, actual);
        }
    }

}

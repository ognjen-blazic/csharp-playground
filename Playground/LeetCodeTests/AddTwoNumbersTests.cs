using LeetCode;
using NUnit.Framework;

namespace LeetCodeTests
{
    public class AddTwoNumbersTests
    {
        private AddTwoNumbers subject = new AddTwoNumbers();

        [Test]
        public void Example1Test()
        {
            var actual = subject.Result(new ListNode(), new ListNode());
            Assert.IsNull(actual);
        }
    }
}
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
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var actual = subject.Result(l1, l2);

            var expected = new ListNode(7);
            expected.next = new ListNode(0);
            expected.next.next = new ListNode(8);

            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next.val, actual.next.val);
            Assert.AreEqual(expected.next.next.val, actual.next.next.val);
            Assert.AreEqual(expected.next.next.next, actual.next.next.next);
        }

        [Test]
        public void Example2Test()
        {
            var l1 = new ListNode(0);
            var l2 = new ListNode(0);

            var actual = subject.Result(l1, l2);

            var expected = new ListNode(0);

            Assert.AreEqual(expected.val, actual.val);
            Assert.AreEqual(expected.next, actual.next);
        }

        [Test]
        public void Example3Test()
        {
            var l1 = new ListNode(9);
            l1.next = new ListNode(9);
            l1.next.next = new ListNode(9);
            l1.next.next.next = new ListNode(9);
            l1.next.next.next.next = new ListNode(9);
            l1.next.next.next.next.next = new ListNode(9);
            l1.next.next.next.next.next.next = new ListNode(9);

            var l2 = new ListNode(9);
            l2.next = new ListNode(9);
            l2.next.next = new ListNode(9);
            l2.next.next.next = new ListNode(9);

            var actual = subject.Result(l1, l2);

            var expected = new ListNode(8);
            expected.next = new ListNode(9);
            expected.next.next = new ListNode(9);
            expected.next.next.next = new ListNode(9);
            expected.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next.next = new ListNode(0);
            expected.next.next.next.next.next.next.next = new ListNode(1);

            Assert.AreEqual(8, actual.val);
            Assert.AreEqual(9, actual.next.val);
            Assert.AreEqual(9, actual.next.next.val);
            Assert.AreEqual(9, actual.next.next.next.val);
            Assert.AreEqual(0, actual.next.next.next.next.val);
            Assert.AreEqual(0, actual.next.next.next.next.next.val);
            Assert.AreEqual(0, actual.next.next.next.next.next.next.val);
            Assert.AreEqual(1, actual.next.next.next.next.next.next.next.val);
            Assert.AreEqual(null, actual.next.next.next.next.next.next.next.next);
        }
    }
}
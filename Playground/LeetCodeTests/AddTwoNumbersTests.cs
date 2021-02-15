using LeetCode;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTests
{
    public class AddTwoNumbersTests
    {
        private AddTwoNumbers subject = new AddTwoNumbers();

        [Test]
        public void Example1Test()
        {
            Test(342, 465);
        }

        [Test]
        public void Example2Test()
        {
            Test(0, 0);
        }

        [Test]
        public void Example3Test()
        {
            Test(9999999, 9999);
        }

        [Test]
        public void RandomTest()
        {
            Random r = new Random();
            int rInt1 = r.Next(0, short.MaxValue);
            int rInt2 = r.Next(0, short.MaxValue);

            Test(rInt1, rInt2);
        }

        private void Test(int first, int second)
        {
            var l1 = IntegerToLinkedListNode(first);
            var l2 = IntegerToLinkedListNode(second);

            var actual = subject.Result(l1, l2);

            Assert.AreEqual(first + second, LinkedListNodeToInteger(actual));
        }

        private ListNode IntegerToLinkedListNode(int number)
        {
            ListNode head = null;
            ListNode tail = null;

            var reverseStringNumber = number.ToString().Reverse().ToArray();

            for(var i = 0; i < reverseStringNumber.Length; i++)
            {
                var numberNode = new ListNode((int)char.GetNumericValue(reverseStringNumber[i]));
                if (i == 0)
                {
                    head = numberNode;
                    tail = head;
                    continue;
                }

                tail.next = numberNode;
                tail = tail.next;
            }

            return head;
        }

        private int LinkedListNodeToInteger(ListNode numberNode)
        {
            var numbers = new List<int>();

            while(numberNode != null)
            {
                numbers.Add(numberNode.val);
                numberNode = numberNode.next;
            }

            return int.Parse(string.Join("", numbers.ToArray().Reverse()));
        }
    }
}
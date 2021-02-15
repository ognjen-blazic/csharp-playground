using System;

namespace LeetCode
{
    // Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;

        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    // add number/enumerable to list method (and vice versa) for testing

    /*
        You are given two non-empty linked lists representing two non-negative integers. 
        The digits are stored in reverse order, and each of their nodes contains a single digit.
        Add the two numbers and return the sum as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        Example 1:

        Input: l1 = [2,4,3], l2 = [5,6,4]
        Output: [7,0,8]
        Explanation: 342 + 465 = 807.

        Example 2:

        Input: l1 = [0], l2 = [0]
        Output: [0]
        
        Example 3:

        Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        Output: [8,9,9,9,0,0,0,1]

        Constraints:

        The number of nodes in each linked list is in the range [1, 100].
        0 <= Node.val <= 9
        It is guaranteed that the list represents a number that does not have leading zeros.
    */
    public class AddTwoNumbers
    {
        public ListNode Result(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode tail = null;
            var first = true;
            var overflow = false;

            while (first || overflow || l1 != null || l2 != null)
            {
                var sumAndOverflow = Sum(l1, l2, overflow);
                var node = new ListNode(sumAndOverflow.Item1);
                overflow = sumAndOverflow.Item2;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;

                if (first)
                {
                    head = node;
                    tail = head;
                    first = false;
                    continue;
                }

                tail.next = node;
                tail = tail.next;
            }

            return head;
        }

        // sum, overflow
        private Tuple<int, bool> Sum(ListNode first, ListNode second, bool overflow)
        {
            var sum = 0;
            if (overflow) sum += 1;
            if (first != null) sum += first.val;
            if (second != null) sum += second.val;

            var overhead = sum - 10;
            overflow = overhead >= 0;

            return new Tuple<int, bool>(overflow ? overhead : sum, overflow);
        }
    }
}

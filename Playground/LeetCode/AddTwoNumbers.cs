﻿using System;
using System.Collections.Generic;
using System.Text;

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
            var sumOverflow = Sum(l1, l2, false);
            var head = new ListNode(sumOverflow.Item1);
            var overflow = sumOverflow.Item2;

            var tail = head;
            var first = l1.next;
            var second = l2.next;

            
            while (overflow || first != null || second != null)
            {
                sumOverflow = Sum(first, second, sumOverflow.Item2);
                var node = new ListNode(sumOverflow.Item1);
                overflow = sumOverflow.Item2;

                tail.next = node;
                tail = tail.next;

                if (first != null)
                {
                    first = first.next;
                }

                if (second != null)
                {
                    second = second.next;
                }
            }

            return head;
        }

        // sum, overflow
        private Tuple<int, bool> Sum(ListNode first, ListNode second, bool overflow)
        {
            var sum = 0;
            if (overflow)
            {
                sum += 1;
            }

            if(first != null)
            {
                sum += first.val;
            }

            if (second != null)
            {
                sum += second.val;
            }

            overflow = sum - 10 >= 0;

            return new Tuple<int, bool>(overflow ? sum - 10 : sum, overflow);
        }
    }
}

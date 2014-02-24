﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ConsoleApplication1
{
    class MyNode
    {
        public int data;
        public MyNode next;
        public MyNode() { }
        public MyNode(int value)
        {
            data = value;
        }


    }

    class MyList
    {
        public MyList() { }
        public MyNode head;
        public int this[int index]
        {
            get
            {
                int[] arrResult = TravelList();
                return arrResult[index];


            }
            set
            {
                MyNode temp = head;
                int i = 0;
                while (temp.next != null)
                {
                    if (i == index)
                    {
                        break;
                    }
                    else
                    {
                        temp = temp.next;
                        i++;

                    }
                    if (i == index)
                    {
                        temp.data = value;
                    }
                }

            }

        }
        #region 2.1
        //Write code to remove duplicates from an unsorted linked list.
        //FOLLOW UP
        //How would you solve this problem if a temporary buffer is not allowed?
        public void RemoveDuplicate()
        {
            Hashtable table = new Hashtable();
            MyNode previous = null;
            if (head != null)
            {
                MyNode node = head;
                while (node != null)
                {
                    if (table.Contains(node.data))
                    {
                        previous.next = node.next;
                    }
                    else
                    {
                        table.Add(node.data, true);
                        previous = node;
                    }
                    node = node.next;
                }
            }
        }

        public void RemoveDuplicateWithoutBuffer()
        {

            MyNode current = head;

            while (current != null)
            {
                MyNode runner = current;
                while (runner.next != null)
                {
                    if (runner.data == current.next.data)
                    {
                        runner.next = runner.next.next;
                    }
                    else
                    {

                        runner = runner.next;
                    }
                }

                current = current.next;
            }

        }



        #endregion
        #region 2.2

        //Implement an algorithm to find the kth to last element of a singly linked list.
        public int FindKth(int k)
        {
            MyNode node = head;
            int value = 0;
            FindKthNode(node, k, ref value);
            return value;

        }
        private int FindKthNode(MyNode head, int k, ref int value)
        {

            if (head == null)
            {
                return 0;
            }

            int n = FindKthNode(head.next, k, ref value) + 1;

            if (n == k)
            {
                value = head.data;
            }

            return n;

        }

        public MyNode FindKthNodeWithoutRecursive(int k)
        {
            MyNode fast = head;
            MyNode slow = head;

            for (int i = 0; i < k - 1; i++)
            {
                if (fast == null) return fast;
                fast = fast.next;
            }

            if (fast == null) return null;

            while (fast.next != null)
            {

                slow = slow.next;
                fast = fast.next;
            }

            return slow;

        }
        #endregion
        #region 2.4
        //Write code to partition a linked list around a value x, such that all nodes less than x
        //come before all nodes greater than or equal to x.
        public MyNode Partition(int x)
        {
            MyNode beforeStart = null;
            MyNode beforeEnd = null;
            MyNode afterStart = null;
            MyNode afterEnd = null;
            MyNode node = head;

            while (node != null)
            {


                if (node.data <= x)
                {

                    if (beforeStart == null)
                    {

                        beforeStart = node;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.next = node;
                        beforeEnd = node;

                    }

                }

                else
                {
                    if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.next = node;
                        afterEnd = node;

                    }

                }

                node = node.next;

            }

            if (beforeStart != null)
            {
                beforeEnd.next = afterStart;
                afterEnd.next = null;
                return beforeStart;
            }
            else
            {
                afterEnd.next = null;
                return afterStart;

            }
        }
        // only use two variable
        public MyNode Partition2(int x)
        {

            MyNode node = head;
            MyNode beforeStart = null;
            MyNode afterStart = null;

            /* Partition list */
            while (node != null)
            {
                MyNode next = node.next;
                if (node.data < x)
                {
                    /* Insert node into start of before list */
                    node.next = beforeStart;
                    beforeStart = node;
                }
                else
                {
                    /* Insert node into front of after list */
                    node.next = afterStart;
                    afterStart = node;
                }
                node = next;
            }

            /* Merge before list and after list */
            if (beforeStart == null)
            {
                return afterStart;
            }

            /* Find end of before list, and merge the lists */
            MyNode before_head = beforeStart;
            while (beforeStart.next != null)
            {
                beforeStart = beforeStart.next;
            }
            beforeStart.next = afterStart;

            return before_head;
        }


        #endregion
        #region 2.5
        //You have two numbers represented by a linked list, where each node contains a
        //single digit. The digits are stored in reverse order, such that the 1 's digit is at the head
        //of the list. Write a function that adds the two numbers and returns the sum as a
        //linked list.
      
        public LinkedListNode<int> AddLists(LinkedListNode<int> l1, LinkedListNode<int> l2, int carry,LinkedListNode<int> result)
        {
            /* We're done if both lists are null AND the carry value is 0 */
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

        
           result = new LinkedListNode<int>(0);
         
         
            /* Add value, and the data from 11 and 12 */
            int value = carry;
            if (l1 != null)
            {
                value += l1.Value;
            }
            if (l2 != null)
            {
                value += l2.Value;
            }

            result.Value = value % 10; /* Second digit of number */

            /* Recurse */
            if (l1 != null || l2 != null)
            {
                LinkedListNode<int> more = AddLists(l1 == null ? null : l1.Next,
                l2 == null ? null : l2.Next,
                value >= 10 ? 1 : 0,result.Next);
                // result.setNext(more);
            }
            return result;
        }



        public class PartialSum
        {
            public MyNode sum = null;
            public int carry = 0;
        }

       public MyNode AddLists(MyNode l1, MyNode l2)
        {
            int len1 = length(l1);
            int len2 = length(l2);

            /* Pad the shorter list with zeros - see note (1) */
            if (len1 < len2)
            {
                l1 = padList(l1, len2 - len1);
            }
            else
            {
                l2 = padList(l2, len1 - len2);
            }

            /* Add lists */
            PartialSum sum = AddListsHelper(l1, l2);

            /* If there was a carry value left over, insert this at the
           21 * front of the list. Otherwise, just return the linked list. */
            if (sum.carry == 0)
            {
                return sum.sum;
            }
            else
            {
                MyNode result = InsertBefore(sum.sum, sum.carry);
                return result;
            }
        }

        private PartialSum AddListsHelper(MyNode l1, MyNode l2)
        {
            if (l1 == null && l2 == null)
            {
                PartialSum sum = new PartialSum();
                return sum; 
            }
            /* Add smaller digits recursively */
            PartialSum s = AddListsHelper(l1.next, l2.next);

            /* Add carry to current data */
            int val = s.carry + l1.data + l2.data;

            /* Insert sum of current digits */
            MyNode full_result = InsertBefore(s.sum, val % 10);

            /* Return sum so far, and the carry value */
            s.sum = full_result;
            s.carry = val / 10;
            return s;
        }

        /* Pad the list with zeros */
       private MyNode padList(MyNode l, int padding)
        {
            MyNode head = l;
            for (int i = 0; i < padding; i++)
            {
                MyNode n = new MyNode();
                n.next = head;
                head = n;
            }
            return head;
        }

        /* Helper function to insert node in the front of a linked list */
        private MyNode InsertBefore(MyNode list, int data)
        {
            MyNode node = new MyNode(data);
            if (list != null)
            {
                node.next = list;
            }
            return node;
        }


        #endregion 2.5
        #region 2.3
        //implement an algorithm to delete a node in the middle of a singly linked list, given
        // only access to that node.
        // if the list only have one node
        // myself 
        //public void DeleteList(MyNode node)
        //{
        //    MyNode temp = head;
        //    MyNode perious = head;
        //    // if the node in the head
        //    if (node == head)
        //    {
        //        head = head.next;
        //        return;
        //    }
        //    // if the node in the middle
        //    while (temp.next != null)
        //    {
        //        if (temp == node)
        //        {
        //            perious.next = temp.next;
        //            return;
        //        }
        //        else
        //        {

        //            perious = temp;
        //            temp = temp.next;
        //        }
        //    }
        //    // if the node in the tail 
        //    if (perious != null && perious.next == node)
        //    {
        //        perious.next = null;
        //    }




        //}


        public bool DeleteNode(MyNode n)
        {
            if (n == null || n.next == null)
            {
                return false; // Failure
            }
            MyNode next = n.next;
            n.data = next.data;
            n.next = next.next;
            return true;
        }

        //public void DeleteList(ref MyNode node)
        //{

        //    if (node != null && node.next != null)
        //    {

        //        MyNode temp = node;
        //        MyNode perious = null;
        //        while (temp.next != null)
        //        {
        //            temp.data = temp.next.data;
        //            perious = temp;
        //            temp = temp.next;

        //        }
        //        if (perious != null) perious.next = null;

        //    }

        //    if (node != null && node.next == null)
        //    {

        //        node = null;

        //    }


        //}

        #endregion
        #region 2.7
        //2.7 Implement a function to check if a linked list is a palindrome
        public bool IsPalindrome(MyNode head)
        {
            MyNode fast = head;
            MyNode slow = head;


            Stack<int> stack = new Stack<int>();

            /* Push elements from first half of linked list onto stack. When
             * fast runner (which is moving at 2x speed) reaches the end of
             * the linked list, then we know we're at the middle */
            while (fast != null && fast.next != null)
            {
                stack.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }

            /* Has odd number of elements, so skip the middle element */
            if (fast != null)
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                int top = stack.Pop();

                /* If values are different, then it's not a palindrome */
                if (top != slow.data)
                {
                    return false;
                }
                slow = slow.next;
            }
            return true;
        }
        private class Result
        {
            public MyNode node;
            public bool result;
            public Result(MyNode n, bool r)
            {
                result = r;
                node = n;
            }
        }
        private Result IsPalindromeRecurse(MyNode head, int length)
        {

            if (head == null || length == 0)
            {
                return new Result(null, true);
            }
            else if (length == 1)
            {
                return new Result(head.next, true);
            }
            else if (length == 2)
            {
                return new Result(head.next.next,
                 head.data == head.next.data);
            }
            Result res = IsPalindromeRecurse(head.next, length - 2);
            if (!res.result || res.node == null)
            {
                return res;
            }
            else
            {
                res.result = (head.data == res.node.data);
                res.node = res.node.next;
                return res;
            }
        }

        public bool IsPalindromeWithRecurse(int length)
        {
            Result p = IsPalindromeRecurse(head, length);
            return p.result;
        }
        #endregion

        public MyList(int[] n)
        {

            foreach (var item in n)
            {
                AppendToTaile(item);
            }
        }
        private void AppendToTaile(int d)
        {

            // if n is head
            if (head == null)
            {
                head = new MyNode();
                head.data = d;
            }
            else
            {
                MyNode temp = head;
                MyNode end = new MyNode();
                end.data = d;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = end;
                end.next = null;

            }
        }

        public int[] TravelList()
        {

            List<int> n = new List<int>();
            MyNode temp = head;
            // n.Clear();
            while (temp != null)
            {
                n.Add(temp.data);
                temp = temp.next;

            }

            return n.ToArray();

        }

        public int[] TravelList(MyNode node)
        {

            List<int> n = new List<int>();
            MyNode temp = node;
            // n.Clear();
            while (temp != null)
            {
                n.Add(temp.data);
                temp = temp.next;

            }

            return n.ToArray();

        }



        // return the node which its next node contrain the 'data'
        private MyNode TravelList(int data)
        {
            MyNode temp = head;
            while (temp.next != null)
            {
                if (temp.next.data == data)
                {
                    return temp;

                }
                else
                {
                    temp = temp.next;
                }
            }
            return null;
        }

        private void MyDeleteList(int data)
        {
            // if the head contain the data, delete the head
            if (head.data == data)
            {
                head = head.next;

            }
            else
            {
                MyNode d_node = TravelList(data);
                if (d_node != null)
                {
                    d_node.next = d_node.next.next;

                }

            }

        }




        public MyNode FindBeginning()
        {
            MyNode slow = head;
            MyNode fast = head;

            /* Find meeting point. This will be LOOP_SIZE - k steps into the
             * linked list. */
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast)
                { // Collision
                    break;
                }
            }

            /* Error check - no meeting point, and therefore no loop */
            if (fast == null || fast.next == null)
            {
                return null;
            }

            /* Move slow to Head. Keep fast at Meeting Point. Each are k
            * steps from the Loop Start. If they move at the same pace,
            * they must meet at Loop Start. */
            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }

            /* Both now point to the start of the loop. */
            return fast;
        }

        public int length(MyNode node)
        {
            int i = 0;
            while (node != null)
            {
                node = node.next;
                i = i + 1;
            }
            return i;
        }


    }
}

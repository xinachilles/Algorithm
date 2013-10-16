using System;
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

    }

    class MyList
    {

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

        public MyNode AddLists(MyNode l1, MyNode l2, int carry)
        {
            /* We're done if both lists are null AND the carry value is 0 */
            if (l1 == null && l2 == null && carry == 0)
            {
                return null;
            }

            MyNode result = new MyNode();

            /* Add value, and the data from 11 and 12 */
            int value = carry;
            if (l1 != null)
            {
                value += l1.data;
            }
            if (l2 != null)
            {
                value += l2.data;
            }

            result.data = value % 10; /* Second digit of number */

            /* Recurse */
            if (l1 != null || l1 != null)
            {
                MyNode more = AddLists(l1 == null ? null : l1.next,
                l1 == null ? null : l1.next,
                value >= 10 ? 1 : 0);
                // result.setNext(more);
            }
            return result;
        }

        #endregion 2.5

       


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


        public void DeleteList(MyNode node)
        {
            MyNode temp = head;
            MyNode perious = head;
            // if the node in the head
            if (node == head)
            {
                head = head.next;
                return;
            }
            // if the node in the middle
            while (temp.next != null)
            {
                if (temp == node)
                {
                    perious.next = temp.next;
                    return;
                }
                else
                {

                    perious = temp;
                    temp = temp.next;
                }
            }
            // if the node in the tail 
            if (perious != null && perious.next == node)
            {
                perious.next = null;
            }




        }

        //implement an algorithm to delete a node in the middle of a singly linked list, given
        // only access to that node.
        // if the list only have one node
        public void DeleteList(ref MyNode node)
        {

            if (node != null && node.next != null)
            {

                MyNode temp = node;
                MyNode perious = null;
                while (temp.next != null)
                {
                    temp.data = temp.next.data;
                    perious = temp;
                    temp = temp.next;

                }
                if (perious != null) perious.next = null;

            }

            if (node != null && node.next == null)
            {

                node = null;

            }


        }


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

       


       }
}
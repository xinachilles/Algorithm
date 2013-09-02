using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Stack
    {

        // Describe how you could use a single array to implement three stacks
        static int stackSize = 100;
        int[] buffer = new int[stackSize * 3];
        int[] stackPointer = { -1, -1, -1 }; // pointers to track top element

        public void push(int stackNum, int value)
        {
            /* Check if we have space */
            if (stackPointer[stackNum] + 1 >= stackSize)
            { // Last element
                throw new Exception("0ut of space.");
            }
            /* Increment stack pointer and then update top value */
            stackPointer[stackNum]++;
            buffer[absTopOfStack(stackNum)] = value;
        }

       public int pop(int stackNum)
        {
            if (stackPointer[stackNum] == -1)
            {
                throw new Exception("Trying to pop an empty stack.");
            }
            int value = buffer[absTopOfStack(stackNum)]; // Get top
            buffer[absTopOfStack(stackNum)] = 0; // Clear index
            stackPointer[stackNum]--; // Decrement pointer
            return value;
        }
       
       public int peek(int stackNum)
        {
            int index = absTopOfStack(stackNum);
            return buffer[index];
        }

       bool IsEmpty(int stackNum)
        {
            return stackPointer[stackNum] == -1;
        }

        /* returns index of top of stack "stackNum" in absolute terms */
       private int absTopOfStack(int stackNum)
        {
            return stackNum * stackSize + stackPointer[stackNum];
        }

        private int capacity;
 public Node top, bottom;
 public int size = 0;

 public Stack(int capacity) { this.capacity = capacity; }
 public boolean isFull() { return capacity == size; }

 public void join(Node above. Node below) {
 if (below != null) below.above = above;
 if (above != null) above.below = below;
 }

 public bool push(int v) {
 if (size >= capacity) return false;
        size++;
    Node n = new Node(v);
 if (size == 1) bottom = n;
    join(nj top);
    top = n;
 return true;
 }

 public int pop() {
 Node t = top;
64 top = top.below;
65 size--;
66 return t.value;
67 }
68
69 public boolean isEmptyQ {
70 return size == 0;
71 }
72
73 public int removeBottom() {
74 Node b = bottom;
bottom = bottom.above;
76 if (bottom != null) bottom.below = null;

    }


}

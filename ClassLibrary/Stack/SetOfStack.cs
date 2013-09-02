using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace ClassLibrary.Stack
{
    class SetOfStacks<T>
    {

        List<MyStack<T>> stacks = new List<MyStack<T>>();
        public int capacity;


        public SetOfStacks(int capacity)
        {
            this.capacity = capacity;
        }

        public void Push(T v)
        {

            MyStack<T> last = GetLastStack();
            if (last != null || !last.IsFull())
            { // add to last stack
                last.Push(v);
            }
            else
            { // must create new stack
                MyStack<T> stack = new MyStack<T>(capacity);
                stack.Push(v);
                stacks.Add(stack);
            }
        }
        public T Pop()
        {
            MyStack<T> last = GetLastStack();
            T v = last.Pop();
            if (last.size == 0) stacks.RemoveAt(stacks.Capacity - 1);
            return v;
        }

        public bool IsEmpty()
        {
            MyStack<T> last = GetLastStack();
            return (last == null);
        }

        public MyStack<T> GetLastStack()
        {
            if (stacks.Count == 0) return null;
            return stacks[stacks.Count - 1];
        }


        public T leftShift(int index, bool removeTop)
        {
            MyStack<T> stack = stacks[index];
            T removed_item;
            if (removeTop) removed_item = stack.Pop();
            else removed_item = stack.RemoveBottom();

            if (stack.IsEmpty())
            {
                stacks.RemoveAt(index);
            }
            else if (stacks.Capacity > index + 1)
            {
                T v = leftShift(index + 1, false);
                stack.Push(v);
            }
            return removed_item;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

#region 3.3
//Imagine a (literal) stack of plates. If the stack gets too high, it migh t topple. Therefore,
//in real life, we would likely start a new stack when the previous stack exceeds some
//threshold. Implement a data structure SetOfStacks that mimics this. SetOf-
//Stacks should be composed of several stacks and should create a new stack once
//the previous one exceeds capacity. SetOfStacks.push() and SetOfStacks.
//pop () should behave identically to a single stack (that is, pop () should return the
//same values as it would if there were just a single stack).

//FOLLOW UP
//Implement a function popAt(int index) which performs a pop operation on a
//specific sub-stack.
namespace ClassLibrary.Stack
{



    class SetOfStacks<T>
    {

        List<MyStack<T>> stacks = new List<MyStack<T>>();
        private int capacity;


        public SetOfStacks(int c)
        {
            capacity = c;
        }

        public void Push(T v)
        {

            MyStack<T> last = GetLastStack();
            if (last != null)
            { // add to last stack
                if (last.IsFull() != true)
                {
                    last.Push(v);
                }
                else
                {

                    MyStack<T> stack = new MyStack<T>(capacity);
                    stack.Push(v);
                    stacks.Add(stack);

                }

            }
            else
            {
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

        public T PopAt(int index)
        {
            return leftShift(index, true);

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
            else if (stacks.Count  > index + 1)
            {
                T v = leftShift(index + 1, false);
                stack.Push(v);
            }
            return removed_item;
        }

    }
}
#endregion 3.3
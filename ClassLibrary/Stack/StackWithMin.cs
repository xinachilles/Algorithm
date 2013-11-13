using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Stack
{
    // How would you design a stack which, in addition to push and pop, also has a
    // function min which returns the minimum element? Push, pop and min should all
    // operate in 0(1) time.
    class StackWithMin : Stack<NodeWithMin>
    {
        public void push(int value)
        {
            int newMin = Math.Min(value, min());
            base.Push(new NodeWithMin(value, newMin));
        }

        public int min()
        {
            if (this.Count == 0)
            {
                return int.MaxValue; // Error value
            }
            else
            {
                return Peek().min;
            }
        }


    }

    class NodeWithMin
    {
        public int value;
        public int min;
        public NodeWithMin(int v, int min)
        {
            value = v;
            this.min = min;
        }
    }
}

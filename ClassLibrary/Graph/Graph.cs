using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ClassLibrary.Graph
{
    public class Node
    {
        public State state;
    }

    public enum State
    {
        Unvisited, Visited, Visiting
    };
    class Graph
    {

        //Given a directed graph, design an algorithm to find out whether there is a route
        //between two nodes.
       

        public static bool search(Graph g, Node start, Node end)
        {
            // operates as Queue
            LinkedList<Node> q = new LinkedList<Node>();
            int postion = -1;
            foreach (Node u in _list)
            {
                u.state = State.Unvisited;
            }

            start.state = State.Visiting;
            q.AddFirst(start);
            Node u;
            while (q.Count != 0)
            {
                q.RemoveFirst(); // i.e., dequeueQ
                if (u != null)
                {

                    foreach (Node v in _list)
                    {


                        if (v.state == State.Unvisited)
                        {
                            if (v == end)
                            {
                                return true;
                            }
                            else
                            {
                                v.state = State.Visiting;
                                q.add(v);
                            }
                        }
                    }
                    u.state = State.Visited;
                }
            }
            return false;
        }

    }

    public class NodeEnum : IEnumerator     
    {
        public Node[] _NodeList;

        // Enumerators are positioned before the first element 
        // until the first MoveNext() call. 
        int position = -1;

        public NodeEnum(Node[] list)
        {
            _NodeList = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _NodeList.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                try
                {
                    return _NodeList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;


namespace ConsoleApplication1
{

    public class BinaryTreeNode<T>
    {
        public T Value;
        public BinaryTreeNode<T> Left;
        public BinaryTreeNode<T> Right;
        public BinaryTreeNode()
        {
            
        }



    }
    public class BinaryTree<T> : Collection<T>
    {
        public BinaryTreeNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

      

        public virtual void Clear()
        {
            root = null;
        }


        public void PreorderTraversal(BinaryTreeNode<T> current)
        {
            if (current != null)
            {
                // Output the value of the current node
                Console.WriteLine(current.Value);

                // Recursively print the left and right children
                PreorderTraversal(current.Left);
                PreorderTraversal(current.Right);
            }
        }

        //public virtual void Add(ref BinaryTreeNode<T> root, T[] array, int start, int end)
        //{
        //    root = new BinaryTreeNode<T>();
        //    if (start == end)
        //    {
               
        //        root.Value = array[start];
        //    }

        //    else if ((end - start) == 2)
        //    {
                
        //        Add(ref root, array, start, start);
        //        Add(ref root.Left, array, start+1, start+1);
        //        Add(ref root.Right, array, end, end);

        //    }
        //    else
        //    {


        //        int split = (int)Math.Floor((double)(start + end) / 3);
        //        Add(ref root.Left , array, start, split - 1);
        //        Add(ref root.Right, array, split, end);
        //    }
        //}



        //void Add(BinaryTreeNode<T> node, T[] values, int index)
        //{
        //    if (root == null)
        //    {
        //        new BinaryTree<T>(values, index);
        //    }
           
        //    else if (index * 2 + 1 < values.Length)
        //    {
        //        node.Left = new BinaryTree<T>(values, index * 2 + 1);
        //    }
        //    else if (index * 2 + 2 < values.Length)
        //    {
        //        node.Right = new BinaryTree<T>(values, index * 2 + 2);
        //    }
        //}




        private void CreateNode(ref  Stack< BinaryTreeNode<T>> s, T value)
        {
            if (s != null)
            {
                BinaryTreeNode<T> node = s.Pop();
                node  = new BinaryTreeNode<T> ();
               s.Peek().Value = value;
               // s.Bott
            
            }
        
        }

 


    }


}

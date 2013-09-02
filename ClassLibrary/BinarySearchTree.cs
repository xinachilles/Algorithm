using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Comparer: IComparer<object>
    {
        public int Compare(object x, object y)
    { 
        

         if (x == y)
        {
            return 0;
        }
        else if ((int)x>(int)y)
        {
            return 1;
        }
        else 
        {
            return -1;
        }
        
    }
}
    
    
        
    class BinarySearchTree<T>:BinaryTree<T> 
    {

        private IComparer<object> comparer = new Comparer();
        private int count;
 
        public BinaryTreeNode<int> TreeSearch(BinaryTreeNode<int> x, int k)
       { 
         if((x == null) || (k == x.Value))
         {
            return x;
          }
         else if (k<x.Value)
         {
            return TreeSearch(x.Left, k);

         }
         else {
             return TreeSearch(x.Right, k);
         }
        
       }

       public BinaryTreeNode<T> TreeMin(BinaryTreeNode<T> x)
       {
           while (x.Left != null)
           {
               x = x.Left; 
           
           }

           return x;
       
       }

       public BinaryTreeNode<T> TreeMax(BinaryTreeNode<T> x)
       { 
        while(x.Right != null)
        {
            x = x.Right;
        }

           return x;
        
       }


       public virtual void Add(T data)
       {
           int result;
         
           // create a new Node instance
           BinaryTreeNode<T> n = new BinaryTreeNode<T>();
           n.Value = data;
         
           // now, insert n into the tree
           // trace down the tree until we hit a NULL
           BinaryTreeNode<T> current = root, parent = null;
           while (current != null)
           {
               result = comparer.Compare(current.Value, data);
               if (result == 0)
                   // they are equal - attempting to enter a duplicate - do nothing
                   return;
               else if (result > 0)
               {
                   // current.Value > data, must add n to current's left subtree
                   parent = current;
                   current = current.Left;
               }
               else if (result < 0)
               {
                   // current.Value < data, must add n to current's right subtree
                   parent = current;
                   current = current.Right;
               }
           }

           // We're ready to add the node!
           count++;
           if (parent == null)
               // the tree was empty, make n the root
               root = n;
           else
           {
               result = comparer.Compare(parent.Value, data);
               if (result > 0)
                   // parent.Value > data, therefore n must be added to the left subtree
                   parent.Left = n;
               else
                   // parent.Value < data, therefore n must be added to the right subtree
                   parent.Right = n;
           }
       }


       public bool Contains(T data)
       {
           // search the tree for a node that contains data
           BinaryTreeNode<T> current = root;
           int result;
           while (current != null)
           {
               result = comparer.Compare(current.Value, data);
               if (result == 0)
                   // we found data
                   return true;
               else if (result > 0)
                   // current.Value > data, search current's left subtree
                   current = current.Left;
               else if (result < 0)
                   // current.Value < data, search current's right subtree
                   current = current.Right;
           }

           return false;       // didn't find data
       }
    }
    
} 


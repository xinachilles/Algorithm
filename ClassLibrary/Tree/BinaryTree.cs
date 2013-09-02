using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.ObjectModel;


namespace ClassLibrary.Tree
{

    public class TreeNode<T>
    {
        private T data;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode() { }
        public TreeNode(T value)
        {

            data = value;
        }



        public T Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }



    }
    public class BinaryTree<T> 
    {
        
        public TreeNode<T> root;

        private Queue<TreeNode<T>> TreeRecords = new Queue<TreeNode<T>>();



        public void InorderTraversal(TreeNode<T> current)
        {
            if (current!=null)
            {
                InorderTraversal(current.left);
                Console.WriteLine(current.Value);
                InorderTraversal(current.right);
            }
        
        }

        public void InorderTraversalWhileLoop(TreeNode<T> current)
        {

                bool done = false; 
                Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
    
                while (done  == false)
                {
                   if(current != null)
                    {
                        stack.Push(current);
                        current = current.left;
                    }
                    else
                   {
                       if (stack.Count ==0)
                       {
                            done = true; 
                       }else {
                            
                            TreeNode<T> node = stack.Pop();
                            Console.WriteLine(node.Value);
                            current = node.right; 
                            
                       }

                   
                   }
                    

                }

                
            }
        
        
        public void PreorderTraversal(TreeNode<T> current)
        {
            if (current != null)
            {
                // Output the value of the current node
                Console.WriteLine(current.Value);

                // Recursively print the left and right children
                PreorderTraversal(current.left);
                PreorderTraversal(current.right);
            }
        }

        public void PreorderTraversalWhileLoop(TreeNode<T> current)
        {
            Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
            bool done = false ;
            while (done == false)
            { 
                if(current != null) 
                {
                    Console.WriteLine(current.Value);
                    stack.Push(current);
                    current = current.left; 
                }
                else{
                    if (stack.Count == 0) { done = true; }
                    else
                    {
                        TreeNode<T> node = stack.Pop();
                        current = node.right;
                    }
                    
                    }
            }
        
        
        }


                    
        public void Add(T data)
        {

            TreeNode<T> current = new TreeNode<T>(data);


            if (root == null)
            {
                root = new TreeNode<T>(data);
                TreeRecords.Enqueue(root);

            }
            else
            {

                if (TreeRecords.Count > 0)
                {

                    TreeNode<T> node = TreeRecords.Peek();

                    if (node.right != null && node.left != null)
                    {
                        TreeRecords.Dequeue();
                        TreeRecords.Enqueue(node.right);
                        TreeRecords.Enqueue(node.left);
                        node = TreeRecords.Peek();

                    }

                   

                    if (node.right == null)
                    {
                        node.right = current;

                    }

                    else if (node.left == null)
                    {
                        node.left = current;

                    }

                }
            }


        }

        #region 4.1
        //4.1 Implement a function to check if a binary tree is balanced. For the purposes of
        //this question, a balanced tree is defined to be a tree such that the heights of the
        //two subtrees of any node never differ by more than one.
        public int getHeight(TreeNode<T> node)
        {
            if (node == null) return 0; // Base case
            return Math.Max(getHeight(node.left), getHeight(node.right)) + 1;
        }

        public bool IsBalanced(TreeNode<T> node)
        {
            if (node == null) return true; // Base case
            int heightDiff = getHeight(node.left) - getHeight(node.right);

            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            { // Recurse
                return IsBalanced(node.left) && IsBalanced(node.right);
            }
        }

        // Anther way to implent the check the balance 
       private static int checkHeight(TreeNode<T> root)
        {
            if (root == null)
            {
                return 0; // Height of 0
            }

            /* Check if left is balanced. */
            int leftHeight = checkHeight(root.left);
            if (leftHeight == -1)
            {
                return -1; // Not balanced
            }
            /* Check if right is balanced. */
            int rightHeight = checkHeight(root.right);
            if (rightHeight == -1)
            {
                return -1; // Not balanced
            }

            /* Check if current node is balanced. */
            int heightDiff = leftHeight - rightHeight;
            if (Math.Abs(heightDiff) > 1)
            {
                return -1; // Not balanced
            }
            else
            {
                /* Return height */
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public bool IsBalancedTwo(TreeNode<T> root)
        {
            if (checkHeight(root) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        #endregion


        ArrayList createLevell_inkedList(TreeNode<T> root)
        {
            ArrayList result = new ArrayList();
            /* "Visit" the root */
            LinkedList<TreeNode<T>> current = new LinkedList<TreeNode<T>>();
            if (root != null)
            {
                current.AddFirst(root);
            }

            while (current.Count > 0)
            {
                result.Add(current); // Add previous level
                LinkedList<TreeNode<T>> parents = current; // Go to next level
                current = new LinkedList<TreeNode<T>>();

                foreach (TreeNode<T> parent in parents)
                {


                    /* Visit the children */
                    if (parent.left != null)
                    {
                        current.AddFirst(parent.left);
                    }
                    if (parent.right != null)
                    {
                        current.AddFirst(parent.right);
                    }
                }
            }
            return result;
        }

        #region 4.5

        //4.5 Impemen t a function to check if a binary tree is a binary search tree.
        //1 . in order travel -> copy to array -> check the array if sorted 
        // we must assume the tree don`t have duplicate value 

        public int index = 0;
        public int last_printed_value = int.MinValue;

        private void copyBST(TreeNode<int> root, ref int[] array)
        {
            if (root == null) return;
            copyBST(root.left, ref array);
            array[index] = root.Value;
            index++;
            copyBST(root.right,ref array);
        }

        public bool checkBST(int[] array, TreeNode<int> root)
        {
            copyBST(root, ref array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1]>=array[i])
                {
                    return false;
                }
            }

            return true;
                    
        }
      
        // 4.5 second way that we remove the uncessary array 
        public bool checkBST(TreeNode<int> root)
        {

            if (root == null) return true;
            //check  recurse left 

            if (!checkBST(root.left)) return false;

            //check current 
            if (root.Value <= last_printed_value) return false;
            last_printed_value  = root.Value;

            //check recurse right 
            if (!checkBST(root.right)) return false;

            return true; // all good! 

        }

        public bool checkBST(TreeNode<int> node,int min, int max )
        {
            if (root == null) return true;

           // check current value 
            if (node.Value > max || node.Value <= min) { return false; }

            if(! checkBST(node.left, min,node.Value)  || !checkBST(node.right, node.Value,min)) 
            {   return false; 
            
            }

            return true;
                  
        }

        #endregion

        #region 4.4
        //4.4 Given a binary tree, design an algorithm which creates a linked list of all the nodes at
        //each depth (e.g., if you have a tree with depth D, you'll have D linked lists).

        private void createLevelLinkedList(TreeNode<T> root, List<List<TreeNode<T>>>  lists, int level)
        {
            if (root == null) return; // base case

            List<TreeNode<T>> list = null;
            if (lists.Capacity == level)
            { // Level not contained in list
                list = new List<TreeNode<T>>();
                /* Levels are always traversed in order. So., if this is the
                * first time we've visited level i, we must have seen levels
                10 * 0 through i - 1. We can therefore safely add the level at
                II * the end. */
                lists.Add(list);
            }
            else
            {
                list = lists[level];
            }
            list.Add(root);
            createLevelLinkedList(root.left, lists, level + 1);
            createLevelLinkedList(root.right, lists, level + 1);
        }

        #endregion

        //Design an algorithm and write code to find the first common ancestor of two nodes
        //in a binary tree. Avoid storing additional nodes in a data structure. NOTE: This is not
        //necessarily a binary search tree.

        public TreeNode<T> commonAncerstor(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            if (covers(root, p) == false && covers(root, q) == false) return null;

            return commonAncerstorHelper(root, p, q);


        }

        private bool covers(TreeNode<T> root, TreeNode<T> node)
        {
            if (root == null) return false;

            if (root == node) return true;

            return (covers(root.left, node) || covers(root.right, node));

        }

        private TreeNode<T> commonAncerstorHelper(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            if (root == null) return null; ;
            if ((p == root) || (q == root)) return root;
            bool is_root_left_p = covers(root.left, p);
            bool is_root_left_q = covers(root.left, q);

            if (is_root_left_p != is_root_left_q) return root;

            TreeNode<T> child_node = is_root_left_p ? root.left : root.right;

            return commonAncerstorHelper(child_node, p, q);
        }

        public class result
        {
            public TreeNode<T> node;
            public bool isAncestor;



        }

        private result commonAncerstorHelperProved(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            if (root == null) return new result { node = null, isAncestor = false };

            if (root == p && root == q) return new result { node = root, isAncestor = true };

            // check the right node
            result xr = commonAncerstorHelperProved(root.right, p, q);
            if (xr.isAncestor) return xr;

            // check the left node
            result xl = commonAncerstorHelperProved(root.left, p, q);
            if (xl .isAncestor) return xl;

            // check itself 
            if (xr.node != null && xl.node != null)
            {
                return new result { node = root, isAncestor = true };
            }
            else
            {
                if (p == root || q == root)
                {
                    bool ancestor = (xr.node != null || xl.node != null ? true : false);
                    return new result { node = root, isAncestor = ancestor };
                }
                else
                {
                    return new result
                    {
                        node = (xr.node  != null ? xr.node : xl.node),
                        isAncestor = false
                    };
                }


            }

        }

        public TreeNode<T> commonAncerstorProved(TreeNode<T> root, TreeNode<T> p, TreeNode<T> q)
        {
            result r = commonAncerstorHelperProved(root, p, q);
            if (r.isAncestor)
            {
                return r.node;
            }
            else
            {
                return null;
            }



        }


       // Given a binary tree, design an algorithm which creates a linked list of all the nodes at
       // each depth (e.g., if you have a tree with depth D, you'll have D linked lists).
    }

}

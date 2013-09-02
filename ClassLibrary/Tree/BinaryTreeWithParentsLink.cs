using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary.Tree
{
    public class TreeNodeWithParentsLink<T> : TreeNode<T>
    {
        private T data;
        new public TreeNodeWithParentsLink<T> left;
        new public TreeNodeWithParentsLink<T> right;
        public TreeNodeWithParentsLink<T> parents;

        public TreeNodeWithParentsLink() { }
        public TreeNodeWithParentsLink(T value)
        {
            data = value;
      
        }
    }

    class BinaryTreeWithParentsLink<T> : BinaryTree<T>
    {
        new public TreeNodeWithParentsLink<T> root;
        private Queue<TreeNodeWithParentsLink<T>> TreeRecords = new Queue<TreeNodeWithParentsLink<T>>();

        public TreeNodeWithParentsLink<T> Inordrsucc(TreeNodeWithParentsLink<T> current)
        {
            if (current.right == null)
            {
                if (current != null)
                {
                    current = current.parents;
                    while (current.left != null)
                    {
                        current = current.right;
                    }
                }
                return current;

            }

            TreeNodeWithParentsLink<T> x = current.parents;
            TreeNodeWithParentsLink<T> node = current;

            while (x != null && x.left != node)
            {
                node = x;
                x = x.parents;

            }

            return x;

        }


        new public void Add(T data)
        {

            TreeNodeWithParentsLink<T> current = new TreeNodeWithParentsLink<T>(data);


            if (root == null)
            {
                root = new TreeNodeWithParentsLink<T>(data);
                TreeRecords.Enqueue(root);

            }
            else
            {

                if (TreeRecords.Count > 0)
                {

                    TreeNodeWithParentsLink<T> node = TreeRecords.Peek();

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
                        node.right.parents = node;

                    }

                    else if (node.left == null)
                    {
                        node.left = current;
                        node.left.parents = node;

                    }

                }
            }


        }

    }


}

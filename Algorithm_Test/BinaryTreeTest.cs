using ClassLibrary.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for BinaryTreeTest and is intended
    ///to contain all BinaryTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BinaryTreeTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion



        /// <summary>
        ///A test for commonAncerstorProved
        ///</summary>
        public void CommonAncerstorProvedTestHelper<T>()
        {
            BinaryTree<int> target = new BinaryTree<int>(); // TODO: Initialize to an appropriate value
            
            int[] data = new int[7];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i + 1;
            }

            for (int i = 0; i < data.Length; i++)
            {
                target.Add(data[i]);
            }

            
            TreeNode<int> root = target.root ; // TODO: Initialize to an appropriate value
            
            // case 1: two notes in the same subtree

            //TreeNode<int> p = target.root.left.right.left ; // TODO: Initialize to an appropriate value
            //TreeNode<int> q = target.root.left; // TODO: Initialize to an appropriate value


            // case 2 :two notes in the differet subtree
            TreeNode<int> p = target.root.left.left; // TODO: Initialize to an appropriate value
            TreeNode<int> q = target.root.right.right; // TODO: Initialize to an appropriate value
            
            TreeNode<int> expected = target.root; // TODO: Initialize to an appropriate value
            
            TreeNode<int> actual =  target.commonAncerstorProved(root, p, q);

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void CommonAncerstorProvedTest()
        {
            CommonAncerstorProvedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InorderTraversal
        ///</summary>
        public void InorderTraversalTestHelper<T>()
        {
            BinaryTree<int> target = CreateBinaryTree(7);

            target.InorderTraversal(target.root);
            
        }

        [TestMethod()]
        public void InorderTraversalTest()
        {
            InorderTraversalTestHelper<GenericParameterHelper>();
        }



        /// <summary>
        ///A test for InorderTraversalWhileLoop
        ///</summary>
        public void InorderTraversalWhileLoopTestHelper<T>()
        {
           BinaryTree<int> target = CreateBinaryTree(7); 
           target.InorderTraversalWhileLoop(target.root);
            
        }

        [TestMethod()]
        public void InorderTraversalWhileLoopTest()
        {
            InorderTraversalWhileLoopTestHelper<GenericParameterHelper>();
        }

      

        /// <summary>
        ///A test for checkBST
        ///</summary>
        public void CheckBSTTestHelper<T>()
        {

            int[] data = { 20, 30, 10, 25 };
            BinaryTree<int> target = CreateBinaryTree(data);
            int[] array = new int[4]; // TODO: Initialize to an appropriate value
            TreeNode<int> root = target.root; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.checkBST(array, root);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod()]
        public void CheckBSTTest()
        {
            CheckBSTTestHelper<GenericParameterHelper>();
        }

        #region private function

        private BinaryTree<int> CreateBinaryTree(int length)
        {
            BinaryTree<int> target = new BinaryTree<int>(); 

            int[] data = new int[length];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i + 1;
            }
            for (int i = 0; i < data.Length; i++)
            {
                target.Add(data[i]);
            }

            return target;

        }

        private BinaryTree<int> CreateBinaryTree(int[] data)
        {
            BinaryTree<int> target = new BinaryTree<int>(); 

            for (int i = 0; i < data.Length; i++)
            {
                target.Add(data[i]);
            }

            return target; 
        }
        #endregion

     
        /// <summary>
        ///A test for IsBalancedTwo
        ///</summary>
        public void IsBalancedTwoTestHelper<T>()
        {
            BinaryTree<int> target = CreateBinaryTree(8); 
            TreeNode<int> root = target.root; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsBalancedTwo(root);
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        public void IsBalancedTwoTest()
        {
            IsBalancedTwoTestHelper<GenericParameterHelper>();
        }
    }
}

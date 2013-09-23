using ClassLibrary.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for BinarySearchTreeTest and is intended
    ///to contain all BinarySearchTreeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BinarySearchTreeTest
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
        ///A test for Add
        ///</summary>
        [TestMethod()]
        public void AddTest1()
        {
            BinarySearchTree target = new BinarySearchTree(); // TODO: Initialize to an appropriate value
            int[] data = {1,2,3,4,6,7,10,11}; // TODO: Initialize to an appropriate value

            for (int i = 0; i < data.Length; i++)
            {
                target.Add(data[i]);    
            }


            
            
        }


        /// <summary>
        ///A test for FindSum
        ///</summary>
        [TestMethod()]
        public void FindSumTest()
        {
            BinarySearchTree target = new BinarySearchTree(); // TODO: Initialize to an appropriate value
           
            int[] data = { 1, 2, 3, 4, 5, 6, 7, 11 };
            for (int i = 0; i < data.Length; i++)
            {
                target.Add(data[i]);
            }

          
            int sum = 18; // TODO: Initialize to an appropriate value
            target.FindSum(target.root, sum);
             
            
        }

        /// <summary>
        ///A test for containsTree
        ///</summary>
        [TestMethod()]
        public void ContainsTreeTest()
        {
            BinarySearchTree t1 = new BinarySearchTree(); // TODO: Initialize to an appropriate value
            BinarySearchTree t2 = new BinarySearchTree(); // TODO: Initialize to an appropriate value
           
            int[] data = { 3,4,5, 6,2 };
            int[] data2 = { 4,2 };

            for (int i = 0; i < data.Length; i++)
            {
                t1.Add(data[i]); 
            }

            for (int i = 0; i < data.Length; i++)
            {
                t2.Add(data[i]);
            }

           
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = t1.containsTree(t2.root);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for createMinimalBST
        ///</summary>
        [TestMethod()]
        public void createMinimalBSTTest()
        {
            BinarySearchTree target = new BinarySearchTree(); // TODO: Initialize to an appropriate value
            int[] arrj = { 0,1,2,3,4,5,6,7 };
            int start = 0; // TODO: Initialize to an appropriate value
            int end = arrj.Length -1; // TODO: Initialize to an appropriate value
            
            TreeNode<int> actual;
            actual = target.createMinimalBST(arrj, start, end);
            //Assert.AreEqual(expected, actual);
           
        }
    }
}

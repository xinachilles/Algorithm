using ClassLibrary.Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for BinaryTreeWithParentsLinkTest and is intended
    ///to contain all BinaryTreeWithParentsLinkTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BinaryTreeWithParentsLinkTest
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
        ///A test for Inordrsucc
        ///</summary>
        public void InordrsuccTestHelper<T>()
        {
            BinaryTreeWithParentsLink<int> target = CreateBinaryTree();
            TreeNodeWithParentsLink<int> current = target.root.right.left;
            TreeNodeWithParentsLink<int> expected = target.root.right.right; // TODO: Initialize to an appropriate value
            TreeNodeWithParentsLink<int> actual;
            actual = target.Inordrsucc(current);
            Assert.AreEqual(expected, actual);
           
        }

        [TestMethod()]
        public void InordrsuccTest()
        {
            InordrsuccTestHelper<GenericParameterHelper>();
        }

        private BinaryTreeWithParentsLink<int> CreateBinaryTree()
        {
            BinaryTreeWithParentsLink<int> target = new BinaryTreeWithParentsLink<int>(); // TODO: Initialize to an appropriate value
            // TreeNode<int> current = target.root; // TODO: Initialize to an appropriate value

            int[] data = new int[7];

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
    }
}

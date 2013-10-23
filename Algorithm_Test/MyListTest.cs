using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for MyListTest and is intended
    ///to contain all MyListTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyListTest
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
        ///A test for RemoveDuplicate
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicateTest()
        {
            int[] number = { 1,1,1,1,1,1 }; // TODO: Initialize to an appropriate value
            int[] expect = { 1 };
            MyList target = new MyList(number); // TODO: Initialize to an appropriate value
            target.RemoveDuplicate();
            CollectionAssert.AreEqual(expect, target.TravelList());

        }



        /// <summary>
        ///A test for TravelList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void TravelListTest()
        {
            int[] s = { 1, 2, 3, 2, 2, 1, 4 };
            int[] except = { 1, 2, 3, 2, 2, 1, 4 };
            //PrivateObject param0 = new PrivateObject(null); // TODO: Initialize to an appropriate value
            MyList_Accessor target = new MyList_Accessor(s); // TODO: Initialize to an appropriate value
           CollectionAssert.AreEqual(except, target.TravelList());
        }

     
        /// <summary>
        ///A test for RemoveDuplicate
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicateTest1()
        {
            int[] n = {1,1,2,1,1,1,1}; // TODO: Initialize to an appropriate value
            int[] expected = {1,2};
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            target.RemoveDuplicate();
            CollectionAssert.AreEqual(expected, target.TravelList());
        }

        /// <summary>
        ///A test for RemoveDuplicateWithoutBuffer
        ///</summary>
        [TestMethod()]
        public void RemoveDuplicateWithoutBufferTest()
        {
            int[] n = { 1, 1, 1, 2, 1, 1, 1 }; // TODO: Initialize to an appropriate value
            int[] expected = { 1,2 };
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            target.RemoveDuplicateWithoutBuffer();
            CollectionAssert.AreEqual(expected, target.TravelList());
        }

        /// <summary>
        ///A test for FindKth
        ///</summary>
        [TestMethod()]
        public void FindKthTest()
        {
            int[] n =  { 1, 2, 3, 4, 5, 6, 7 }; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            //MyNode node = null; // TODO: Initialize to an appropriate value
            int k = 4; // TODO: Initialize to an appropriate value
           // MyNode expected = null; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.FindKth(k);
            Assert.AreEqual(4, actual);
           
        }




        /// <summary>
        ///A test for FindKthNodeWithoutRecursive
        ///</summary>
        [TestMethod()]
        public void FindKthNodeWithoutRecursiveTest()
        {
            int[] n = { 1, 2, 3, 4, 5, 6, 7 };  // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            int k = 3; // TODO: Initialize to an appropriate value
            int expected = 5; // TODO: Initialize to an appropriate value
            MyNode actual;
            actual = target.FindKthNodeWithoutRecursive(k);
            Assert.AreEqual(expected, actual.data );
           
        }

        /// <summary>
        ///A test for Partition
        ///</summary>
        [TestMethod()]
        public void PartitionTest()
        {
            int[] n = { 7,2, 4, 1, 5, 3, 6 }; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            int[] expected = {2,1,3,7,4,5,6}; // TODO: Initialize to an appropriate value
            
            MyNode actual = target.Partition(3);
            CollectionAssert.AreEqual(expected, target.TravelList(actual));
            
        }


        /// <summary>
        ///A test for isPalindromeWithRecurse
        ///</summary>
        [TestMethod()]
        public void IsPalindromeWithRecurseTest()
        {
            int[] n = {2,1,1,2}; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            int length = n.Length; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsPalindromeWithRecurse(length);
            Assert.AreEqual(expected, actual);
          
        }

        /// <summary>
        ///A test for Item
        ///</summary>
        [TestMethod()]
        public void ItemTest()
        {
            int[] n = {0,1,2,3,4,5,6,7,8,9}; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            int index = 3; // TODO: Initialize to an appropriate value
            int expected = 9; // TODO: Initialize to an appropriate value
            int actual;
           target[index] = expected;
           actual = target[index];
            Assert.AreEqual(expected, actual);
                    }



        /// <summary>
        ///A test for IsPalindrome
        ///</summary>
        [TestMethod()]
        public void IsPalindromeTest()
        {
            int[] n = {1}; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            MyNode head = target.head; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsPalindrome(head);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for DeleteNode
        ///</summary>
        [TestMethod()]
        public void DeleteNodeTest()
        {
            int[] n = {1,2,3,4,5,6}; // TODO: Initialize to an appropriate value
            MyList target = new MyList(n); // TODO: Initialize to an appropriate value
            MyNode n1 = target.head.next.next; // TODO: Initialize to an appropriate value
            MyNode nExpected = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.DeleteNode( n1);
          
            
        }
    }
}

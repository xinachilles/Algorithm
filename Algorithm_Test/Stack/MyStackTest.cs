using ClassLibrary.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for MyStackTest and is intended
    ///to contain all MyStackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyStackTest
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
        ///A test for Push
        ///</summary>
        [TestMethod()]
        public void PushTest()
        {
            int capacity = 2; // TODO: Initialize to an appropriate value
            MyStack<int> target = new MyStack<int>(capacity); // TODO: Initialize to an appropriate value
            target.Push(1);
            target.Push(2);
            target.Push(3);
            target.Push(4);
            target.Push(5);
            target.Push(6);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Sort
        ///</summary>
        public void SortTestHelper<T>()
        {
            Stack<int> s = new Stack<int>(); // TODO: Initialize to an appropriate value
            Stack<int> expected = new Stack<int>(); // TODO: Initialize to an appropriate value
            Stack<int> actual;
            s.Push(10);
            s.Push(2);
            s.Push(5);
            expected.Push(10);
            expected.Push(5);
            expected.Push(2);
            actual = MyStack<T>.Sort(s);
            CollectionAssert.AreEqual(expected, actual);  
            
        }

        [TestMethod()]
        public void SortTest()
        {
            SortTestHelper<GenericParameterHelper>();
        }
    }
}

using ClassLibrary.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for StackTwoTest and is intended
    ///to contain all StackTwoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StackTwoTest
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
        [ExpectedException(typeof(Exception), "Out of space.")]
        public void PushTestOutofNumber()
        {
            try
            {
                StackTwo s = new StackTwo();
                s.Push(0, 1);
                s.Push(0, 2);
                s.Push(0, 3);
                s.Push(0, 4);
                
            }
            catch (Exception e)
            {

                Assert.AreEqual("Out of space.", e.Message);
            }
                                  
        }

           /// <summary>
        ///A test for Peek
        ///</summary>
        [TestMethod()]
        public void PeekTest()
        {
            StackTwo s = new StackTwo();
            int expected = 5; // TODO: Initialize to an appropriate value
            int actual;
            s.Push(0, expected);
            actual = s.Peek(0);
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for EmptyStack
        ///</summary>
        [TestMethod()]
        public void EmptyStackTest()
        {
            bool expected = true;
            StackTwo s = new StackTwo();
                       
            for (int i = 0; i < s.NumberOfElements(); i++)
            {
                bool actual = s.IsEmpty(i);
                Assert.AreEqual(expected, actual);
            }
           
           
            
           
        }
    }
}

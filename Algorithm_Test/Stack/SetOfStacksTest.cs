using ClassLibrary.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for SetOfStacksTest and is intended
    ///to contain all SetOfStacksTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SetOfStacksTest
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
        ///A test for PopAt
        ///</summary>
        public void PopAtTestHelper<T>()
        {
            SetOfStacks<int> target = new SetOfStacks<int>(2) ; // TODO: Initialize to an appropriate value
            target.Push(1);
            target.Push(2);
            target.Push(3);
            target.Push(4);
            target.Push(5);
            target.Push(6);
            int actual = target.PopAt(1);
           ;
        }

        [TestMethod()]
        public void PopAtTest()
        {
            PopAtTestHelper<GenericParameterHelper>();
        }
    }
}

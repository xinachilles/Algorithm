using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for SerarchTest and is intended
    ///to contain all SerarchTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SerarchTest
    {


        private TestContext TestContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return TestContextInstance;
            }
            set
            {
                TestContextInstance = value;
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
        ///A test for BinarySearchMagicIndexRecursion
        ///</summary>
        [TestMethod()]
        public void BinarySearchMagicIndexRecursionTest()
        {
            Serarch target = new Serarch(); // TODO: Initialize to an appropriate value
            int[] data = { 1, 2, 3, 3, 4, 6 };
            int start = 0; // TODO: Initialize to an appropriate value
            int end = data.Length -1; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.BinarySearchMagicIndexRecursion(data, end, start);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for RotatedBinarySearch
        ///</summary>
        [TestMethod()]
        public void RotatedBinarySearchTest()
        {
            Serarch target = new Serarch(); // TODO: Initialize to an appropriate value
            int[] data = {15, 16, 19, 20, 25, 1, 3, 4, 5, 7, 10, 14 };
            int x = 26; 
            int left = 0; 
            int right = data.Length -1; 
            int expected = -1; 
            int actual;
            actual = target.RotatedBinarySearch(data, x, left, right);
            Assert.AreEqual(expected, actual);
            
        }
    }
}

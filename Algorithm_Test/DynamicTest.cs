using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for DynamicTest and is intended
    ///to contain all DynamicTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DynamicTest
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
        ///A test for FastestWay
        ///</summary>
        [TestMethod()]
        public void FastestWayTest()
        {
            Dynamic target = new Dynamic();
            int[,] a = new int[,]{ {7,9,3,4,8,4}, { 8,5,6,4,5,7} };
            int[,] t = new int[,] { { 2, 3, 1, 3, 4 }, { 2, 1, 2, 2, 1 } };
            int[] e = { 2,  4 };
            int x1 = 3; // TODO: Initialize to an appropriate value
            int x2 = 2; // TODO: Initialize to an appropriate value
            int n = 6; // TODO: Initialize to an appropriate value
            int f_final = 0; // TODO: Initialize to an appropriate value
            int l_final = 0; // TODO: Initialize to an appropriate value
            target.FastestWay(a, t, e, x1, x2, n,ref f_final, ref l_final);
            Assert.AreEqual(f_final, 38);
            Assert.AreEqual(l_final, 1);
            
        }

        /// <summary>
        ///A test for MatrixChainOrder
        ///</summary>
        [TestMethod()]
        public void MatrixChainOrderTest()
        {
            Dynamic target = new Dynamic(); // TODO: Initialize to an appropriate value
            int n = 6;
            int[] p = { 30, 35, 15, 5, 10, 20, 25 };
            int[,] m = new int[n+1,n+1]; // TODO: Initialize to an appropriate value
            target.MatrixChainOrder(p, m, n);
                }
    }
}

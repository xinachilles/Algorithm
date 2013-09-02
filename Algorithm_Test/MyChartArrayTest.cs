using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for MyChartArrayTest and is intended
    ///to contain all MyChartArrayTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyChartArrayTest
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
        ///A test for ReplaceMatrix
        ///</summary>
        [TestMethod()]
        public void ReplaceMatrixTest()
        {
            int [,] s = {{1,0,1},{2,3,4},{3,1,0} }; // TODO: Initialize to an appropriate value
            MyChartArray target = new MyChartArray(s); // TODO: Initialize to an appropriate value
            int[,] expected = { { 0, 0, 0 }, { 0, 0, 0}, { 0, 0, 0 } }; // TODO: Initialize to an appropriate value
            int[,] actual;
            actual = target.ReplaceMatrix();
            CollectionAssert.AreEqual(expected, actual);
            
        }




                  }
}

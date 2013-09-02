using ClassLibrary.Stack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for StackTowerTest and is intended
    ///to contain all StackTowerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StackTowerTest
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
        ///A test for moveDisks
        ///</summary>
        [TestMethod()]
        public void moveDisksTest()
        {
            int n = 3;
            StackTower[] towers = new StackTower[n];
            for (int i = 0; i < 3; i++)
            {
                towers[i] = new StackTower(i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                towers[0].add(i);
            }
            
                towers[0].moveDisks(n, towers[2], towers[1]);
        }

    }      
    
}

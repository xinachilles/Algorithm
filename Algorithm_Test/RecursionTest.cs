using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for RecursionTest and is intended
    ///to contain all RecursionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RecursionTest
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
        ///A test for countWays
        ///</summary>
        [TestMethod()]
        public void CountWaysTest()
        {
            Recursion target = new Recursion(); // TODO: Initialize to an appropriate value
            int n = 5; // TODO: Initialize to an appropriate value
            int expected = 13; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountWays(n);
            Assert.AreEqual(expected, actual);
           
        }

        /// <summary>
        ///A test for countWaysDP
        ///</summary>
        [TestMethod()]
        public void CountWaysDPTest()
        {
            Recursion target = new Recursion(); 
            int n = 6;
            int[] map = new int[n]; // TODO: Initialize to an appropriate value

            for (int i = 0; i < map.Length; i++)
            {
                map[i] = -1; 
            }

           
            int actual;
            actual = target.CountWaysDP(n-1, map);
            int expected = map[n - 1];
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for getPath
        ///</summary>
        [TestMethod()]
        public void getPathTest()
        {
            Recursion target = new Recursion(); // TODO: Initialize to an appropriate value
            int x = 10; // TODO: Initialize to an appropriate value
            int y = 10; // TODO: Initialize to an appropriate value
            ArrayList path = new ArrayList() ; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.getPath(x, y, path);
           
           
        }



        /// <summary>
        ///A test for GetSubsets
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void GetSubsetsTest()
        {
            Recursion_Accessor target = new Recursion_Accessor(); // TODO: Initialize to an appropriate value
            int[] set = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int index = 0; // TODO: Initialize to an appropriate value
            ArrayList expected = null; // TODO: Initialize to an appropriate value
            ArrayList actual;
            actual = target.GetSubsets(set, index);
           
        }

        /// <summary>
        ///A test for generateParens
        ///</summary>
        [TestMethod()]
        public void generateParensTest()
        {
            Recursion target = new Recursion(); // TODO: Initialize to an appropriate value

            HashSet<string> expected = new HashSet<string>();
             int remaining = 3; // TODO: Initialize to an appropriate value
            
            HashSet<string> actual;
            actual = target.generateParens(remaining);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getSubsets2
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void getSubsets2Test()
        {
            Recursion_Accessor target = new Recursion_Accessor(); // TODO: Initialize to an appropriate value
            int[] test_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ArrayList set = new ArrayList(); // TODO: Initialize to an appropriate value
            foreach (int item in test_array)
            {
                set.Add(item);
            }
                        
          
            ArrayList expected = null; // TODO: Initialize to an appropriate value
            ArrayList actual;
            actual = target.GetSubsets2(set);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for makeChange
        ///</summary>
        [TestMethod()]
        public void makeChangeTest()
        {
            Recursion target = new Recursion(); // TODO: Initialize to an appropriate value
            int n = 100; // TODO: Initialize to an appropriate value
            int denom = 25; // TODO: Initialize to an appropriate value
            int actual; 
            actual = target.makeChange(n, denom);
            Console.WriteLine(actual.ToString());
        }

        /// <summary>
        ///A test for PlaceQueens
        ///</summary>
        [TestMethod()]
        public void PlaceQueensTest()
        {
            Recursion target = new Recursion(); // TODO: Initialize to an appropriate value
            int grid_size = 8; // TODO: Initialize to an appropriate value
            int row = 0; // TODO: Initialize to an appropriate value
            int[] columns = new int[grid_size]; // TODO: Initialize to an appropriate value
            ArrayList results = new ArrayList(); // TODO: Initialize to an appropriate value
            bool resutl = target.PlaceQueens(grid_size, row, columns,ref results);
           
        }
    }
}

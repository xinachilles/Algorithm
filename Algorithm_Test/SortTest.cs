using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for SortTest and is intended
    ///to contain all SortTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SortTest
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
        ///A test for MergeSort
        ///</summary>
        [TestMethod()]
        public void MergeSortTest()
        {
            Sort target = new Sort(); // TODO: Initialize to an appropriate value
            int[] array = { 2, 7, 4, 1, 5, 8, 9 };
            int[] arrayExpected = {1,2, 4, 5, 7, 8, 9 };
            int p = 0; // TODO: Initialize to an appropriate value
            int r = array.Length-1 ; // TODO: Initialize to an appropriate value
            target.MergeSort(ref array, p, r);
            CollectionAssert.AreEqual(arrayExpected, array);
       
            
        }

        /// <summary>
        ///A test for MergeTwoArray
        ///</summary>
        [TestMethod()]
        public void MergeTwoArrayTest()
        {
            Sort target = new Sort(); // TODO: Initialize to an appropriate value
            int[] a = {1,2,3,4,5}; // TODO: Initialize to an appropriate value
            int[] b = {2,3,4}; // TODO: Initialize to an appropriate value
            int[] c = new int[a.Length + b.Length];
            target.MergeTwoArray(a, b,ref c);
            int[] expected = { 1, 2, 2, 3, 3, 4, 4, 5 };
            CollectionAssert.AreEqual(c, expected);  

                        
        }

        /// <summary>
        ///A test for AnagramsSort
        ///</summary>
        [TestMethod()]
        public void AnagramsSortTest()
        {
            Sort target = new Sort(); // TODO: Initialize to an appropriate value
            string[] array = {"acre", "race", "care"}; // TODO: Initialize to an appropriate value
            target.AnagramsSort(ref array);
           
        }

        /// <summary>
        ///A test for AnagramsSortA
        ///</summary>
        [TestMethod()]
        public void AnagramsSortATest()
        {
            Sort target = new Sort(); // TODO: Initialize to an appropriate value
            string[] arr = { "acre", "race", "care" };  // TODO: Initialize to an appropriate value
            string[] expected = null; // TODO: Initialize to an appropriate value
            string[] actual;
            actual = target.AnagramsSortA(arr);
            Assert.AreEqual(expected, actual);
           
        }




        /// <summary>
        ///A test for BubbleSort
        ///</summary>
        [TestMethod()]
        public void BubbleSortTest()
        {
            Sort target = new Sort(); // TODO: Initialize to an appropriate value
            int[] array ={5,2,8,7,21,10} ; // TODO: Initialize to an appropriate value
            int[] arrayExpected = {2,5,7,8,10,21 }; // TODO: Initialize to an appropriate value
            target.BubbleSort(ref array);
           CollectionAssert.AreEqual(arrayExpected, array);
            
        }
    }
}

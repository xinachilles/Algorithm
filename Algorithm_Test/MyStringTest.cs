using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for MyStringTest and is intended
    ///to contain all MyStringTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MyStringTest
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
        ///A test for Uniquecharacters
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void UniquecharactersTest()
        {
            string t = "aacceeffhk";
            MyString_Accessor target = new MyString_Accessor(t); // TODO: Initialize to an appropriate value
            string result = target.Uniquecharacters(); // TODO: Initialize to an appropriate value
            Assert.AreEqual(result, "hk");

            //  Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }



        /// <summary>
        ///A test for revStr
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void RevStrTest()
        {
            string s = "abcdefg"; // TODO: Initialize to an appropriate value
            MyString_Accessor target = new MyString_Accessor(s); // TODO: Initialize to an appropriate value
            string result = target.revStr();
            Assert.AreEqual(result, "gfedcba");
        }


        /// <summary>
        ///A test for ComStr
        ///</summary>
        [TestMethod()]
        public void ComStrTest()
        {
            string t = "aabcccccaaa"; // TODO: Initialize to an appropriate value
            MyString target = new MyString(t); // TODO: Initialize to an appropriate value
            string expected = "a2b1c5a3"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ComStr();
            Assert.AreEqual(expected, actual);
            
        }

        /// <summary>
        ///A test for RepStr
        ///</summary>
        [TestMethod()]
        public void RepStrTest()
        {
            string t = "Mr John Smith"; // TODO: Initialize to an appropriate value
            MyString target = new MyString(t); // TODO: Initialize to an appropriate value
            string inString = "%20"; // TODO: Initialize to an appropriate value
            string expected = "Mr%20John%20Smith"; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.RepStr(inString);
            Assert.AreEqual(expected, actual);
            
        }



        /// <summary>
        ///A test for IsUniqueChars
        ///</summary>
        [TestMethod()]
        public void IsUniqueCharsTest()
        {
            string t = string.Empty; // TODO: Initialize to an appropriate value
            MyString target = new MyString(t); // TODO: Initialize to an appropriate value
            string str = string.Empty; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsUniqueChars(str);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}

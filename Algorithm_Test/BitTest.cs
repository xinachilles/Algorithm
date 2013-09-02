using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CosoleApplication1_Test
{
    
    
    /// <summary>
    ///This is a test class for BitTest and is intended
    ///to contain all BitTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BitTest
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
        ///A test for printBinary
        ///</summary>
        [TestMethod()]
        public void printBinaryTest()
        {
            Bit target = new Bit(); // TODO: Initialize to an appropriate value
            double num = 0.101; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.printBinary(num);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DrawLine
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ClassLibrary.dll")]
        public void DrawLineTest()
        {
            Bit_Accessor target = new Bit_Accessor(); // TODO: Initialize to an appropriate value
            byte[] screen = {1,2,3,4,5,6,7}; // TODO: Initialize to an appropriate value
            int width = 0; // TODO: Initialize to an appropriate value
            int xl = 0; // TODO: Initialize to an appropriate value
            int x2 = 6; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            target.DrawLine(screen, width, xl, x2, y);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}

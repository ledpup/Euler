using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    /// <summary>
    ///This is a test class for Euler6Test and is intended
    ///to contain all Euler6Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Euler6Test
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


        [TestMethod()]
        public void Euler6CsTest()
        {
            int expected = 25164150; 
            int actual;
            actual = EulerCs.Euler6.Result();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Euler6FsTest()
        {
            int expected = 25164150;
            int actual;
            actual = EulerFsLibrary.Euler6.result;
            Assert.AreEqual(expected, actual);
        }
    }
}

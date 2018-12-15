using WindowsFormsApp1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public void aaTest()
        {
            Assert.Fail();
        }
    }
}

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestMethod2()
        {
            WindowsFormsApp1.Form1 abc = new Form1();

            //Assert.Fail();
            Assert.AreEqual(12, abc.aa(10, 2));
        }
    }
}

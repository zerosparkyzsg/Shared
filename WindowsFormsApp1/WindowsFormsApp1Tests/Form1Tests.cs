using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void aaTest()
        {
            WindowsFormsApp1.Form1 abc = new Form1();
            
            //Assert.Fail();
            Assert.AreEqual (12, abc.aa(10, 2));
        }
    }
}
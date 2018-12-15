using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [TestFixture]
    public class NUnitTestClass1
    {
        [Test]
        public void TestMethodNUnit()
        {
            Form1 f1 = new Form1();
                
            // TODO: Add your test code here
            Assert.AreEqual (21,f1.aa(10, 11));
        }
    }
}

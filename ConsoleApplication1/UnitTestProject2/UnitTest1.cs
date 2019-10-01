using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCeil()
        {
            int result1 = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result1);

            int result2 = Program.Ceil((float)-2.3f);
            Assert.AreEqual(-2, result2);

            int result3 = Program.Ceil(3);
            Assert.AreEqual(3, result3);
        }
        [TestMethod]
        public void TestFloor()
        {
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor((float)-2.3f);
            Assert.AreEqual(-3, result2);

            int result3 = Program.Floor(3);
            Assert.AreEqual(3, result3);
        }
    }
}

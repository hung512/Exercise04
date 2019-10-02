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
        [TestMethod]
        public void pow()
        {
            int result2 = Program.pow(2, 3);
            Assert.AreEqual(8, result2);

            int result3 = Program.pow(3, 0);
            Assert.AreEqual(1, result3);

            int resultAm7 = Program.pow(2, -7);
            Assert.AreEqual(0, resultAm7);
        }
        [TestMethod]
        public void Abs()
        {
            int resultAm2 = Program.Abs(-2);
            Assert.AreEqual(2, resultAm2);

            int result3 = Program.Abs(3);
            Assert.AreEqual(3, result3);

            int result0 = Program.Abs(0);
            Assert.AreEqual(0, result0);
        }
        [TestMethod]
        public void Factorial()
        {
            long result2 = Program.Factorial(2);
            Assert.AreEqual(2, result2);

            long result3 = Program.Factorial(3);
            Assert.AreEqual(6, result3);

            long result0 = Program.Factorial(0);
            Assert.AreEqual(1, result0);

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryCal;

namespace UnitTestCal
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string x = "12.3" , y = "30.52";
            Assert.AreEqual<float>(new Calculator("+", x, y).Cal(),float.Parse(x) + float.Parse(y));
            Assert.AreEqual<float>(new Calculator("-", x, y).Cal(), float.Parse(x) - float.Parse(y));
            Assert.AreEqual<float>(new Calculator("*", x, y).Cal(), float.Parse(x) * float.Parse(y));
            Assert.AreEqual<float>(new Calculator("/", x, y).Cal(), float.Parse(x) / float.Parse(y));
            Assert.AreNotEqual<float>(new Calculator("+", x, y).Cal(), float.Parse(x) / float.Parse(y));
            Assert.AreNotEqual<float>(new Calculator("-", x, y).Cal(), float.Parse(x) * float.Parse(y));
            Assert.AreNotEqual<float>(new Calculator("*", x, y).Cal(), float.Parse(x) - float.Parse(y));
            Assert.AreNotEqual<float>(new Calculator("/", x, y).Cal(), float.Parse(x) + float.Parse(y));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppVeyorTest;

namespace UnitTests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            var expected = "Hello, world!"; 
            var actual = new TestClass().TestMethod();
            Assert.AreEqual(expected, actual);
        }
    }
}

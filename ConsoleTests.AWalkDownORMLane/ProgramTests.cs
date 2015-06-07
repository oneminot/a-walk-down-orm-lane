using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Console.AWalkDownORMLane;

namespace ConsoleTests.AWalkDownORMLane
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMain()
        {
            Assert.AreEqual(Program.Main(),0);
        }
    }
}

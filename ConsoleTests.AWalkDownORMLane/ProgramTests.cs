using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTests.AWalkDownORMLane
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMain()
        {
            Assert.AreEqual(Console.AWalkDownORMLane.Program.Main(),0);
        }
    }
}

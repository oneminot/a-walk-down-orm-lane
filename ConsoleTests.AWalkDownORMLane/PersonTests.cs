using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleTests.AWalkDownORMLane
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void TestPersonEmptyConstructor()
        {
            var person = new Person();
            Assert.AreEqual(person.Name, "");
        }
    }
}

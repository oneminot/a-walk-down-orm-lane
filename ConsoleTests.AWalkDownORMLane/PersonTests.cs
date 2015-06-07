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
            var person = new Console.AWalkDownORMLane.Person();
            Assert.AreEqual(person.Name, "");
        }

        [TestMethod]
        public void TestPersonConstructorWithName()
        {
            const string myName = "Katya";
            var person = new Console.AWalkDownORMLane.Person(name: myName);
            Assert.AreEqual(person.Name, myName);
        }
    }
}

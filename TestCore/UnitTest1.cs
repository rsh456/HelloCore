using NUnit.Framework;
using HelloCore;

namespace TestCore
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Hello World", Program.CreateMessage());
        }
    }
}
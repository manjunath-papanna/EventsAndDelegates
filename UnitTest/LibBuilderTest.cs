using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventsAndDelegates;

namespace UnitTest
{
    [TestClass]
    public class LibBuilderTest
    {
        [TestMethod]
        public void TestLibBuilder()
        {
            var libBuilder = new LibBuilder();
            Assert.AreEqual(3, libBuilder.Plugins.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using log2log.Core;
using log2log.LogBuilding;
using log2log.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace log2log.Tests
{
    [TestClass]
    public class WriteToFile_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var logFactory = new LogFactory("test", "loggersTest\text.log", "info");

            
            Assert.IsTrue(result);
        }
    }
}

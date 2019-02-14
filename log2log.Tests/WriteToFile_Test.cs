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
            var logExecuter = new LogFactory(new Loglog("~/log/lll.log")).CreateLogWriter();

            ILoggerClient logger = logExecuter.GetLoggerClient();
            var result1 = logger.Info("sdfsfdf");
            var result2 = logger.Warning("sdbhfh");

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);

        }
    }
}

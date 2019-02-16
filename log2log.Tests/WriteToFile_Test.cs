using System;
using System.Collections.Generic;
using System.Threading;
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
            var logExecuter = new LogFactory(new Loglog("hhh.txt")).CreateLogWriter();

            ILoggerClient logger = logExecuter.GetLoggerClient();
            var result1 = logger.Info("sdfsfdf");
            var result2 = logger.Warning("sdbhfh");
            logger.Warning("sdbhfh");
            logger.Warning("sdbhfh");
            logger.Warning("sdbhfh");
            logger.Warning("sdbhfh");
            int i = 0;
            while (i < 20000)
            {
                logger.Warning("hgjghjhj");
                i++;
            }
                

            var result3 = logger.Warning("hgjghjhj");
            Thread.Sleep(3000);
            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
        }

        [TestMethod]
        public void TestMethod2()
        {


            var textres = new TextLogWriter("ttt.txt");
            var l = new Queue<ILogData>();
            int i = 0;
            while(i < 200)
            {
                l.Enqueue(new LogData("Info", "ok"));
                i++;
            }
            
            textres.loggerQueue = l;
            var res = textres.Write();


            Assert.IsTrue(res);
        }
    }
}

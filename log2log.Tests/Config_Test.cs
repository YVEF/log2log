using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log2log.Tests
{
    [TestClass]
    public class Config_Test
    {
        

        [TestMethod]
        public void Method2()
        {
            ILoggerClient logger = LogManager.GetCurrentLogInstance();
            int i = 0;
            while(i<200000)
            {
                logger.Info("abrakadabra");
                i++;
            }
            System.Threading.Thread.Sleep(7000);
            var result = File.Exists(@"C:\Users\Eric\source\repos\log2log\log2log.Tests\LogFile.txt");
            Assert.IsTrue(result);
            
        }
    }
}

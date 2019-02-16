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
        public void Method1()
        {
            var conf = log2log.Configuration.LogConfigHelper.GetConfigFromDomain();
            var d = (log2log.Configuration.LogConfigSection)conf.GetSection("log2log");
            var d2 = conf.GetSection("log2log").ElementInformation;
            var d3 = conf.GetSection("log2log").CurrentConfiguration;
            var d4 = conf.GetSection("log2log").CurrentConfiguration.AppSettings;
            var d5 = conf.GetSection("log2log").SectionInformation.Name;
            var t = d.LogItems[0].Path;
            Assert.IsNotNull(conf);
        }

        [TestMethod]
        public void Method2()
        {
            ILoggerClient logger = LogManager.GetCurrentLogInstance();
            int i = 0;
            while(i<20000000)
            {
                logger.Info("abrakadabra");
                i++;
            }
            //System.Threading.Thread.Sleep(7000);
            var result = File.Exists(@"C:\Users\Eric\source\repos\log2log\log2log.Tests\LogFile.txt");
            Assert.IsTrue(result);
            
        }
    }
}
